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
        public string IMO { get; set; }
        public string YearBuilt { get; set; }
        public string Engine { get; set; }
        public string Builder { get; set; }
        public string Route { get; set; }
        public string Pix { get; set; }
    }
}
