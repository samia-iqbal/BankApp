using Microsoft.AspNetCore.Mvc;
using Names.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace services.tests.Names
{
   public class NamesTest
    {
        [Fact]

        public void GetNameController()
        {
            //arrange
            NamesController namesController = new NamesController();

            //act 
            var namesResult = namesController.Get();
            //assert
            Assert.NotNull(namesResult);
            Assert.IsType<ActionResult<string>>(namesResult);

        }
    }
}
