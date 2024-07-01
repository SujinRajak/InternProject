using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorkerHub.Service.Dto;

namespace WorkerHub.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        /// <summary>
        /// Dbset is for the table 
        /// and the workuser is the class which cointains the attributes of the table with properties 
        /// </summary>
        public DbSet<ApplicationUser> applicationUser { get; set; }
        public DbSet<UserAcademic>  Academics { get; set; }
        public DbSet<UserSkills> SkillSets { get; set; }
        public DbSet<UserExperience> Experices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AmountBreakdown> AmountBreakdowns { get; set; }
        public DbSet<UseSubscriptionStatus> UseSubscriptionStatuses { get; set; }
        public DbSet<EmployeeDetailPermission> EmployeeDetailPermissions { get; set; }
        public DbSet<vw_EmployeeInfo> vw_EmployeeInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<WorkerHub.Service.Dto.EmployeeDetailPermissionForManagerViewDto> EmployeeDetailPermissionForManagerViewDto { get; set; }
    }
}
