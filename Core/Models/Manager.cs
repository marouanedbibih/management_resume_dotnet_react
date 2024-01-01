namespace backend.Core.Models
{
    public class Manager : Employe
    {
        public long employe_id {  get; set; }
        public Employe employe { get; set; }

    }
}
