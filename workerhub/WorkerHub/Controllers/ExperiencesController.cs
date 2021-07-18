using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    public class ExperiencesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly ApplicationDbContext _context;
        private readonly IQualification _qualContext;

        public ExperiencesController(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IQualification qualContext)
        {
            _userManager = userManager;
            _context = context;
            _qualContext = qualContext;
        }

        public static int starCalcu(int expCalculator)
        {
            if (expCalculator <= 3)
            {
                return 1;
            }
            else if (expCalculator >= 3 && expCalculator <= 6)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        // GET: ExperiencesController/Create
        public ActionResult Create()
        {
            ValidateExperience model = new ValidateExperience()
            {
                Startdate = DateTime.Now,
                Enddate = DateTime.Now
            };
            return View(model);
        }

        // POST: ExperiencesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ValidateExperience model)
        {

            if (ModelState.IsValid)
            {
                var expCalculator =model.Enddate.Year - model.Startdate.Year;
                
                var user = new UserExperience
                {
                    Userid = _userManager.GetUserId(User),
                    Sector = model.Sector,
                    Position = model.Position,
                    Startdate = model.Startdate,
                    Enddate = model.Enddate,
                    WorkPlace=model.WorkPlace,
                    Addressname=model.Addressname,
                    yearsExp=expCalculator,
                    Description = model.Description

                };
                
                _context.Add(user);
                _context.SaveChanges();
                return RedirectToAction("ExpCreate", "Resume");
            }
            return View(model);
        }

        // GET: ExperiencesController/Edit/5
        public ActionResult Edit(int id)
        {
            //we need to alter the user experience table so populating he user with the data of the userexperince 
            UserExperience user = _qualContext.getqal(id);
            var expCalculator = user.Enddate.Year - user.Startdate.Year;
                //populating the editviewmodel field and using it to send it to the edit.cshtml
            EditViewModelExp editViewModelExp = new EditViewModelExp()
            {
                id = user.Id,
                Sector = user.Sector,
                Position = user.Position,
                Startdate = user.Startdate,
                Enddate = user.Enddate,
                WorkPlace = user.WorkPlace,
                YearsOfExp=expCalculator,
                Addressname = user.Addressname,
                Description = user.Description

            };
            return View(editViewModelExp);
        }

        // POST: ExperiencesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ValidateExperience collection)
        {
            var expCalculator =collection.Enddate.Year - collection.Startdate.Year;
            if (ModelState.IsValid)
            {
                UserExperience user = _qualContext.getqal(id);
                user.Sector = collection.Sector;
                user.Position = collection.Position;
                user.Startdate = collection.Startdate;
                user.Enddate = collection.Enddate;
                user.WorkPlace = collection.WorkPlace;
                user.yearsExp = expCalculator;
                user.Addressname = collection.Addressname;
                user.Description = collection.Description;

                _qualContext.update(user);
                return RedirectToAction("ExpCreate", "Resume");
            }
            return View(collection);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            UserExperience del = _context.Experices.Find(id);
            if(del != null)
            {
                _context.Experices.Remove(del);
                _context.SaveChanges();
            }
            
            return RedirectToAction("ExpCreate","Resume");
        }
    }
}
