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
    public class VesselPoolModel : PageModel
    {
        private AppDbContext _context;
        public VesselPoolModel(AppDbContext context)
        {
            _context = context;
        }
        public List<Vessels> VesselPool { get; set; }

        public async Task OnGet()
        {
            VesselPool = await _context.Vessels.ToListAsync();
            
        }
    }
}
