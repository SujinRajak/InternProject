using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    public class ResumeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IApplicationUser _context;
        private readonly ApplicationDbContext dbcontext;
        private readonly IQualification _qualContext;


        /// <summary>
        /// Constructorr
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        /// <param name="context"></param>
        /// <param name="_db"></param>
        /// <param name="qualContext"></param>
        public ResumeController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IApplicationUser context, ApplicationDbContext _db, IQualification qualContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            dbcontext = _db;
            _qualContext = qualContext;
        }


        [HttpGet]
        public IActionResult ExpCreate()
        {
            ProfileDetialViewModel model = new ProfileDetialViewModel();
            return View(model);
        }




      
    }
}
