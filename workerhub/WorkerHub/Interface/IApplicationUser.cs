using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using WorkerHub.Models;

namespace WorkerHub.Interface
{
    public interface IApplicationUser
    {
        ApplicationUser getUser(int id);
        IEnumerable<ApplicationUser> getRecords();

        ApplicationUser update(ApplicationUser changes);

        ApplicationUser delete(int id);

        


    }
}
