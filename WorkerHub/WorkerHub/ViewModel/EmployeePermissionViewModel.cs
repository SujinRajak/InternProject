using System;

namespace WorkerHub.ViewModel
{
    public class EmployeePermissionViewModel
    {
        public Guid Id { get; set; }
        public string HiringManagerName { get; set; }
        public string HiringManagerId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeId { get; set; }
        public string Status { get; set; }
        public DateTime ExpiresIn { get; set; }
    }
}
