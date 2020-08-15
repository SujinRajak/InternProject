using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkerHub.Models
{
    public class ApplicationUser 
    {
        [Key]
        [Column(TypeName ="int")]
        public int id { get; set; }

        //this will basically addd userid as the foreign key reference with the identity user
        public string Userid { get; set; }
        [ForeignKey("Userid")]
        public IdentityUser IdentityUser { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string ProfilePicture { get; set; }


        [Column(TypeName = "nvarchar(255)")]
        public string CoverPicture { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Firstname { get; set; }

        
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; } 

        [Column(TypeName = "nvarchar(255)")]
        public string PermanentAddress { get; set; }

       
        [Column(TypeName = "nvarchar(255)")]
        public string TemporaryAddress { get; set; }

     
        [Column(TypeName = "nvarchar(10)")]
        public string Sex { get; set; }


        [Column(TypeName = "nvarchar(255)")]
        public string Citizenship { get; set; }

      
        [Column(TypeName = "nvarchar(255)")]
        public string CV { get; set; }


        [Required]
        [Column(TypeName = "bit")]
        public bool InactiveUsers { get; set; }

      
    }
}
