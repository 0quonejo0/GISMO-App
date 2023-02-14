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
    public class FindVesselModel : PageModel
    {
        private AppDbContext _context;
        public FindVesselModel(AppDbContext context)
        {
            _context = context;
        }
        public List<Vessels> FoundVessel { get; set; }
        public async Task OnGet(string thisParam)
        {
            FoundVessel = await _context.Vessels.Where(s => s.VesselName.Contains(thisParam)).ToListAsync();

        }
    }
}
