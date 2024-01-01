namespace backend.Core.Models
{
    public class Departement : BaseEntity
    {
        public string name { get; set; }
        public string? description { get; set; }
        public long company_id { get; set; }
        public Company company { get; set; }

        public long manager_id { get; set; }
        public Manager manager { get; set; }

        public ICollection<Job> jobs { get; set; }
    }
}
