using System.ComponentModel.DataAnnotations;
using System;

namespace WorkerHub.Models
{
	public class EmployeeDetailPermission
	{
		[Key]
		public Guid Id { get; set; }
		public string HiringManagerId { get; set; }
		public virtual ApplicationUser HiringManager { get; set; }
		public string EmployeeId { get; set; }
		public virtual ApplicationUser Employee { get; set; }
		public string Status { get; set; }
		public DateTime ExpiresIn { get; set; }
	}
}
