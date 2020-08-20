using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Models;

namespace WorkerHub.Interface
{
   public interface IQualification
    {

       UserExperience getqal(int id);
       public IEnumerable<UserExperience> getrecords();

       UserExperience update(UserExperience changes);
    }
}
