using GISMO.Data.Entities;
using GISMO.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GISMO.Pages
{
    public class AdvanceSearchModel : PageModel
    {
        private AppDbContext _context;

        public AdvanceSearchModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string SearchText { get; set; }
        [BindProperty]
        public string SearchThisClient { get; set; }
        [BindProperty]
        public string SearchThisVessel { get; set; }
        [BindProperty]
        public string SearchThisExperience { get; set; }
        public List<Onboard> SearchCrew { get; set; }
        public List<Client> SearchClient { get; set; }
        public List<Vessels> SearchAllVsl { get; set; }
        public List<VslExperience> SearchExperience { get; set; }
        public async Task OnGet()
        {

        }

        public async Task OnPostSearch()
        {
            string search = SearchText;
            string clientsearch = SearchThisClient;
            string listofvessels = SearchThisVessel;
            string vslexperience = SearchThisExperience;
            SearchCrew = await _context.Crews.Where(s => s.Lname.Contains(search)).ToListAsync();
            SearchClient = await _context.Clientele.Where(c => c.ClientName.Contains(clientsearch)).ToListAsync();
            SearchAllVsl = await _context.Vessels.Where(v => v.VesselName.Contains(listofvessels)).ToListAsync();
            SearchExperience = await _context.svExperience.Where(e => e.Type.Contains(vslexperience)).ToListAsync();

        }
    }
}
