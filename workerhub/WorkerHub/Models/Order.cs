using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace WorkerHub.Models
{
	public class Order
	{
		[Key]
		public string Id { get; set; }
		public string PxId { get; set; }
		public string PurchaseOrderName { get; set; }
		public string ApplicationUserId { get; set; }
		public int Amount { get; set; }
		public string ReturnUrl { get; set; }
		public string WebsiteUrl { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
	}
}
