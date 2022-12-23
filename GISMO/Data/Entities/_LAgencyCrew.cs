using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class _LAgencyCrew
    {
        [Column("idnum")]
        public int Id { get; set; }
        public string Lname { get; set; }
        public string Rank { get; set; }
    }
}
