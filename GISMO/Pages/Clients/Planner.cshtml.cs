using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GISMO.Pages.Clients
{
    public class PlannerModel : PageModel
    {
        private AppDbContext _context;
        public PlannerModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Planner> CrewChange { get; set; }
        public Vessels Vessel { get; set; }
        public async Task OnGet(int id)
        {
            CrewChange = await _context.Planner.Where(p => p.VesselId == id).ToListAsync();
        }
    }
}
