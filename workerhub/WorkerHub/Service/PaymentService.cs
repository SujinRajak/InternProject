using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorkerHub.Interface;
using WorkerHub.Models;

namespace WorkerHub.Service
{
	public class PaymentService : IPaymentService
	{

		private readonly ApplicationDbContext _dbcontext;
		private readonly HttpClient httpClient;

		public PaymentService(ApplicationDbContext dbcontext)
		{
			_dbcontext = dbcontext;
		}

		public async Task CompletePaymentProcessAsync(int duration, string userId)
		{
			var userSubscription = await _dbcontext.UseSubscriptionStatus.FirstOrDefaultAsync(s => s.ApplicationUserId.Equals(userId));
			if (userSubscription == null)
				_dbcontext.Add(new UseSubscriptionStatus
				{
					Id = Guid.NewGuid().ToString(),
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
			try
			{
                var userSubscription = await _dbcontext.UseSubscriptionStatus.FirstOrDefaultAsync(s => s.ApplicationUserId == userId.ToString());
                if (userSubscription == null)
                    return false;
                if (userSubscription.EndDate < DateTime.Now)
                    return false;
            }
			catch(Exception ex)
			{

            }
            return true;
        }
		public async Task<DateTime> UserIsSubscribedEndDate(Guid userId)
		{

			var userSubscription = await _dbcontext.UseSubscriptionStatus.FirstOrDefaultAsync(s => s.ApplicationUserId.Equals(userId.ToString()));
			
			return userSubscription == null ? DateTime.UtcNow : userSubscription.EndDate;
		}


		public async Task<string> InitiatePaymentAsync(string amount, string productIdentity, string productName, string productUrl)
		{
			var url = "https://khalti.com/api/v2/payment/initiate/";
			var payload = new
			{
				return_url = "http://yourwebsite.com/khalti/verify",
				amount = amount,
				product_identity = productIdentity,
				product_name = productName,
				product_url = productUrl
			};

			var jsonPayload = JObject.FromObject(payload).ToString();
			var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

			httpClient.DefaultRequestHeaders.Add("Authorization", $"Key test_public_key_f4cf93dc85e040289b207532e339e709");

			var response = await httpClient.PostAsync(url, content);
			var responseContent = await response.Content.ReadAsStringAsync();

			return responseContent;
		}

		public async Task<JObject> VerifyPaymentAsync(string token, string amount)
		{
			var url = "https://khalti.com/api/v2/payment/verify/";
			var payload = new
			{
				token = token,
				amount = amount
			};

			var jsonPayload = JObject.FromObject(payload).ToString();
			var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

			httpClient.DefaultRequestHeaders.Add("Authorization", $"Key test_secret_key_e0e3b5804566422e85dc44d437b2b0ea");

			var response = await httpClient.PostAsync(url, content);
			var responseContent = await response.Content.ReadAsStringAsync();

			return JObject.Parse(responseContent);
		}
	}
}
