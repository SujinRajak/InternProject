using System.ComponentModel.DataAnnotations;



/// <summary>
/// this viewmodel is added so that we can take the  data from the from to the controller and the validations are done in the model itself
/// </summary>

namespace WorkerHub.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }
}
