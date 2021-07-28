using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole()
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("AdminPage", "Administration");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                ViewData["ModelIsValid"] = false;
            }
            ViewData["ModelIsValid"] = true;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AdminPage()
        {
            var role = roleManager.Roles.ToList();
            AdminProfileModel model = new AdminProfileModel()
            {
                identityRoles = role
            };
            foreach (var item in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(item, role.Select(a=>a.Name).ToString()))
                {
                    model.Users.Add(item.UserName);
                }
            }
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role by id={id} cannot be found";
                return View("NotFound");
            }

            var model = new EditRoleViewModel()
            {
                Id = role.Id,
                RoleName = role.Name
            };
           
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel roleModel)
        {
            var role = await roleManager.FindByIdAsync(roleModel.Id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role by id={roleModel.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = roleModel.RoleName;
                var result= await roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("AdminPage", "Administration");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
                return View(roleModel);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            var del = await roleManager.FindByIdAsync(id);
            if (del != null)
            {
                var result= await roleManager.DeleteAsync(del);
            }
            return RedirectToAction("AdminPage", "Administration");
        }


    }
}
