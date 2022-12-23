using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class Client
    {
        [Column("idnum")]
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string Contacts { get; set; }
        public bool Status { get; set; }
        public string AppLicense { get; set; }

    }
}
