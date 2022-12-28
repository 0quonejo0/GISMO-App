using GISMO.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GISMO.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class CrewController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public CrewController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string clientid)
        {
            //var applicants = await _dbContext.Applicants.ToListAsync();
            var crewlist = await _dbContext.Crews.ToListAsync();

            return Ok(crewlist);
        }
        



    }
}
