using System;

namespace WorkerHub.Service.Dto
{
	public class EmployeeDetailPermissionViewDto
	{
		public Guid Id { get; set; }
		public string HiringManagerId { get; set; }
		public string HiringManager { get; set; }
		public string Status { get; set; }
		public DateTime ExpiresIn { get; set; }
	}
	public class EmployeeDetailPermissionForManagerViewDto
	{
		public Guid Id { get; set; }
		public string EmployeeId { get; set; }
		public string Employee { get; set; }
		public string Status { get; set; }
        public DateTime ExpiresIn { get; set; }
    }
}
