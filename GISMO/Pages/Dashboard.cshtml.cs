using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GISMO.Pages
{
    public class DashboardModel : PageModel
    {
        private AppDbContext _context;
        public DashboardModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Analytics> Analytics { get; set; }
        public List<AnaClientVessels> VesselByClient { get; set; }
        public async Task OnGet()
        {
            Analytics = await _context.OwnerGraph.ToListAsync();
            VesselByClient = await _context.svAnaClientVessels.ToListAsync();
        }
    }
}
