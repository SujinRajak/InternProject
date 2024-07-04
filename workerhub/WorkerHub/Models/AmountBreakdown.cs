using System;
using System.ComponentModel.DataAnnotations;

namespace WorkerHub.Models
{
	public class AmountBreakdown
	{
		[Key]
		public Guid Id { get; set; }
		public int OrderID { get; set; }
		public string Label { get; set; }
		public int Amount { get; set; }
	}
}
