using System.Threading.Tasks;
using System;

namespace WorkerHub.Interface
{
	public interface IPaymentService
	{
		Task CompletePaymentProcessAsync(int duration, Guid userId);
		Task<bool> CheckIfUserIsSubscribed(Guid userId);
	}
}
