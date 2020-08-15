using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerHub.Models
{
    public class UserExperience
    {
        [Key]
        [Column(TypeName = "int")]
        public int ExpId { get; set; }

        //this will basically addd userid as the foreign key reference with the identity user
        public string Userid { get; set; }
        [ForeignKey("Userid")]
        public IdentityUser IdentityUser { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Sector { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Position { get; set; }

        public  DateTime? Startdate { get; set; }


        public DateTime? Enddate { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }



    }
}
