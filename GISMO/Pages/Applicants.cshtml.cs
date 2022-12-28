using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GISMO.Pages
{
    public class ApplicantsModel : PageModel
    {
        private AppDbContext _context;
        
        
        public ApplicantsModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Applicant> ForInterview { get; set; }
        public List<Appraisal> Appraisals { get; set; }
        public List<Applicant> Applicants { get; set; }
        public List<SeaService> SeaServices { get; set; }
        //public List<_LAgencyCrew> ForInterview { get; set; }
        public int whatOption { get; set; }

        public async Task OnGet(int id)
        {
            ForInterview = await _context.Applicants.ToListAsync();
            Appraisals = await _context.Appraisals.Where(x => x.CrewId == id).ToListAsync();
            SeaServices = await _context.SeaServices.Where(s => s.CrewId == id).ToListAsync();
        }

    }
}
