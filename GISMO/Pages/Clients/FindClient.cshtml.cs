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
    public class FindClientModel : PageModel
    {
        private AppDbContext _context;
        public FindClientModel(AppDbContext context)
        {
            _context = context;
        }
        public List<Client> FoundClients { get; set; }
        public async Task OnGet(string thisParam)
        {
            FoundClients = await _context.Clientele.Where(s => s.ClientName.Contains(thisParam)).ToListAsync();
        }
    }
}
