using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

        //getting user info
        public ApplicationUser getUser(string id)
        {
            return Context.applicationUser.Find(id);
        }

       //counts the total no of entires in the application
        public int count()
        {
            return Context.applicationUser.Count();
        }

        public IEnumerable<ApplicationUser> getRecords()
        {
            return Context.applicationUser;
        }

        //for updating the info of the user
        public ApplicationUser update(ApplicationUser changes)
        {
            var details = Context.applicationUser.Attach(changes);
            details.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return changes;
        }

        //public ApplicationUser Update(BasicInfoViewModel model, string id)
        //{


        //    //   var user = new ApplicationUser { Firstname = model.Firstname, LastName = model.lastname, 
        //    //                                     PhoneNumber = model.phonenumber,TemporaryAddress=model.temporaryadd};
        //    //    var skill = new UserSkills { Skill = model.jobtitle, Description = model.specialism };

        //}





        ////for deleting the user from the table
        //public ApplicationUser delete(string id)
        //{
        //    ApplicationUser info = Context.applicationUser.Find(id);
        //    if (info != null)
        //    {
        //        var data = Context.applicationUser.First(e => e.InactiveUsers == false);
        //        data.InactiveUsers = true;
        //        Context.SaveChanges();
        //    }
        //    return info;
        //}
    }
}
