﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly IApplicationUser _applicationinfo;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context, IApplicationUser applicationInfo, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _applicationinfo = applicationInfo;
            this.roleManager = roleManager;
        }



        /// <summary>
        /// Register
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            RegisterViewModel register = new RegisterViewModel();
            register.Roles= roleManager.Roles.Where(x=>x.Name!="Admin").ToList();
            return View(register);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel Input)
        {
            if (ModelState.IsValid)
            {
                //creating a new user object of my own and capturing data of the user from the model 
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, Firstname = Input.FirstName, LastName = Input.LastName, InactiveUsers = false,dob=DateTime.Now,Availablility=true };
                //to create new user we need to make use of the createasyn method to create a new user 
                //there are two overloaded version so the first instance is of the user oof type my own User object
                //the second param is the password.so then this password is then hash stored securely oin the database
                //create aync is an asynchornous methos so we should await it and since it is the await we need to turn into async method
                // and wrap the action result in a task
                var result = await _userManager.CreateAsync(user, Input.Password);

                var role = await roleManager.FindByIdAsync(Input.RoleName);
                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Role id ={Input.RoleName} count not be found";
                    return View("NotFound");

                }
               var userRoleresult= await _userManager.AddToRoleAsync(user, role.Name);

                Input.Roles= roleManager.Roles.Where(x => x.Name != "Admin").ToList();
                //built in method suceeeded to check if the result succeded or not
                if (result.Succeeded && userRoleresult.Succeeded)
                {
                    //sign in th user and forwarded to the location
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    //var abc = System.Security.Claims.ClaimsPrincipal.Current.Identities.ToList();

                    //sending the value of the user id from controller to the views
                    //return RedirectToAction("CreateRole", "Administration");
                    return RedirectToAction("Login", "Account");
                }

                //loopthrough each errors in error collection
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(Input);
        }




        /// <summary>
        /// Loginnn
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);



                //built in method suceeeded to check if the result succeded or not
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(model.Email);
                    // Get the roles for the user
                    var roles = await _userManager.GetRolesAsync(user);

                    if (roles.First() == "Admin")
                    {
                        return RedirectToAction( "AdminPage","Administration");
                    }
                    else if (roles.First()== "Hiring Manager")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    
                }
                ModelState.AddModelError(string.Empty, "Invalid User Login");
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



        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }





        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePassViewModel model)
        {
            if (ModelState.IsValid)
            {
                var change = await _userManager.GetUserAsync(User);
                if (change == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                var result = await _userManager.ChangePasswordAsync(change, model.CurrentPassword, model.ConfirmPassword);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }
                await _signInManager.RefreshSignInAsync(change);
                return RedirectToAction("ProfileSection", "Profile");

            }
            return View(model);
        }






    }
}
