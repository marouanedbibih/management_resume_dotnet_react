namespace backend.Core.Models
{
    public class Candidate : User
    {
        public string resume {  get; set; }

        public long user_id { get; set; }
        public User user { get; set; }

        public long job_id { get; set; }
        public Job job { get; set; }


    }
}
