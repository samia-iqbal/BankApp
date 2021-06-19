using AccountNumber.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace services.tests.AccountNumber
{
    public class AccountNumberTest
    {
        [Fact]

        public void GetTest()
        {
            //arrange
            AccountNumberController accountNumberController = new AccountNumberController();
            
            //act 
            var accountNumResult = accountNumberController.Get();
            //assert
            Assert.NotNull(accountNumResult);
            Assert.IsType<ActionResult<string>>(accountNumResult);

        }
    }
}
