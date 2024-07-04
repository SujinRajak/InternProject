namespace WorkerHub.Service.Dto
{
    public class KhaltiInitiatePaymentResponseDto
    {
        public string pidx { get; set; }
        public string payment_url { get; set; }
        public string expires_at { get; set; }
        public int expires_in { get; set; }
    }
}
    public class KhaltiVerifyPaymentResponseDto
    {
        public string pidx { get; set; }
        public string total_amount { get; set; }
        public string status { get; set; }
        public int transaction_id { get; set; }
        public int fee { get; set; }
        public int refunded { get; set; }
    }
}
