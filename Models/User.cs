namespace MovieRental.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string user_name { get; set; }
        public string user_email { get; set; }
        public string password { get; set; }
        public string rent_period { get; set; }
        public int payment_ID { get; set; }

    }
}
