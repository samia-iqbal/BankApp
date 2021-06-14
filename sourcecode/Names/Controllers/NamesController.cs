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
           "samia IQBAL", "farzana AKHTER ", "Tehmina AHMED", "ciarra BALSOMO", "jordan BENT", "nsama CHIBULU", "darren DOYLE", "victor DUNIRA", "yasmin EL-HENDI", "edwin EMERY", "wamdah HASSAN", "keneil JORDAN"
        };

       // private static readonly string[] Ref = new[]
       //{
       //    "230RED", "230REF", "765GTF", "987JNF", "987GHH"
       // };

        [HttpGet]
        public ActionResult<string> Get()
        {
            Random rand = new Random();
            int returnIndex = rand.Next(0, 11);
            return Name[returnIndex].ToString();  

        }



    }
}
