using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.Service;

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

		public IActionResult Index()
		{
			return View();
		}
		public async Task<bool> Request(string employeeId)
		{
			ApplicationUser user = _context.getUser(_userManager.GetUserId(User));

			if (await _paymentService.CheckIfUserIsSubscribed(new Guid(user.Id)))
			{
				await _employeeDetailPermissionService.RequestProfileAccess(employeeId, user.Id);
				return true;
			}
			return false;
		}
		public async Task<bool> Update(Guid id, bool status)
		{
			return(await _employeeDetailPermissionService.UpdateProfileAccessRequest(id, status));
		}
	}
}
