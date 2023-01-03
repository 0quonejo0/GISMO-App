using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class Event
    {
        [Column("idnum")]
        public int Id { get; set; }
        public DateTime ReportDate { get; set; }
        public string Report { get; set; }
        public string EventOB { get; set; }
        public string Image { get; set; }
        public int VesselId { get; set; }
        public string Thumbnails { get; set; }
    }
}
