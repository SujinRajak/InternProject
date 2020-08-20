using System.Collections.Generic;
using WorkerHub.Models;

namespace WorkerHub.Interface
{
    public interface IEducation
    {

        UserAcademic getqal(int id);
        public IEnumerable<UserAcademic> getrecords();

        UserAcademic update(UserAcademic changes);
    }
}
