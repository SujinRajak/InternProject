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

        public async Task<IActionResult> Index(int? page, string status)
        {
            int pageSize = 10; // Number of items per page
            int pageNumber = page ?? 1;

            ApplicationUser user = _context.getUser(_userManager.GetUserId(User));

            // Fetch data based on the status filter
            var data = await _employeeDetailPermissionService.GetEmployeeDetailRequestViewAsync(user.Id, status);

            // Apply pagination
            var paginatedData = data
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();

            // Calculate total pages
            int totalCount = data.Count();
            int pageCount = (int)Math.Ceiling((double)totalCount / pageSize);

            // Pass page information to the view
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageCount = pageCount;
            ViewBag.Status = status; // Pass the current status filter to the view

            return View(paginatedData);
        }
        public async Task<IActionResult> HierIndex(int? page, string status)
        {
            int pageSize = 10; // Number of items per page
            int pageNumber = page ?? 1;

            ApplicationUser user = _context.getUser(_userManager.GetUserId(User));

            // Fetch data based on the status filter
            var data = await _employeeDetailPermissionService.GetEmployeeDetailRequestForManagerViewAsync(user.Id, status);

            // Apply pagination
            var paginatedData = data
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();

            // Calculate total pages
            int totalCount = data.Count();
            int pageCount = (int)Math.Ceiling((double)totalCount / pageSize);

            // Pass page information to the view
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageCount = pageCount;
            ViewBag.Status = status; // Pass the current status filter to the view

            return View(paginatedData);
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
