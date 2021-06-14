using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        //accountNumbers : https://localhost:44315/
        //nameURL: https://localhost:44311/

        private static readonly string[] Prize = new[]
        {
           "£50", "£100", "£300", "£400"
        };

     
        public string GetPrize()
        {
         
            Random rand = new Random();
            int returnIndex = rand.Next(0, 3);
            return Prize[returnIndex].ToString();

        }

        private IConfiguration Configuration;
        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var accountNumService = "https://localhost:44315/accountNumber"; // without this link the code will not work 
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(accountNumService);
            var namesService = "https://localhost:44311/names";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(namesService);
            var prize = GetPrize();

            var mergedServiceResponse =  $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} and won a prize of {prize} ";
            return Ok(mergedServiceResponse);
        }
    
    }
}