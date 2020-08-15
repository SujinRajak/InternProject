using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkerHub.Models
{
    public class UserAcademic
    {

        [Key]
        [Column(TypeName = "int")]
        public int academicId { get; set; }

        //this will basically addd userid as the foreign key reference with the identity user
        public string Userid { get; set; }
        [ForeignKey("Userid")]
        public IdentityUser IdentityUser { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Qualification { get; set; }

     
        public DateTime? Startdate  { get; set; }

     
        public DateTime? Enddate { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }

    }
}
