using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Models;

namespace WorkerHub.ViewModel
{
    public class RoleassignModel
    {
        public List<IdentityRole> Roles { get; set; }
        public List<ApplicationUser> AppUser { get; set; }
        public List<IdentityUserRole<string>> UserRole { get; set; }
        
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UseRoleName { get; set; }
    }
}
