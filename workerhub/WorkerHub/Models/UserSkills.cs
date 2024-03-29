﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkerHub.Models
{
    public class UserSkills
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
        public string Skill { get; set; }

        [Column(TypeName = "int")]
        public int SkillPercent { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }


    }
}
