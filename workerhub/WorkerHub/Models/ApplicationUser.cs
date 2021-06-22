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

        [PersonalData]
        [Column(TypeName = "bit")]
        public bool Availablility { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(max)")]
        public string img { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime dob { get; set; }
        
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string citizenship { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string country { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string city { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string streetname { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string states { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public string bloodgroup { get; set; }
    }
}
