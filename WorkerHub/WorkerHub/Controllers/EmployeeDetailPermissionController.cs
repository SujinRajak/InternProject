using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WorkerHub.Interface;
using WorkerHub.Models;

namespace WorkerHub.Controllers
{
	public class EmployeeDetailPermissionController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly IApplicationUser _context;
		private readonly ApplicationDbContext _dbcontext;
		private readonly IEmployeeDetailPermissionService _employeeDetailPermissionService;

		public EmployeeDetailPermissionController(UserManager<ApplicationUser> userManager,
			IApplicationUser context,
			ApplicationDbContext dbcontext,
			IEmployeeDetailPermissionService employeeDetailPermissionService)
		{
			_userManager = userManager;
			_context = context;
			_dbcontext = dbcontext;
			_employeeDetailPermissionService = employeeDetailPermissionService;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
