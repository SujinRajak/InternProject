using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkerHub.Models
{
    public class UserSkills
    {
        [Key]
        [Column(TypeName = "int")]
        public int SkillId { get; set; }

        //this will basically addd userid as the foreign key reference with the identity user
        public string Userid { get; set; }
        [ForeignKey("Userid")]
        public IdentityUser IdentityUser { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Skill { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }
    }
}
