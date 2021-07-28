using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerHub.ViewModel
{
    public class AdminProfileModel
    {

        public IEnumerable<IdentityRole> identityRoles { get; set; }

        public List<string> Users { get; set; }
    }
}
