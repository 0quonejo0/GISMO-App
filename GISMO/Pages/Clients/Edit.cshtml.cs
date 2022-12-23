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
    public class EditModel : PageModel
    {
        public AppDbContext _context;
        public Client Clients { get; set; }
        public Vessels Vessels { get; set; }
        public EditModel(AppDbContext context)
        {
            _context = context;
        }
        public List<Vessels> ManageVsl { get; set; }
        public async Task OnGet(int id)
        {
            Clients = await _context.Clientele.FindAsync(id);
            ManageVsl = await _context.Vessels.Where(v => v.ClientId == id).ToListAsync();
        }
    }
}
