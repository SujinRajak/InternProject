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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //this will basically addd userid as the foreign key reference with the identity user

        [ForeignKey("ApplicationUser")]
        public string Userid { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Qualification { get; set; }

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
