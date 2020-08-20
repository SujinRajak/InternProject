using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;

namespace WorkerHub.Service
{
    public class MockEducation : IEducation
    {
        private readonly ApplicationDbContext _dbcontext;

        public IEnumerable<UserExperience> getqual { get; set; }

        public MockEducation(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

       
        /// <summary>
        /// to get details of particular column
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserAcademic getqal(int id)
        {
            return _dbcontext.Academics.Find(id);
        }


        /// <summary>
        /// to get list of all user academics
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserAcademic> getrecords()
        {
            return _dbcontext.Academics;
        }

        
        /// <summary>
        /// for update
        /// </summary>
        /// <param name="changes"></param>
        /// <returns></returns>
        public UserAcademic update(UserAcademic changes)
        {
            var details = _dbcontext.Attach(changes);
            details.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbcontext.SaveChanges();
            return changes;
        }
    }
}
