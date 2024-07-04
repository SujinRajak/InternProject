using System;
using System.ComponentModel.DataAnnotations;

namespace WorkerHub.Models
{
	public class UseSubscriptionStatus
	{
		[Key]
		public string Id { get; set; }
		public string ApplicationUserId { get; set; }
		public DateTime EndDate { get; set; }
		public bool IsConsumed { get; set; }
	}
}
