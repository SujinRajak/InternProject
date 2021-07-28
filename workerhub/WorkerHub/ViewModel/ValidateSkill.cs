using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerHub.ViewModel
{
    public class ValidateSkill 
    {

        public int Id { get; set; }

        [Required]
        public string Skill { get; set; }

        public int SkillPercent { get; set; }
        [Required]
        public string skillDescription { get; set; }
    }
}
