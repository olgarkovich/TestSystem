using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using TestSystem.Controllers;
using Xunit;

namespace TestSystem.Tests
{
    public class AccountControllerTests
    {
        [Fact]
        public void RegisterTest()
        {
            AccountController controller = new AccountController();

            ViewResult result = controller.Register() as ViewResult;

            Assert.Equal("Регистрация", result?.ViewData["Title"]);
            Assert.NotNull(result);
            Assert.Equal("Register", result?.ViewName);
        }

        [Fact]
        public void LoginTest()
        {
            AccountController controller = new AccountController();

            ViewResult result = controller.Login() as ViewResult;

            Assert.Equal("Вход", result?.ViewData["Title"]);
            Assert.NotNull(result);
            Assert.Equal("Login", result?.ViewName);
        }
    }
}
