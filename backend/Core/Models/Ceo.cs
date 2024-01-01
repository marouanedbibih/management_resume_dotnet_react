namespace backend.Core.Models
{
    public class Ceo : User
    {
        public long user_id { get; set; }
        public User user { get; set; }

        public long company_id { get; set; }
        public Company company { get; set; }

    }
}
