using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GISMO.Pages.Clients
{
    public class OnboardModel : PageModel
    {
        public int VesselId { get; set; }
        public Vessels Vessel { get; set; }
        public AppDbContext _context;
        public OnboardModel(AppDbContext context)
        {
            _context = context;
        }
        public List<Onboard> Onboards { get; set; }
        public async Task OnGet(int id)
        {
            Vessel = await _context.Vessels.FindAsync(id);
            Onboards = await _context.Crews.Where(o => o.VesselId == id).ToListAsync();
        }
    }
}
