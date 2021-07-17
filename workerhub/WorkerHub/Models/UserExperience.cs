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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //this will basically addd userid as the foreign key reference with the identity user
        [ForeignKey("ApplicationUser")]
        public string Userid { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Sector { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Position { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Column(TypeName = "DateTime")]
        public DateTime Startdate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Column(TypeName = "DateTime")]
        public DateTime Enddate { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }



    }
}
