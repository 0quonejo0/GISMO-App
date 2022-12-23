using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class ClientVessels
    {
        [Column("idnum")]
        public int Id { get; set; }
        public string VesselName { get; set; }
        public int ClientId { get; set; }
    }
}
