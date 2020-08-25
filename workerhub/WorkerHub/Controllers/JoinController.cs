using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    public class JoinController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public JoinController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult SearchAction(string searchKey = "")
        {
            List<UserSkills> userSkills = _context.SkillSets.ToList();
            var query = (from m in userSkills
                         join k in _context.applicationUser on m.Userid equals k.Id
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


        [HttpGet]
        public IActionResult showAll()
        {
            List<UserSkills> userSkills = _context.SkillSets.ToList();
            var query = (from m in userSkills
                         join k in _context.applicationUser on m.Userid equals k.Id
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
