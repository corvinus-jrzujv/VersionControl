using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample_Test
{
    public class AccountControllerPasswordTest
    {
        [
         Test,
         TestCase("abcd", false),
         TestCase("CAPITAL", false),
         TestCase("nocapital", false),
         TestCase("Capital11", false),
         TestCase("GoodPassword10", true)
        ]
        public void ValidatePassword(string password, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
