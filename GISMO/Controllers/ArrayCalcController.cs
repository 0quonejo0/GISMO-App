using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
            string delpos = string.Empty;
            result = HttpContext.Request.Query["productids"];
            delpos = HttpContext.Request.Query["position"];
            string[] productArray = result.Split(',');

            bool gateWay(string pos)
            {
                return pos != delpos;
            }

            productArray = Array.FindAll(productArray, gateWay).ToArray();

            return Ok(productArray);
        }
    }
}
