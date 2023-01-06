using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class Applicant
    {
        [Column("idnum")]
        public int Id { get; set; }
        public int CrewId { get; set; }
        public string FullName { get; set; }
        public string Rank { get; set; }
        public string Client { get; set; }
        public string ToVessel { get; set; }
        public string UploadedDocs { get; set; }
        public string Status { get; set; }
        public string OwnerRemarks { get; set; }
    }
}
