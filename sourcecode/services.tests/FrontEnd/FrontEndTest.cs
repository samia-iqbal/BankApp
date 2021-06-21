using FrontEnd;
using FrontEnd.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
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
     
        private AppSettings appSettings = new AppSettings()
        {
            mergedServiceURL = "http://samia-mergecontroller.azurewebsites.net"

        };
        [Fact]
        public async void GetFrontEndTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            HomeController homeController = new HomeController(options.Object);
            var homeContollerResult = await homeController.Index();

            Assert.NotNull(homeContollerResult);
            //Assert.IsType<OkObjectResult>(homeContollerResult);
        }

    }
}
