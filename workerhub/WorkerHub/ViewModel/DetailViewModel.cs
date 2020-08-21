using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Models;

namespace WorkerHub.ViewModel
{
    public class DetailViewModel
    {
        public IEnumerable<ApplicationUser> users;
        public IEnumerable<UserAcademic> userAcad { get; }

        public IEnumerable<UserSkills> UserSkills { get; }

        public IEnumerable<UserExperience> userExperiences { get; }
    }
}
