using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Models;

namespace WorkerHub.Interface
{
    public interface ISkill
    {
        UserSkills getqal(int id);
        public IEnumerable<UserSkills> getrecords();
        UserSkills update(UserSkills changes);
    }
}
