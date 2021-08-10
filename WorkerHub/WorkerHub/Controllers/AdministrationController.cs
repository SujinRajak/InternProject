using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly IApplicationUser _detcontext;
        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context, IApplicationUser detcontext)
        {
            this.roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _detcontext = detcontext;
        }


        [HttpGet]
        public async Task<IActionResult> AdminPage()
        {
            var role = roleManager.Roles.ToList();
            var highmang = (from c in _context.UserRoles
                            join p in _context.Roles on c.RoleId equals p.Id
                            where p.Name != "Employee" && p.Name != "Admin"
                            select new { c.UserId }).ToList();
            var Employee = (from c in _context.UserRoles
                            join p in _context.Roles on c.RoleId equals p.Id
                            where p.Name != "Hiring Manager" && p.Name != "Admin"
                            select new { c.UserId }).ToList();
            AdminProfileModel model = new AdminProfileModel()
            {
                identityRoles = role,
                AppUser = _context.applicationUser.ToList(),
                HighUserRole = highmang.Select(x => x.UserId).ToList(),
                EmployeeUserRole = Employee.Select(x => x.UserId).ToList(),
                UserRole = _context.UserRoles.ToList(),
                Roles = roleManager.Roles.ToList()
            };

            foreach (var item in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(item, role.Select(a => a.Name).ToString()))
                {
                    model.Users.Add(item.UserName);
                }
            }
            return View(model);
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
                var result = await roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("AdminPage", "Administration");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
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
                var result = await roleManager.DeleteAsync(del);
            }
            return RedirectToAction("AdminPage", "Administration");
        }

        [HttpGet]
        public IActionResult RoleAssign()
        {
            RoleassignModel roles = new RoleassignModel();
            roles.UserRole = _context.UserRoles.ToList();
            roles.Roles = roleManager.Roles.ToList();
            roles.AppUser = _userManager.Users.ToList();
            return View(roles);
        }

        [HttpPost]
        public async Task<IActionResult> RoleAssign(RoleassignModel usersRole)
        {

            if (ModelState.IsValid)
            {
                var role = await roleManager.FindByIdAsync(usersRole.UseRoleName);
                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Role id ={usersRole.UseRoleName} count not be found";
                    return View("NotFound");

                }
                IdentityResult result = null;
                var user = await _userManager.FindByIdAsync(usersRole.UserName);
                var currentRoles = await _userManager.GetRolesAsync(user);

                //if (!(await _userManager.IsInRoleAsync(user, role.Name)))
                //{
                //   result=await _userManager.AddToRoleAsync(user,role.Name);
                //}
                //adding comndition
                if (currentRoles.Count == 0)
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, currentRoles.First());
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                return RedirectToAction("RoleAssign");
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> RemoveRole(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var currentRoles = await _userManager.GetRolesAsync(user);
            if (user != null && currentRoles.Count > 0)
            {
                await _userManager.RemoveFromRoleAsync(user, currentRoles.First());
            }
            return RedirectToAction("RoleAssign", "Administration");
        }

        [HttpPost]
        public async Task<ActionResult> RemoveUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("AdminPage", "Administration");
        }

        [HttpGet]
        public IActionResult ShowEmployee()
        {
            try
            {

                DisplayEmployee display = new DisplayEmployee();
                var userExp = _context.Experices.GroupBy(c => c.Userid).Select(g =>
                    new
                    {
                        Id = g.Key,
                    }).ToList();
                var applicationUsersdata =_context.applicationUser.ToList();
                var userRole = _context.UserRoles.ToList();
                var Roles = roleManager.Roles.ToList();

                var employeequery = from c in roleManager.Roles
                                    join cn in _context.UserRoles on c.Id equals cn.RoleId
                                    where c.Name != "Admin" && c.Name != "Hiring Manager"
                                    select new { cn.UserId };

                List<ApplicationUser> employees = new List<ApplicationUser>();
                foreach (var usersss in applicationUsersdata)
                {
                    foreach (var users in employeequery)
                    {
                        if (usersss.Id == users.UserId)
                        {
                            employees.Add(usersss);
                        }
                    }
                }

                var nostarQuery = from c in _context.applicationUser
                                  join p in _context.Experices
                .GroupBy(c => c.Userid)
                .Select(g =>
                    new
                    {
                        Id = g.Key,
                        totalexp = g.Sum(s => s.yearsExp),
                    }
                 ) on c.Id equals p.Id into pss
                                  from add in pss.DefaultIfEmpty()
                                  select new { c.Id, add };



                foreach (var item in nostarQuery)
                {
                    display.TotalExpdata.Add(new TotalExp
                    {
                        userid = item.Id,
                        totalExp = item.add.totalexp
                    });
                }

                display.applicationUsers = employees.ToList();

                return View(display);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet]
        public IActionResult ShowHiringManager()
        {
            try
            {
                DisplayEmployee display = new DisplayEmployee();
                var applicationUsersdata = _context.applicationUser.ToList();
                var userRole = _context.UserRoles.ToList();
                var Roles = roleManager.Roles.ToList();

                var employeequery = from c in roleManager.Roles
                                    join cn in _context.UserRoles on c.Id equals cn.RoleId
                                    where c.Name != "Admin" && c.Name != "Employee"
                                    select new { cn.UserId };

                List<ApplicationUser> employees = new List<ApplicationUser>();
                foreach (var usersss in applicationUsersdata)
                {
                    foreach (var users in employeequery)
                    {
                        if (usersss.Id == users.UserId)
                        {
                            employees.Add(usersss);
                        }
                    }
                }

                display.applicationUsers = employees.ToList();

                return View(display);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpGet]
        public IActionResult EmployeeProfile(string id)
        {
            HomeDetailsViewModel details = new HomeDetailsViewModel()
            {
                AppUser = _detcontext.getUser(id)

            };
            return View(details);
        }

        [HttpGet]
        public IActionResult ManagerProfile(string id)
        {
            //var id = _userManager.GetUserAsync(User);
            //var idid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ApplicationUser user = _detcontext.getUser(id);
            ProfileDetialViewModel det = new ProfileDetialViewModel()
            {
                AppUser = _detcontext.getUser(id),
                Id = user.Id,
                FirstName = user.Firstname,
                LastName = user.LastName,
                Descripition = user.Descripition,
                PermanentAddress = user.PermanentAddress,
                TemporaryAddress = user.TemporaryAddress,
                PhoneNumber = user.PhoneNumber,
                Sex = user.Sex,
                InactiveUsers = user.InactiveUsers,
                Availabilility = (user.Availablility == null) ? true : user.Availablility,
                citizenship = user.citizenship,
                country = user.country,
                streetname = user.streetname,
                city = user.city,
                dob = user.dob,
                states = user.states,
                bloodgroup = user.bloodgroup
            };
            var nostarQuery = from c in _context.applicationUser
                              join p in _context.Experices
            .GroupBy(c => c.Userid)
            .Select(g =>
                new
                {
                    Id = g.Key,
                    totalexp = g.Sum(s => s.yearsExp),
                }
             ) on c.Id equals p.Id into pss
                              from add in pss.DefaultIfEmpty()
                              select new { c.Id, add };


            foreach (var item in nostarQuery)
            {
                if (item.Id == user.Id)
                {
                    det.TotalExpdata.totalExp = item.add.totalexp;
                    det.TotalExpdata.userid = item.Id;
                }

            }
            return View(det);
        }
    }
}
