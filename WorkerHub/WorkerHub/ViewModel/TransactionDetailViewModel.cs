using System.Collections.Generic;
using System;

namespace WorkerHub.ViewModel
{
    public class TransactionDetailViewModel
    {
        public string Tidx { get; set; }
        public string Status { get; set; }
        public string OrderId { get; set; }
        public string PurchaseOrderName { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserName { get; set; }
    }

    public class TransactionIndexViewModel
    {
        public IEnumerable<TransactionDetailViewModel> Transactions { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;
    }
}