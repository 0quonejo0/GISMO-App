using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace GISMO.Data.Entities
{
    public class SeaService
    {
        [Column("idnum")]
        public int Id { get; set; } 
        public int CrewId { get; set; }
        public string Vessel { get; set; }
        public string Rank { get; set; }
        public DateTime SignOn { get; set;}
        public DateTime SignOff { get; set; }
        public string Disembarkation { get; set; }
        public string GRT { get; set; }
        public string Type { get; set; }
        public string TradeRoute { get; set; }
        public string Engine { get; set; }
        public string KW { get; set; }
        public string Agent { get; set; }
        public string Principal { get; set; }
    }
}
