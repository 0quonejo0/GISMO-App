using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GISMO.Pages
{
    public class SearchCrewModel : PageModel
    {
        private AppDbContext _context;

        public SearchCrewModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string SearchText { get; set; }
        [BindProperty]
        public string SearchThisClient { get; set; }
        public List<Onboard> SearchCrew { get; set; }
        public List<Client> SearchClient { get; set; }
        public async Task OnGet()
        {

        }

        public async Task OnPostSearch()
        {
            string search = SearchText;
            string clientsearch = SearchThisClient;
            SearchCrew = await _context.Crews.Where(s => s.Lname.Contains(search)).ToListAsync();
            SearchClient = await _context.Clientele.Where(c => c.ClientName.Contains(clientsearch)).ToListAsync();

        }
    }
}
