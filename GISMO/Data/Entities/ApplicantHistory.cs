using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GISMO.Data.Entities
{
    public class ApplicantHistory
    {
        [Column("idnum")]
        public int Id { get; set; }
        public int CrewId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Result { get; set; }
        public string Remarks { get; set; }

    }
}
