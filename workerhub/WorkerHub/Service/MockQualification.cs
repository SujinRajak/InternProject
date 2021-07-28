using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;

namespace WorkerHub.Service
{
    public class MockQualification : IQualification
    {
        private readonly ApplicationDbContext _dbcontext;

        public IEnumerable<UserExperience> getqual { get; set; }

        public MockQualification(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        //to duisplay all the records of the the table
        public IEnumerable<UserExperience> getrecords()
        {
            return _dbcontext.Experices;
        }

        //to display particualar record based on id
        public UserExperience getqal(int id)
        {
            return _dbcontext.Experices.Find(id);
        }

        public UserExperience update(UserExperience changes)
        {
            var details = _dbcontext.Experices.Attach(changes);
            details.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbcontext.SaveChanges();
            return changes;
        }

    }
}