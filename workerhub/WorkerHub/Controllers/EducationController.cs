using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    public class EducationController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        private readonly ApplicationDbContext _context;
        private readonly IEducation _eduContext;

        public EducationController (UserManager<ApplicationUser> userManager, ApplicationDbContext context, IEducation eduContext)
        {
            _userManager = userManager;
            _context = context;
            _eduContext = eduContext;
        }



        // GET: ExperiencesController/Create
        public ActionResult Create()
        {
            ValidateEducation model = new ValidateEducation()
            {
                Startdate = DateTime.Now,
                Enddate=DateTime.Now
            
            };
            return View(model);
        }

        // POST: ExperiencesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ValidateEducation model)
        {

            if (ModelState.IsValid)
            {
                var user = new UserAcademic
                {
                    Userid = _userManager.GetUserId(User),
                    Qualification = model.Qualification,
                    Startdate = model.Startdate,
                    Enddate = model.Enddate,
                    Graduated=model.Graduated,
                    Addressname=model.Addressname,
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
            UserAcademic user = _eduContext.getqal(id);
            //populating the editviewmodel field and using it to send it to the edit.cshtml
            EditViewModelEdu editViewModelEdu = new EditViewModelEdu()
            {
                id = user.Id,
                Qualification= user.Qualification,
                Startdate = user.Startdate,
                Enddate = user.Enddate,
                Graduated = user.Graduated,
                Addressname = user.Addressname,
                Description = user.Description
            };
            return View(editViewModelEdu);
        }

        // POST: ExperiencesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ValidateEducation collection)
        {
            if (ModelState.IsValid)
            {
                UserAcademic  user = _eduContext.getqal(id);
                user.Qualification= collection.Qualification;
                user.Startdate = collection.Startdate;
                user.Enddate = collection.Enddate;
                user.Graduated = collection.Graduated;
                user.Addressname = collection.Addressname;
                user.Description = collection.Description;

                _eduContext.update(user);
                return RedirectToAction("ExpCreate", "Resume");
            }
            return View(collection);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            UserAcademic del = _context.Academics.Find(id);
            if (del != null)
            {
                _context.Academics.Remove(del);
                _context.SaveChanges();
            }

            return RedirectToAction("ExpCreate", "Resume");
        }
    }
}
