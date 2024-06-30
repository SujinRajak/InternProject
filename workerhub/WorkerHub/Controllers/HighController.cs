using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    [Authorize(Policy = "HiringManger")]
    public class HighController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IApplicationUser _context;
        private ApplicationDbContext dbcontext;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IEmployeeDetailPermissionService _employeeDetailPermissionService;
		public HighController(UserManager<ApplicationUser> userManager,
			SignInManager<ApplicationUser> signInManager,
			IApplicationUser context, ApplicationDbContext _db, RoleManager<IdentityRole> roleManager,
            IEmployeeDetailPermissionService employeeDetailPermissionService)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_context = context;
			dbcontext = _db;
			this.roleManager = roleManager;
			_employeeDetailPermissionService = employeeDetailPermissionService;
		}

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

        [HttpGet]
        public IActionResult HighEmployees()
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

        [HttpGet]
        public async Task<IActionResult> HighEmployeeDetails(string id)
        {
            HomeDetailsViewModel details = new HomeDetailsViewModel()
            {
                AppUser = _context.getUser(id)

            };

			ApplicationUser user = _context.getUser(_userManager.GetUserId(User));
            var access = await _employeeDetailPermissionService.CheckIfUserHasAccessAsync(id, user.Id);

            if (!access)
			{
                details.PhoneNumber = "xxx-xxxxxxx";
                details.citizenship = "xxx-xxxxxxx";
			}

			return View(details);
        }

        [HttpGet]
        public IActionResult EmailEmployee(string id)
        {
            ApplicationUser user = _context.getUser(_userManager.GetUserId(User));
            var profuser = _context.getUser(id);
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("WorkersHub", "rajaksujin.sr@gmail.com"));
            message.To.Add(new MailboxAddress(profuser.Firstname, profuser.UserName));
            message.Subject = "Recruitment for Skilled Candidate";
            var bodyBuilder = new BodyBuilder();
            using (StreamReader SourceReader = System.IO.File.OpenText("D:/8th project/CurrentlWorkingproject/Final intern project/WorkerHub/WorkerHub/Views/High/Mailtemplate.html"))
            {
                bodyBuilder.HtmlBody = SourceReader.ReadToEnd();
            }
            bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("{User}", profuser.Firstname);
           // bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("{Company}",);
            bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("{Email}", user.UserName);
            bodyBuilder.HtmlBody = bodyBuilder.HtmlBody.Replace("{PhoneNumber}", user.PhoneNumber);
            message.Body = bodyBuilder.ToMessageBody();
            using (var client = new SmtpClient()){
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("rajaksujin.sr@gmail.com", "$Uj##N$p123");
                client.Send(message);
                client.Disconnect(true);
            }
            return RedirectToAction("HighEmployees", "High");
        }

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


        /// <summary>
        /// submitting the form after editing the details of the users
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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
