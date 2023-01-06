using GISMO.Data.Entities;
using GISMO.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace GISMO.Pages
{
    public class InterviewModel : PageModel
    {
        private AppDbContext _context;
        public InterviewModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Evaluation { get; set; }
        public Onboard Crew { get; set; }
        public List<Onboard> Applicant { get; set; }

        public async Task OnGet(int id)
        {
            Crew = await _context.Crews.FindAsync(id);
            Applicant = await _context.Crews.Where(a => a.Id == id).ToListAsync();
        }
    }
}
