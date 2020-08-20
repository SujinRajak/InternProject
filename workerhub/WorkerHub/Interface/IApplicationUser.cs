using System.Collections.Generic;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Interface
{
    public interface IApplicationUser
    {
         ApplicationUser getUser(string id);
        IEnumerable<ApplicationUser> getRecords();

        int count();

      

       //ApplicationUser Update(BasicInfoViewModel model);


        //ApplicationUser update(ApplicationUser changes);

        //ApplicationUser delete(string id);

    }
}
