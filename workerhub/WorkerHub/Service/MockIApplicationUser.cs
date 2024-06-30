using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using WorkerHub.Interface;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Service
{
    public class MockIApplicationUser : IApplicationUser
    {
        public IEnumerable<ApplicationUser> getdata { get; set; }
        private readonly IEmailSender _emailService;

        public ApplicationDbContext Context;

        //bringing the application db context to  the mockapplication to work with the db 
        public MockIApplicationUser(ApplicationDbContext _context,IEmailSender emailSender)
        {
            Context = _context;
            _emailService = emailSender;
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

        public void SendEmail(EmailConfirmationModel emailConfirmationModel, string emailTemplatePath)
        {
            try
            {
                string EmailBodyCommon = string.Empty;
                //var updateStatusUrl = $"{game.BaseURL}p/{token}";
                var path = Path.Combine(Directory.GetCurrentDirectory(), emailTemplatePath);
                var emailConfirmationLink = emailConfirmationModel.EmailConfirmationLink;
                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        EmailBodyCommon = reader.ReadToEnd();
                    }
                    EmailBodyCommon = EmailBodyCommon.Replace("{UserName}", emailConfirmationModel.UserName);
                    EmailBodyCommon = EmailBodyCommon.Replace("{EmailConfirmationLink}", emailConfirmationLink);
                    EmailBodyCommon = EmailBodyCommon.Replace("{Password}", emailConfirmationModel.Password);
                }
                string subject = "Email Confirmation";
                _emailService.SendEmail(emailConfirmationModel.UserName ?? "", subject, EmailBodyCommon);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SendHireingManagersEmail(string emailTemplatePath, ApplicationUser toUser, ApplicationUser currentUser)
        {
            try
            {
                string EmailBodyCommon = string.Empty;
                //var updateStatusUrl = $"{game.BaseURL}p/{token}";
                var path = Path.Combine(Directory.GetCurrentDirectory(), emailTemplatePath);
                
                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        EmailBodyCommon = reader.ReadToEnd();
                    }
                    EmailBodyCommon = EmailBodyCommon.Replace("{User}", toUser.Firstname);
                    EmailBodyCommon = EmailBodyCommon.Replace("{{Company}","");
                    EmailBodyCommon = EmailBodyCommon.Replace("{Email}", currentUser.UserName);
                    EmailBodyCommon = EmailBodyCommon.Replace("{PhoneNumber}", currentUser.PhoneNumber);
                    
                }
                string subject = "Recruitment for Skilled Candidate";
                _emailService.SendEmail(toUser.UserName ?? "", subject, EmailBodyCommon);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
