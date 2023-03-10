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
    public class CrewDetailsModel : PageModel
    {
        public AppDbContext _context;
        
        public CrewDetailsModel(AppDbContext context)
        {
            _context = context;
        }
        public Onboard Seafarer { get; set; }
        public List<SeaService> SServices { get; set; }
        public async Task OnGet(int id)
        {
            Seafarer = await _context.Crews.FindAsync(id);
            SServices = await _context.SeaServices.Where(s => s.CrewId == id).ToListAsync();
        }
    }
}
