using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GISMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        [HttpGet("reverse")]
        public IActionResult Reverse()
        {
            string result = string.Empty;
            result = HttpContext.Request.Query["productids"];
            string[] productIdArray = result.Split(',');

            List<string> results = new List<string>();
            for (int counter = productIdArray.Length; counter > 0; counter--)
            {
                results.Add(productIdArray[counter - 1]);
            }
            return Ok(results);
        }

        [HttpGet("deletepart")]
        public IActionResult Delete()
        {
            string result = string.Empty;
            return Ok(result);
        }
    }
}
