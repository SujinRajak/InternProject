using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Controllers
{
    public class SkillController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly ApplicationDbContext _context;
        private readonly ISkill _SkiContext;

        public SkillController(UserManager<ApplicationUser> userManager, ApplicationDbContext context, ISkill SkiContext)
        {
            _userManager = userManager;
            _context = context;
            _SkiContext = SkiContext;
        }



        // GET: ExperiencesController/Create
        public ActionResult Create()
        {
            ValidateSkill model = new ValidateSkill();
            return View(model);
        }

        // POST: ExperiencesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ValidateSkill model)
        {

            if (ModelState.IsValid)
            {
                var user = new UserSkills
                {
                    Userid = _userManager.GetUserId(User),
                    Skill = model.Skill,
                    SkillPercent=(model.SkillPercent==0)?50:model.SkillPercent,
                    Description = model.skillDescription
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
            UserSkills user = _SkiContext.getqal(id);
            //populating the editviewmodel field and using it to send it to the edit.cshtml
            EditViewSkills editViewModelEdu = new EditViewSkills()
            {
                Id = user.Id,
                Skill= user.Skill,
                SkillPercent = (user.SkillPercent == 0) ? 50 : user.SkillPercent,
                skillDescription = user.Description
            };
            return View(editViewModelEdu);
        }

        // POST: ExperiencesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ValidateSkill collection)
        {
            if (ModelState.IsValid)
            {
                UserSkills user = _SkiContext.getqal(id);
                user.Skill = collection.Skill;
                user.SkillPercent = collection.SkillPercent;
                user.Description = collection.skillDescription;

                _SkiContext.update(user);
                return RedirectToAction("ExpCreate", "Resume");
            }
            return View(collection);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            UserSkills del = _context.SkillSets.Find(id);
            if (del != null)
            {
                _context.SkillSets.Remove(del);
                _context.SaveChanges();
            }

            return RedirectToAction("ExpCreate", "Resume");
        }
    }
}
