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
        public async Task<IActionResult> Get(int id)
        {
            //string jsonresult = "test";
            var applicants = await _dbContext.Applicants.ToListAsync();

            return Ok(applicants.Count);
        }



    }
}
