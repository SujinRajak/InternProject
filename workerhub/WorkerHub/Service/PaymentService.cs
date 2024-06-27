using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;

namespace WorkerHub.Service
{
	public class PaymentService : IPaymentService
	{

		private readonly ApplicationDbContext _dbcontext;

		public PaymentService(ApplicationDbContext dbcontext)
		{
			_dbcontext = dbcontext;
		}

		public async Task CompletePaymentProcessAsync(int duration, Guid userId)
		{
			var userSubscription = await _dbcontext.UseSubscriptionStatuses.FirstOrDefaultAsync(s => s.ApplicationUserId.Equals(userId));
			if (userSubscription == null)
				_dbcontext.Add(new UseSubscriptionStatus
				{
					ApplicationUserId = userId,
					IsConsumed = false,
					EndDate = DateTime.UtcNow.AddMonths(duration)
				});
			else
			{
				if (userSubscription.EndDate < DateTime.Now)
					userSubscription.EndDate = DateTime.UtcNow.AddMonths(duration);
				else
					userSubscription.EndDate.AddMonths(duration);
			}

			await _dbcontext.SaveChangesAsync();
		}

		public async Task<bool> CheckIfUserIsSubscribed(Guid userId)
		{

			var userSubscription = await _dbcontext.UseSubscriptionStatuses.FirstOrDefaultAsync(s => s.ApplicationUserId.Equals(userId));
			if (userSubscription == null)
				return false;
			if (userSubscription.EndDate < DateTime.Now)
				return false;
			return true;
		}
	}
}
