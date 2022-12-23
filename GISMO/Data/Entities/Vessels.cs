using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class Vessels
    {
        [Column("idnum")]
        public int Id { get; set; }
        public string VesselName { get; set; }
        public int ClientId { get; set; }
        public string Type { get; set; }
        public string Flag { get; set; }
        public string Grt { get; set; }
        //public Client Client { get; set; }
    }
}
