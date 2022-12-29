using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class AnaClientEmbarked
    {
        [Column("idnum")]
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int TotEmbarked { get; set; }
        public int ClientId { get; set; }
    }
}
