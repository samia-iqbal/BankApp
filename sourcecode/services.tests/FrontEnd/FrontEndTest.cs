using FrontEnd.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace services.tests.FrontEnd
{
    public class FrontEndTest
    {
      [Fact]
        public void GetTest()
        {
            //arrange
            HomeController frontEndHomeController = new HomeController();

            //act 
            var frontEndResult = frontEndHomeController.Index();
            //assert
            Assert.NotNull(frontEndResult);
            Assert.IsType<ActionResult<string>>(frontEndResult);

        }

    }
}
