using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GISMO.Pages
{
    public class VesselsPoolModel : PageModel
    {
        private AppDbContext _context;
        public VesselsPoolModel(AppDbContext context)
        {
            _context = context;
        }
        public List<Vessels> AddVessel { get; set; }

        public async Task OnGet()
        {

        }

    }
}
