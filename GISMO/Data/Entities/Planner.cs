using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class Planner
    {
        [Column("idnum")]
        public int Id { get; set; }
        public int VesselId { get; set; }
        public string CrewOnboard { get; set; }
        public string CrewReplacer { get; set; }
        public string OldPosition { get; set; }
        public string NewPosition { get; set; }
        public DateTime CChange { get; set; }
        public string ReplacerStat { get; set; }
        public string Port { get; set; }
    }
}
