using System.Collections.Generic;
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
