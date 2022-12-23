using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class Onboard
    {
        [Column("idnum")]
        public int Id { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Rank { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int VesselId { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string BPlace { get; set; }
        public string CivilStat { get; set; }
        public string Availability { get; set; }
        public string Nationality { get; set; }
        public string PportNum { get; set; }
        public string PportIssuance { get; set; }
        public DateTime PportIssued { get; set; }
        public DateTime PportExpiry { get; set; }
        public string USVisaNum { get; set; }
        public string USVisaIssuance { get; set; }
        public DateTime USVisaIssued { get; set; }
        public DateTime USVisaExp { get; set; }
        public string SBKNo { get; set; }
        public string SBKIssuance { get; set; }
        public DateTime SBKIssued { get; set; }
        public DateTime SBKExpiry { get; set; }

    }
}
