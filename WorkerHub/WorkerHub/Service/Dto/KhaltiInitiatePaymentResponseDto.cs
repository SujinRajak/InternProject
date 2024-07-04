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
