using System.Threading.Tasks;
using System;

namespace WorkerHub.Interface
{
	public interface IPaymentService
	{
		Task CompletePaymentProcessAsync(int duration, string userId);
		Task<bool> CheckIfUserIsSubscribed(Guid userId);
		Task<DateTime> UserIsSubscribedEndDate(Guid userId);

    }
}
