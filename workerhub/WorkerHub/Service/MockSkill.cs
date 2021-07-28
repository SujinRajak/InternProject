using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;

namespace WorkerHub.Service
{
    public class MockSkill : ISkill
    {

        private readonly ApplicationDbContext _dbcontext;

        public IEnumerable<UserSkills> getqual { get; set; }

        public MockSkill(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }


        /// <summary>
        /// to get details of particular column
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserSkills getqal(int id)
        {
            return _dbcontext.SkillSets.Find(id);
        }


        /// <summary>
        /// to get list of all user academics
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserSkills> getrecords()
        {
            return _dbcontext.SkillSets;
        }


        /// <summary>
        /// for update
        /// </summary>
        /// <param name="changes"></param>
        /// <returns></returns>
        public UserSkills update(UserSkills changes)
        {
            var details = _dbcontext.Attach(changes);
            details.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbcontext.SaveChanges();
            return changes;
        }
    }
}

