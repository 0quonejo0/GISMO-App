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
    public class FindSeafarerModel : PageModel
    {
        private AppDbContext _context;
        public FindSeafarerModel(AppDbContext context)
        {
            _context = context;
        }
        public List<Onboard> FoundSeafarers { get; set; }
        public async Task OnGet(string thisParam)
        {
            FoundSeafarers = await _context.Crews.Where(s => s.Lname.Contains(thisParam)).ToListAsync();

        }
    }
}
