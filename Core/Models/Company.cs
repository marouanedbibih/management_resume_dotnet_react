using backend.Core.Enums;

namespace backend.Core.Models
{
    public class Company : BaseEntity 
    {
        public string name { get; set; }
        public string? description { get; set; } 
        public CompanySize size { get; set; }
        public ICollection<Departement> departements { get; set; }

        public Ceo ceo { get; set; }
    }
}
