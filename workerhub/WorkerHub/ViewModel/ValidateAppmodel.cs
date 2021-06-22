using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace WorkerHub.ViewModel
{
    public class ValidateAppmodel
    {

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

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime dob { get; set; }

        public string bloodgroup { get; set; }
    }
}
