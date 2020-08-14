using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
   
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }



        /// <summary>
        /// Register
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel Input)
        {
            if (ModelState.IsValid)
            {
                //creating a new user object of my own and capturing data of the user from the model 
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email};


                //creating a new user of applicationUser and capturing the username and data of the user from the view model

                var AppUser = new ApplicationUser { Firstname = Input.FirstName, LastName = Input.LastName, InactiveUsers = false };
                //to create new user we need to make use of the createasyn method to create a new user 
                //there are two overloaded version so the first instance is of the user oof type my own User object
                //the second param is the password.so then this password is then hash stored securely oin the database
                //create aync is an asynchornous methos so we should await it and since it is the await we need to turn into async method
                // and wrap the action result in a task
                var result = await _userManager.CreateAsync(user, Input.Password);
                _context.applicationUser.Add(AppUser);
                await _context.SaveChangesAsync();
                
                //built in method suceeeded to check if the result succeded or not
                if (result.Succeeded)
                {

                    //sign in th user and forwarded to the location
                    await _signInManager.SignInAsync(user,isPersistent:false);
                    return RedirectToAction("ProfileSection", "Profile");
                     
                }

                //loopthrough each errors in error collection
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(Input);
        }




        /// <summary>
        /// Loginnn
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

                //built in method suceeeded to check if the result succeded or not
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty,"Invalid User Login");
            }
            return View(model);
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
       
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }    
    }
}
