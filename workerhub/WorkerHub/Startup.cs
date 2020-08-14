using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkerHub.Models;

namespace WorkerHub
{
    public class Startup
    {
        private readonly IConfiguration Configuration;


        //this is the configuaration setting which helps to congigure the default files in the system
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //setting up application database using DI
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            //addidentity adds cookie based authentication
            //adds scoped classes for things like usermanager,signinmanager,pasword hashes and moree
            //adds the validated user from cookie to the httpcontext.user
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
             {
                 options.SignIn.RequireConfirmedAccount = false;
                 options.Password.RequireLowercase = false;
                 options.Password.RequireUppercase = false;
                 options.Password.RequireDigit = false;
             })
            .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            //services.AddScoped<in,service> ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //for authentication with the user
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
