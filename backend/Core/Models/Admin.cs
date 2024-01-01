namespace backend.Core.Models
{
    public class Admin : User
    {
        public long user_id { get; set; }
        public User user { get; set; }
    }
}
