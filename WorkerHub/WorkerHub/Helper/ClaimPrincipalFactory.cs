using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WorkerHub.Models;

namespace WorkerHub.Helper
{

    public class ClaimPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
    {
        ApplicationDbContext _db;

        public ClaimPrincipalFactory(
        UserManager<ApplicationUser> userManager,
        //RoleManager<ApplicationUser> roleManager,
        IOptions<IdentityOptions> optionsAccessor, ApplicationDbContext db) : base(userManager, optionsAccessor)
        {
            _db = db;
        }

        public async override Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
        {
            var principal = await base.CreateAsync(user);

            var appUser = _db.vw_EmployeeInfo.FirstOrDefault(c => c.Id == user.Id) ?? new vw_EmployeeInfo();

            ((ClaimsIdentity)principal.Identity).AddClaims(new[] {

                new Claim("EmployeeName",appUser.Name?? ""),
                new Claim("UserId", appUser.Id ?? ""),
                new Claim("Role", appUser.Role?? ""),
            });

            return principal;
        }

    }

}
