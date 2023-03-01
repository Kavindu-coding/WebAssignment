namespace web_assignment.Models
{
    public class Payment
    {
       
        public int PaymentId { get; set; }
        public int amount { get; set; }
        public DateOnly pay_date { get; set; }
        public string pay_cus_ID { get; set; }
    }
}
