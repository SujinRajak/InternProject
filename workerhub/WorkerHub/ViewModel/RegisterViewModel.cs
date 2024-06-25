using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


/// <summary>
/// this viewmodel is added so that we can take the  data from the from to the controller and the validations are done in the model itself
/// </summary>
namespace WorkerHub.ViewModel
{
    public class RegisterViewModel
    {
        

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public List<IdentityRole> Roles { get; set; }

        [Required]
        public string RoleName { get; set; }
    }
}
