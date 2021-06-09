﻿using System;
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

        private IConfiguration Configuration;
        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var numbersService = "https://localhost:44315/";
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(numbersService);
            var lettersService = "https://localhost:44311/";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(lettersService);
            var mergedResponse =  $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
