using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace GISMO.Data.Entities
{
    public class Circular
    {
        [Column("idnum")]
        public int Id { get; set; }
        public string MemoNo { get; set; }
        public string MemoName { get; set; }
        public string YearIssued { get; set; }
        public int VesselId { get; set; }
    }
}
