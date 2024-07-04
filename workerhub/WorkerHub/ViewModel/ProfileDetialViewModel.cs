using Microsoft.AspNetCore.Http;
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
        public List<ApplicationUser> applicationUsers { get; set; }
        public List<ValidateExperience> applicationUsersvalid { get; set; }


        public IFormFile photo { get; set; }
        public TotalExp TotalExpdata { get; set; } = new TotalExp();

        public string Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must provide a Contact number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "You must provide a Permanent Address")]
        public string PermanentAddress { get; set; }

        public string TemporaryAddress { get; set; }

        public string Sex { get; set; }

        public bool InactiveUsers { get; set; }
        public bool Availabilility { get; set; }
        public string Descripition { get; set; }
        public string citizenship { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string streetname { get; set; }
        public string states { get; set; }
        public DateTime dob { get; set; }

        public string bloodgroup { get; set; }

        public string IsSubed { get; set; }
    }
    public class EmpProfileDetialViewModel
    {
        public string photo { get; set; }

        public string Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must provide a Contact number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "You must provide a Permanent Address")]
        public string PermanentAddress { get; set; }

        public string TemporaryAddress { get; set; }

        public string Sex { get; set; }

        public bool InactiveUsers { get; set; }
        public bool Availabilility { get; set; }
        public string Descripition { get; set; }
        public string citizenship { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string streetname { get; set; }
        public string states { get; set; }
        public string dob { get; set; }

        public string bloodgroup { get; set; }
    }

}
