using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WorkerHub.Models;

namespace WorkerHub.ViewModel
{
    public class ProfileDetialViewModel
    {

        /// <summary>
        /// for application user 
        /// </summary>
        public ApplicationUser AppUser { get; set; }
        public IEnumerable<ApplicationUser> appUser { get; set; }
        /// <summary>
        /// for user experience 
        /// </summary>
        public UserExperience AppExp { get; set; }

        public UserAcademic AppEdu { get; set; }

        public UserSkills AppSkill { get; set; }
        public IEnumerable<UserSkills> skills { get; set; }

        public ValidateExperience validexp { get; set; }

        //to sdisplay all the values in the table
        public IEnumerable<UserExperience> AppExpa { get; set; }
    }
}
