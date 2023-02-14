using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GISMO.Pages.Clients
{
    public class PartialDemoModel : PageModel
    {
        public List<string> Animals = new List<string>();

        public async Task OnGet()
        {
            Animals.AddRange(new[] { "Antelope", "Badger", "Cat", "Dog" });

            //Animals = await _context.Crews.ToListAsync();

            //Animals.AddRange(await _context.Crews.Where(s => s.Lname.Contains("a")).ToListAsync());

            //Animals = await _context.Crews.Where(s => s.Lname.Contains("a")).ToListAsync();
        }
    }
}
