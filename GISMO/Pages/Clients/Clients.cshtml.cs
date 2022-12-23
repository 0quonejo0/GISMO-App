using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GISMO.Data;
using GISMO.Data.Entities;
using System.Net.Http;

namespace GISMO.Pages.Clients
{
    public class ClientsModel : PageModel
    {
        private AppDbContext _context;

        public ClientsModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Client> Clients { get; set; }
        public List<Applicant> Applicants { get; set; }
                
        public async Task OnGet()
        {
            Clients = await _context.Clientele.ToListAsync();
            Applicants = await _context.Applicants.Where(s => s.Status == "Pending").ToListAsync();

        }

        public async Task OnPost()
        {
        }
    }
}
