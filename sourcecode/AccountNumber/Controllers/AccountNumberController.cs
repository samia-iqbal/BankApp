using System;
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
            "176583" , "298654", "387697", "490866" , "587678"
        };
      
        [HttpGet]
        public ActionResult<string> Get()
        {
            Random randomGen = new ();
            int returnAccountNumController = randomGen.Next(0, 4);
            //return $"Account Number: {AccountNumber[returnIndex]}, Sort Code: {sortCode[returnIndex]}";
            return AccountNumber[returnAccountNumController].ToString();

        }


    }
}
