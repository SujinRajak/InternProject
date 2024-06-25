using System.Collections.Generic;
using WorkerHub.Models;
using WorkerHub.ViewModel;

namespace WorkerHub.Interface
{
    public interface IApplicationUser
    {
        ApplicationUser getUser(string id);
        IEnumerable<ApplicationUser> getRecords();

        int count();

        ApplicationUser update(ApplicationUser changes);

        //ApplicationUser Update(BasicInfoViewModel model);

        void SendEmail(EmailConfirmationModel emailConfirmationModel, string emailTemplatePath);


        //ApplicationUser delete(string id);

    }
}
