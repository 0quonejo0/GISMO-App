using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class Analytics
    {
        [Column("idnum")]
        public int Id { get; set; }
        public int TotalCrew { get; set; }
        public int TotalVessels { get; set; }
        public int TotalClients { get; set; }
    }
}
