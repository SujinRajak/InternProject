﻿using System;
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


      

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }



    }
}
