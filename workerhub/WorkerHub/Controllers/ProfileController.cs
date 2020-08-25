using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    [Authorize]
    public class ProfileController : Controller
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
        public ProfileController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IApplicationUser context, ApplicationDbContext _db, IQualification qualContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            dbcontext = _db;
            _qualContext = qualContext;
        }


        /// <summary>
        /// Get section for Profile seting when we req the profile section then everything will be available to us
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ProfileSection()
        {
            //var id = _userManager.GetUserAsync(User);
            //var idid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ApplicationUser user = _context.getUser(_userManager.GetUserId(User));
            ProfileDetialViewModel det = new ProfileDetialViewModel()
            {
                AppUser = _context.getUser(_userManager.GetUserId(User)),
            };
            return View(det);
        }



        /// <summary>
        /// geeting the the application users from id in gettt method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            ApplicationUser user = await dbcontext.applicationUser.FindAsync(_userManager.GetUserId(User));
            ValidateAppmodel getuserinfo = new ValidateAppmodel()
            {
                Id=user.Id,
                FirstName = user.Firstname,
                LastName = user.LastName,
                Descripition=user.Descripition,
                PermanentAddress=user.PermanentAddress,
                TemporaryAddress=user.TemporaryAddress,
                PhoneNumber=user.PhoneNumber,
                Sex=user.Sex,
                InactiveUsers=user.InactiveUsers
            };
            return View(getuserinfo);
        }


        /// <summary>
        /// submitting the form after editing the details of the users
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(ValidateAppmodel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = _userManager.GetUserId(User);
                var update = await dbcontext.applicationUser.FindAsync(model.Id);
                update.Firstname = model.FirstName;
                update.LastName = model.LastName;
                update.PhoneNumber = model.PhoneNumber;
                update.Sex = model.Sex;
                update.Descripition = model.Descripition;
                update.PermanentAddress = model.PermanentAddress;
                update.TemporaryAddress = model.TemporaryAddress;
                update.InactiveUsers =model.InactiveUsers;
                _context.update(update);
                return RedirectToAction("ProfileSection", "Profile");
            }
            return View(model);
        }



        /// <summary>
        /// for the delete button of the user the user clicks on the delete button
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> DeletePartial()
        {
            //used to get the currrent user 
            var user = await _userManager.GetUserAsync(User);
            //sets the value of the current user to 1 
            user.InactiveUsers = true;
            dbcontext.SaveChanges();
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

    }
}
