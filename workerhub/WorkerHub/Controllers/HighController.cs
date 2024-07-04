using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Config;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.Service;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    public class HighController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IApplicationUser _context;
        private ApplicationDbContext dbcontext;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IEmployeeDetailPermissionService _employeeDetailPermissionService;
        private Appsettings _app;
        private readonly IPaymentService _paymentService;
        public HighController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IApplicationUser context, ApplicationDbContext _db, RoleManager<IdentityRole> roleManager,
            IEmployeeDetailPermissionService employeeDetailPermissionService,
            IOptions<Appsettings> appConfig, 
            IPaymentService paymentService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            dbcontext = _db;
            this.roleManager = roleManager;
            _employeeDetailPermissionService = employeeDetailPermissionService;
            _app = appConfig.Value;
            _paymentService = paymentService;
        }

        [Authorize(Policy = "HiringManger")]
        [HttpGet]
        public IActionResult HighHome(string SearchTerm)
        {
            try
            {

                DisplayEmployee display = new DisplayEmployee();
                var userExp = dbcontext.Experices.GroupBy(c => c.Userid).Select(g =>
                    new
                    {
                        Id = g.Key,
                    }).ToList();
                var applicationUsersdata = dbcontext.applicationUser.ToList();
                var userRole = dbcontext.UserRoles.ToList();
                var Roles = roleManager.Roles.ToList();

                var employeequery = from c in roleManager.Roles
                                    join cn in dbcontext.UserRoles on c.Id equals cn.RoleId
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

                var nostarQuery = from c in dbcontext.applicationUser
                                  join p in dbcontext.Experices
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

        [Authorize(Policy = "HiringManger")]
        [HttpGet]
        public IActionResult HighEmployees(string search, int page = 1, int pageSize = 4)
        {
            try
            {
                DisplayEmployee display = new DisplayEmployee();
                var userExp = dbcontext.Experices.GroupBy(c => c.Userid).Select(g =>
                    new
                    {
                        Id = g.Key,
                    }).ToList();
                var applicationUsersdata = dbcontext.applicationUser.ToList();
                var userRole = dbcontext.UserRoles.ToList();
                var Roles = roleManager.Roles.ToList();

                var employees = (from c in roleManager.Roles
                                    join cn in dbcontext.UserRoles on c.Id equals cn.RoleId
                                    join SkillSets in dbcontext.SkillSets on cn.UserId equals SkillSets.Userid
                                     join user in dbcontext.applicationUser on cn.UserId equals user.Id
                                     where c.Name != "Admin" && c.Name != "Hiring Manager"
                                    && (string.IsNullOrEmpty(search) 
                                    || SkillSets.Skill.Trim().ToLower().Contains(search.Trim().ToLower())
                                    || (!string.IsNullOrEmpty(user.Firstname) && user.Firstname.Trim().ToLower().Contains(search.Trim().ToLower()))
                                    || (!string.IsNullOrEmpty(user.LastName) && user.LastName.Trim().ToLower().Contains(search.Trim().ToLower())))
                                     select user).ToList().Distinct().ToList();

               // List<ApplicationUser> employees = new List<ApplicationUser>();

                //var employees = applicationUsersdata.Where(s => employeequery.Contains(s.Id));



                // Pagination
                int totalItems = employees.Count();
                employees = employees.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                var nostarQuery = from c in dbcontext.applicationUser
                                  join p in dbcontext.Experices
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
                ViewBag.TotalPages = (int)Math.Ceiling((double)totalItems / pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.Search = search;

                return View(display);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [Authorize(Policy = "HiringManger")]
        [HttpGet]
        public async Task<IActionResult> HighEmployeeDetails(string id)
        {
            HomeDetailsViewModel details = new HomeDetailsViewModel()
            {
                AppUser = _context.getUser(id)

            };

			ApplicationUser user = _context.getUser(_userManager.GetUserId(User));
            var access = await _employeeDetailPermissionService.CheckIfUserHasAccessAsync(id, user.Id);

            ViewBag.CheckRequest = await _employeeDetailPermissionService.CheckIfRequestExists(id, user.Id);


			if (!access)
			{
                details.AppUser.Email = "xxx@xxxx.xxx";
                details.AppUser.PhoneNumber = "xxx-xxxxxxx";
                details.AppUser.citizenship = "xxx-xxxxxxx";
                details.PhoneNumber = "xxx-xxxxxxx";
                details.citizenship = "xxx-xxxxxxx";
			}

			return View(details);
        }

        [Authorize(Policy = "HiringManger")]
        [HttpGet]
        public async Task<bool> EmailEmployee(string id)
        {

            ApplicationUser currentUser = _context.getUser(_userManager.GetUserId(User));

            if (!(await _paymentService.CheckIfUserIsSubscribed(new Guid(currentUser.Id))))
                return false;
            var toUser = _context.getUser(id);
            _context.SendHireingManagersEmail(_app.HiringManagersEmailTemplatePath, toUser, currentUser);
            return true;

        }

        [Authorize(Policy = "HiringManger")]
        [HttpGet]
        public IActionResult HighProfileSection()
        {
            //var id = _userManager.GetUserAsync(User);
            //var idid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ApplicationUser user = _context.getUser(_userManager.GetUserId(User));
            ProfileDetialViewModel det = new ProfileDetialViewModel()
            {
                AppUser = _context.getUser(_userManager.GetUserId(User)),
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
            var nostarQuery = from c in dbcontext.applicationUser
                              join p in dbcontext.Experices
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
        
        public async Task<IActionResult> Details(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            ApplicationUser currentUser = _context.getUser(_userManager.GetUserId(User));
            var check = await _employeeDetailPermissionService.CheckIfRequestExists(currentUser.Id, id);

            var viewModel = new EmpProfileDetialViewModel
            {
                Id = user.Id,
                FirstName = user.Firstname,
                LastName = user.LastName,
                PhoneNumber = check ? user.PhoneNumber : "*********",
                PermanentAddress = check ? user.PermanentAddress : "*********",
                TemporaryAddress = check ? user.TemporaryAddress: "*********",
                Sex = check ? user.Sex: "*********",
                InactiveUsers =  user.InactiveUsers,
                Availabilility = user.Availablility,
                Descripition = check ? user.Descripition: "*********",
                citizenship = check ? user.citizenship: "*********",
                country = check ? user.country: "*********",
                city = check ? user.city: "*********",
                streetname = check ? user.streetname: "*********",
                states = check ? user.states: "*********",
                dob = check ? user.dob.ToString("dd/MM/yyyy"): "*********",
                bloodgroup = check ? user.bloodgroup: "*********",
                // Assuming the image is stored as a base64 string
                photo = check ? user.img : "*********"// You will need to handle the photo separately
            };

            return View(viewModel);
        }
        /// <summary>
        /// submitting the form after editing the details of the users
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Authorize(Policy = "HiringManger")]
        [HttpPost]
        public async Task<IActionResult> HighEdit(ProfileDetialViewModel model)
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
                update.InactiveUsers = model.InactiveUsers;
                update.Availablility = model.Availabilility;
                update.states = model.states;
                update.city = model.city;
                update.country = model.country;
                update.citizenship = model.citizenship;
                update.dob = model.dob;
                update.streetname = model.streetname;
                update.bloodgroup = model.bloodgroup;
                _context.update(update);
                return RedirectToAction("HighProfileSection", "High");
            }
            return View(model);
        }
        
        [Authorize(Policy = "HiringManger")]
        [HttpGet]
        public IActionResult SearchAction(string searchKey = "")
        {
            List<UserSkills> userSkills = dbcontext.SkillSets.ToList();
            var query = (from m in userSkills
                         join k in dbcontext.applicationUser on m.Userid equals k.Id
                         where m.Skill == searchKey
                         select new JoinViewModel
                         {
                             Id = k.Id,
                             Firstname = k.Firstname,
                             LastName = k.LastName,
                             PhoneNumber = k.PhoneNumber,
                             Email = k.Email,
                             UserName = k.UserName,
                             Sex = k.Sex,
                             Descripition = k.Descripition,
                             PermanentAddress = k.PermanentAddress,
                             TemporaryAddress = k.TemporaryAddress,
                             Skill = m.Skill,
                             skillDescription = m.Description
                         }).ToList();
            return View(query);

        }
    }
}
