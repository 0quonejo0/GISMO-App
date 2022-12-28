using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class AnaClientVessels
    {
        [Column("idnum")]
        public int Id { get; set;}
        public string ClientName { get; set;}
        public int TotManagedVsl { get; set;}
    }
}
