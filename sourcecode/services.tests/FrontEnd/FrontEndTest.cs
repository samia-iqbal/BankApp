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
            mergedServiceURL = "https://samia-mergecontroller.azurewebsites.net"

        };
        [Fact]
        public async void GetTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            HomeController mergeController = new HomeController(options.Object);
            var mergeContollerResult = await mergeController.Index();

            Assert.NotNull(mergeContollerResult);
            //Assert.IsType<OkObjectResult>(mergeContollerResult);
        }

    }
}
