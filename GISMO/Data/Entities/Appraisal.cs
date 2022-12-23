using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class Appraisal
    {
        [Column("idnum")]
        public int Id { get; set; }
        public string Master { get; set; }
        public string Ceng { get; set; }
        public int CrewId { get; set; }
        public string Remarks { get; set; }
        public string VesselName { get; set; }
    }
}
