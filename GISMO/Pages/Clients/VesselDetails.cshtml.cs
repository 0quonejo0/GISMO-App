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
    public class VesselDetailsModel : PageModel
    {
        private AppDbContext _context;
        public string imgExt = ".jpg";
        public string the2x2 = "";
        public VesselDetailsModel(AppDbContext context)
        {
            _context = context;
        }
        public int VesselId { get; set; }
        public Onboard Seafarer { get; set; }
        public List<Onboard> OnboardCrew { get; set; }
        public List<Circular> Circulars { get; set; }
        public List<Event> EventsOB { get; set; }
        public Vessels Vessel { get; set; }

        public async Task OnGet(int id)
        {
            OnboardCrew = await _context.Crews.Where(o => o.VesselId == id).ToListAsync();
            Circulars = await _context.Circulars.Where(c => c.VesselId == id).ToListAsync();
            EventsOB = await _context.Events.Where(e => e.VesselId == id).ToListAsync();
            
        }
    }
}
