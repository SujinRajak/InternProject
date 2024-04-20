using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Models;

namespace WorkerHub.ViewModel
{
    public class DisplayEmployee
    {
        public List<ApplicationUser> applicationUsers { get; set; } = new List<ApplicationUser>();
        public List<UserExperience> userExperiences { get; set; }
        //public List<IdentityUserRole<string>> UserRole { get; set; }
        //public List<IdentityRole> Roles { get; set; }
        public List<TotalExp> TotalExpdata { get; set; } = new List<TotalExp>();

    }



    public class TotalExp
    {
        public string userid;
        public int totalExp;
    }
}
