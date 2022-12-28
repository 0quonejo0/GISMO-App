using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class VslExperience
    {
        [Column("idnum")]
        public int Id { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Type { get; set; }
    }
}
