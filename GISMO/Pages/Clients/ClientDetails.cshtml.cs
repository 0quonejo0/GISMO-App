using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GISMO.Data;
using GISMO.Data.Entities;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace GISMO.Pages.Clients
{
    public class ClientDetailsModel : PageModel
    {
        private AppDbContext _dbcontext;
        public Vessels Vessels { get; set; }

        public ClientDetailsModel(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public List<Vessels> SelVessels { get; set; }
        public async Task OnGet(int id)
        {
            
            SelVessels = await _dbcontext.Vessels.Where(v => v.ClientId == id).ToListAsync();
        }
    }
}
