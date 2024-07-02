using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.Service;
using System.Linq;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
	public class EmployeeDetailPermissionController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly IApplicationUser _context;
		private readonly ApplicationDbContext _dbcontext;
		private readonly IEmployeeDetailPermissionService _employeeDetailPermissionService;
		private readonly IPaymentService _paymentService;

		public EmployeeDetailPermissionController(UserManager<ApplicationUser> userManager,
			IApplicationUser context,
			ApplicationDbContext dbcontext,
			IEmployeeDetailPermissionService employeeDetailPermissionService,
			IPaymentService paymentService)
		{
			_userManager = userManager;
			_context = context;
			_dbcontext = dbcontext;
			_employeeDetailPermissionService = employeeDetailPermissionService;
			_paymentService = paymentService;
		}

        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 10; // Number of items per page
            int pageNumber = page ?? 1;


            var permissions = await (
             from permission in _dbcontext.EmployeeDetailPermissions
             join hiringManager in _dbcontext.applicationUser on permission.HiringManagerId equals hiringManager.Id
             join employee in _dbcontext.Users on permission.EmployeeId equals employee.Id
             orderby permission.ExpiresIn descending
             select new EmployeePermissionViewModel
             {
                 Id = permission.Id,
                 HiringManagerName = hiringManager.UserName,
                 EmployeeName = employee.UserName,
                 Status = permission.Status,
                 ExpiresIn = permission.ExpiresIn
             }
         )
         .Skip((pageNumber - 1) * pageSize)
         .Take(pageSize)
         .ToListAsync();

            int pageCount = (int)Math.Ceiling((double)permissions.Count / pageSize);

            ViewBag.PageNumber = pageNumber;
            ViewBag.PageCount = pageCount;

            return View(permissions);
        }
        public async Task<bool> AccessRequest(string id)
		{
			ApplicationUser user = _context.getUser(_userManager.GetUserId(User));

			if (await _paymentService.CheckIfUserIsSubscribed(new Guid(user.Id)))
			{
				await _employeeDetailPermissionService.RequestProfileAccess(id, user.Id);
				return true;
			}
			return false;
		}
        [HttpPost]
        public async Task<bool> Update(Guid id, bool status)
		{
			return(await _employeeDetailPermissionService.UpdateProfileAccessRequest(id, status));
		}
	}
}
