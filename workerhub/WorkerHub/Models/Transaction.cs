using System;
using System.ComponentModel.DataAnnotations;

namespace WorkerHub.Models
{
	public class Transaction
	{
		[Key]
		public string Id { get; set; }
		public string tidx { get; set; }
		public string transaction_id { get; set; }
		public string OrderId { get; set; }
		public string Status { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
	}
}
