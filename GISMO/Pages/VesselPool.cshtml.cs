using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GISMO.Pages
{
    public class VesselPoolModel : PageModel
    {
        private AppDbContext _context;
        [BindProperty]
        [Required(ErrorMessage = "No vessel to search")]
        public string SearchThisVessel { get; set; }
        public List<Vessels> VesselPool { get; set; }
        public Vessels Vessels { get; set; }
        public List<Vessels> SearchAllVsl { get; set; }
        public VesselPoolModel(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task OnGet(int id)
        {
            VesselPool = await _context.Vessels.ToListAsync();
            Vessels = await _context.Vessels.FindAsync(id);
        }

        public async Task OnPost()
        {
            string search = SearchThisVessel;
            SearchAllVsl = await _context.Vessels.Where(v => v.VesselName.Contains(search)).ToListAsync();

        }
    }
}
