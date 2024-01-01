using System.ComponentModel.DataAnnotations;

namespace backend.Core.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public long id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set;}
    }
}
