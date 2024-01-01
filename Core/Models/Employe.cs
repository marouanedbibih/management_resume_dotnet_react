namespace backend.Core.Models
{
    public class Employe :User
    {
        public float salaire {  get; set; } 
        public long user_id { get; set; }
        public User user { get; set; }

        public long job_id { get; set; }
        public Job job { get; set; }

        public Manager manager { get; set; }
    }
}
