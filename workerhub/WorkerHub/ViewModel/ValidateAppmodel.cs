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

       
        public string Descripition { get; set; }
    }
}
