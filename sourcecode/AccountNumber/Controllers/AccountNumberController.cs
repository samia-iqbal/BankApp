﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AccountNumber.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountNumberController : ControllerBase
    {
        private static readonly string[] AccountNumber = new[]
        {
            "123456", "176987", "134765", "165892"
        };
        private static readonly string[] sortCode = new[]
       {
            "12-12-10", "11-10-12", "19-90-09", "12-09-09"
        };
        [HttpGet]
        public ActionResult<string> Get()
        {
            Random rnd = new Random();
            int returnIndex = rnd.Next(0, 4);
            return $"Account Number: {AccountNumber[returnIndex]}, Sort Code: {sortCode[returnIndex]}";
        }


    }
}
