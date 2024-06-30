using System.Threading.Tasks;
using System;
using static WorkerHub.Service.EmployeeDetailPermissionService;
using System.Collections.Generic;
using WorkerHub.Service.Dto;

namespace WorkerHub.Interface
{
	public interface IEmployeeDetailPermissionService
	{
		Task RequestProfileAccess(string employeeId, string hiringManagerId);
		Task UpdateProfileAccessRequest(Guid id, bool status);
		Task<bool> CheckIfRequestExists(string employeeId, string hiringManagerId);
		Task<bool> CheckIfUserHasAccessAsync(string employeeId, string hiringManagerId);
		Task<List<EmployeeDetailPermissionViewDto>> GetEmployeeDetailRequestViewAsync(string employeeId, string status);
		Task<List<EmployeeDetailPermissionForManagerViewDto>> GetEmployeeDetailRequestForManagerViewAsync(string hiringManagerId, string status);
	}
}
