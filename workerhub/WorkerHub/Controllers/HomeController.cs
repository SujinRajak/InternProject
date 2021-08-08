﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
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
        private readonly RoleManager<IdentityRole> roleManager;
        public HomeController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IApplicationUser context, ApplicationDbContext _db, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            dbcontext = _db;
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index(string SearchTerm)
        {
            try
            {
                var query = dbcontext.Experices
            .GroupBy(c => c.Userid)
            .Select(g =>
                new
                {
                    Id = g.Key,
                    totalexp = g.Sum(s => s.yearsExp),
                }
            ).ToList();
                DisplayEmployee display = new DisplayEmployee()
                {
                    userExperiences = dbcontext.Experices.ToList()
                };
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
                            display.applicationUsers.Add(new ApplicationUser
                            {
                                Id = usersss.Id,
                                UserName = usersss.UserName,
                                NormalizedEmail = usersss.NormalizedEmail,
                                Email = usersss.Email,
                                PhoneNumber = usersss.PhoneNumber,
                                Firstname = usersss.Firstname,
                                LastName = usersss.LastName,
                                PermanentAddress = usersss.PermanentAddress,
                                TemporaryAddress = usersss.TemporaryAddress,
                                Sex = usersss.Sex,
                                InactiveUsers = usersss.InactiveUsers,
                                Descripition = usersss.Descripition,
                                Availablility = usersss.Availablility,
                                img = usersss.img,
                                dob = usersss.dob,
                                citizenship = usersss.citizenship,
                                city = usersss.city,
                                country = usersss.country,
                                streetname = usersss.streetname,
                                states = usersss.states,
                                bloodgroup = usersss.bloodgroup
                            });

                        }
                    }
                }
                foreach (var item in query)
                {
                    display.TotalExpdata.Add(new TotalExp
                    {
                        userid = item.Id,
                        totalExp = item.totalexp
                    });
                }
                return View(display);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            try
            {
                var query = dbcontext.Experices
            .GroupBy(c => c.Userid)
            .Select(g =>
                new
                {
                    Id = g.Key,
                    totalexp = g.Sum(s => s.yearsExp),
                }
            ).ToList();
                DisplayEmployee display = new DisplayEmployee()
                {
                    userExperiences = dbcontext.Experices.ToList()
                };
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
                            display.applicationUsers.Add(new ApplicationUser
                            {
                                Id = usersss.Id,
                                UserName = usersss.UserName,
                                NormalizedEmail = usersss.NormalizedEmail,
                                Email = usersss.Email,
                                PhoneNumber = usersss.PhoneNumber,
                                Firstname = usersss.Firstname,
                                LastName = usersss.LastName,
                                PermanentAddress = usersss.PermanentAddress,
                                TemporaryAddress = usersss.TemporaryAddress,
                                Sex = usersss.Sex,
                                InactiveUsers = usersss.InactiveUsers,
                                Descripition = usersss.Descripition,
                                Availablility = usersss.Availablility,
                                img = usersss.img,
                                dob = usersss.dob,
                                citizenship = usersss.citizenship,
                                city = usersss.city,
                                country = usersss.country,
                                streetname = usersss.streetname,
                                states = usersss.states,
                                bloodgroup = usersss.bloodgroup
                            });

                        }
                    }
                }
                foreach (var item in query)
                {
                    display.TotalExpdata.Add(new TotalExp
                    {
                        userid = item.Id,
                        totalExp = item.totalexp
                    });
                }
                return View(display);
            }
            catch (Exception ex)
            {
                throw ex;
            }

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
