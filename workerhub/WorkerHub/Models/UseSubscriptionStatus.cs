using System;
using System.ComponentModel.DataAnnotations;

namespace WorkerHub.Models
{
	public class UseSubscriptionStatus
	{
		[Key]
		public Guid Id { get; set; }
		public Guid ApplicationUserId { get; set; }
		public virtual ApplicationUser ApplicationUser { get; set; }
		public DateTime EndDate { get; set; }
		public bool IsConsumed { get; set; }
	}
}
