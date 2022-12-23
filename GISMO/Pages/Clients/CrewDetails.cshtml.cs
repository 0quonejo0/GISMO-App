using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GISMO.Pages.Clients
{
    public class CrewDetailsModel : PageModel
    {
        public AppDbContext _context;
        public string imgExt = ".jpg";
        public string the2x2 = "";
        
        public CrewDetailsModel(AppDbContext context)
        {
            _context = context;
        }
        public Onboard Seafarer { get; set; }
        public async Task OnGet(int id)
        {
            Seafarer = await _context.Crews.FindAsync(id);
            the2x2 = Seafarer.Id + imgExt;
        }
    }
}
