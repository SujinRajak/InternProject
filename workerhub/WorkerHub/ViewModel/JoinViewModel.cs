using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Models;

namespace WorkerHub.ViewModel
{
    public class JoinViewModel : ApplicationUser
    {
        public string Skill { get; set; }

        public string skillDescription { get; set; }
    }
}
