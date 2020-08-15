using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;

namespace WorkerHub.Service
{
    public class MockIApplicationUser : IApplicationUser
    {
        public IEnumerable<ApplicationUser> getdata { get; set; }
        public ApplicationDbContext Context;

        //bringing the application db context to  the mockapplication to work with the db 
        public MockIApplicationUser(ApplicationDbContext _context)
        {
            Context = _context;
        }
        
                
        //for deleting the user from the table
        public ApplicationUser delete(int id)
        {
            ApplicationUser info = Context.applicationUser.Find(id);
            if (info != null)
            {
                var data = Context.applicationUser.First(e => e.InactiveUsers == false);
                data.InactiveUsers = true;
                Context.SaveChanges();
            }
            return info;
        }

        public IEnumerable<ApplicationUser> getRecords()
        {
            throw new NotImplementedException();
        }

        //getting user info
        public  ApplicationUser getUser(int id)
        {
            return Context.applicationUser.Find(id);
        }

        //for updating the info of the user
        public ApplicationUser update(ApplicationUser changes)
        {
            var details = Context.applicationUser.Attach(changes);
            details.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return changes;
        }

    }
}
