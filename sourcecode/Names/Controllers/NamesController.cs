using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Names.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NamesController : ControllerBase
    {
        private static readonly string[ ] Name = new[ ]
        {
           "samia", "amina" , "zahid" , "rehaan" , "zain"
        };

       

        [HttpGet]
        public ActionResult<string> Get()
        {
            Random rand = new ();
            int returnNamesController = rand.Next(0, 4);
            return Name[returnNamesController].ToString();  

        }



    }
}
