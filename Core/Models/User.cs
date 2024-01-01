namespace backend.Core.Models
{
    public class User : BaseEntity
    {
        protected string name { set; get; }
        protected string email { set; get; }
        protected string phone { set; get; }
        protected string password { set; get; }
        protected string? image {  set; get; }
        protected string role { set; get; }

        public Candidate candidate { set; get; }
        public Admin admin { set; get; }
        public Employe employe { set; get; }
        public Ceo ceo { set; get; }
    }
}
