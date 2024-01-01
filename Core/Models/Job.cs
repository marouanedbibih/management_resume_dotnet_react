using backend.Core.Enums;

namespace backend.Core.Models
{
    public class Job : BaseEntity
    {
        public string name {  get; set; }
        public string? description { get; set; }
        public JobLevel level { get; set; }

        // Relation between company and job
        public long departement_id { get; set; }
        public Departement departement { get; set; }

        public ICollection<Candidate> candidates { get; set; }
        public ICollection<Employe> employes { get; set; }

    }
}
