using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkerHub.Models
{
    public class ApplicationUser : IdentityUser
    {
     
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Firstname { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(255)")]
        public string PermanentAddress { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(255)")]
        public string TemporaryAddress { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(10)")]
        public string Sex { get; set; }

        [PersonalData]
        [Required]
        [Column(TypeName = "bit")]
        public bool InactiveUsers { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(255)")]
        public string Descripition { get; set; }
    }
}
