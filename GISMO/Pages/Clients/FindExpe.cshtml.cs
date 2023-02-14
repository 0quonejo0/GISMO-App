using GISMO.Data.Entities;
using GISMO.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GISMO.Pages.Clients
{
    public class FindExpeModel : PageModel
    {
        private AppDbContext _context;
        public FindExpeModel(AppDbContext context)
        {
            _context = context;
        }
        public List<VslExperience> FoundExpe { get; set; }
        public async Task OnGet(string thisParam)
        {
            FoundExpe = await _context.svExperience.Where(s => s.Type.Contains(thisParam)).ToListAsync();

        }
    }
}
