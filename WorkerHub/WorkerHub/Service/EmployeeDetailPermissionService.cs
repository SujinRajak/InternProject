using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.Service.Dto;
using WorkerHub.ViewModel;

namespace WorkerHub.Service
{
	public class EmployeeDetailPermissionService: IEmployeeDetailPermissionService
	{
		private readonly ApplicationDbContext _dbcontext;
		private readonly IEmailSender _emailService;

		public EmployeeDetailPermissionService(ApplicationDbContext dbcontext, 
			IEmailSender emailService)
		{
			_dbcontext = dbcontext;
			_emailService = emailService;
		}

		public async Task RequestProfileAccess(string employeeId, string hiringManagerId)
		{
			_dbcontext.Add(new EmployeeDetailPermission
			{
				Status = "requested",
				EmployeeId = employeeId,
				HiringManagerId = hiringManagerId,
				ExpiresIn = DateTime.Now.AddMonths(3)
			});

			await _dbcontext.SaveChangesAsync();
		}
		public async Task<bool> UpdateProfileAccessRequest(Guid id, bool status)
		{
			var data = await _dbcontext.EmployeeDetailPermissions.FirstAsync(s => s.Id.Equals(id));
			if(data.Status != "requested")
				return false;
			data.Status = status == true? "approved" : "rejected";
			data.ExpiresIn = DateTime.Now.AddMonths(3);
			await _dbcontext.SaveChangesAsync();

			if (status)
				SendEmail(data.HiringManagerId, data.EmployeeId, "Approved");
			else
				SendEmail(data.HiringManagerId, data.EmployeeId, "Rejected");

			return true;
		}
		public async Task<bool> CheckIfRequestExists(string employeeId, string hiringManagerId)
		{
			if (await _dbcontext.EmployeeDetailPermissions.AnyAsync(s => s.HiringManagerId.Equals(hiringManagerId)
																	&& s.EmployeeId.Equals(employeeId)
																	//&& s.Status.Equals("requested")
																	&& s.ExpiresIn > DateTime.Now))
				return true;
			return false;
		}
		public async Task<bool> CheckIfUserHasAccessAsync(string employeeId, string hiringManagerId)
		{
			if (await _dbcontext.EmployeeDetailPermissions.AnyAsync(s => s.HiringManagerId.Equals(hiringManagerId)
																	&& s.EmployeeId.Equals(employeeId)
																	&& s.ExpiresIn > DateTime.Now
																	&& s.Status.Equals("approved")))
				return true;
			return false;
		}
		public async Task<List<EmployeeDetailPermissionViewDto>> GetEmployeeDetailRequestViewAsync(string employeeId, string status)
		{
			var response = new List<EmployeeDetailPermissionViewDto>();
			if (string.IsNullOrEmpty(status))
				status = "requested";
			var datas = _dbcontext.EmployeeDetailPermissions.Where(s =>s.EmployeeId.Equals(employeeId)
																	&& s.Status.Equals(status));

			if(datas.Any())
			{
				response.AddRange(await datas.Select(s => new EmployeeDetailPermissionViewDto
				{
					HiringManager = s.HiringManager.Firstname + s.HiringManager.LastName,
					HiringManagerId = s.HiringManagerId,
					Status = status,
					Id = s.Id
				}).ToListAsync());
			}

			return response;
		}
		public async Task<List<EmployeeDetailPermissionForManagerViewDto>> GetEmployeeDetailRequestForManagerViewAsync(string hiringManagerId, string status)
		{
			var response = new List<EmployeeDetailPermissionForManagerViewDto>();
			if (string.IsNullOrEmpty(status))
				status = "approved";
			var datas = _dbcontext.EmployeeDetailPermissions.Where(s =>s.HiringManagerId.Equals(hiringManagerId)
																	&& s.Status.Equals(status));

			if(datas.Any())
			{
				response.AddRange(await datas.Select(s => new EmployeeDetailPermissionForManagerViewDto
				{
					Employee = s.HiringManager.Firstname + s.HiringManager.LastName,
					EmployeeId = s.HiringManagerId,
					Status = status,
					Id = s.Id
				}).ToListAsync());
			}

			return response;
		}


		private void SendEmail(string userid, string employeeid, string status)
		{
			try
			{
				var hr = _dbcontext.applicationUser.First(s => s.Id.Equals(userid));
				var emp = _dbcontext.applicationUser.First(s => s.Id.Equals(employeeid));

				string EmailBodyCommon = $"Profile access request {status} for user {emp.Firstname} {emp.LastName}";
				
				string subject = $"Profile access request {status}";
				_emailService.SendEmail(hr.UserName ?? "", subject, EmailBodyCommon);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
