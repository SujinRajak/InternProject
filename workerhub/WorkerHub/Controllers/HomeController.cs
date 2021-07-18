using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IApplicationUser _context;
        private ApplicationDbContext dbcontext;
        public HomeController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IApplicationUser context, ApplicationDbContext _db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            dbcontext = _db;
        }

        [HttpGet]
        public IActionResult Index(string SearchTerm)
        {
            //var employee = from m in dbcontext.SkillSets.Find()
            //               select m;

            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
           
            DisplayEmployee display = new DisplayEmployee()
            {
                applicationUsers = dbcontext.applicationUser.ToList(),
                userExperiences = dbcontext.Experices.ToList()
            };
            return View(display);
        }

        [HttpGet]
        public IActionResult Detail(string id)
        {
            HomeDetailsViewModel details = new HomeDetailsViewModel()
            {
                AppUser = _context.getUser(id)

            };
            return View(details);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            return View(model);
        }


        [HttpGet]
        public IActionResult MoreContent()
        {
            return View();
        }

    }
}
