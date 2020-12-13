using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TestSystem.Controllers;
using TestSystem.Models;
using TestSystem.Services;
using Xunit;

namespace TestSystem.Tests
{
    public class AccountControllerTests
    {
        [Fact]
        public void RegisterTest()
        {
            Mock<EmailService> mockEmailService = new Mock<EmailService>();
            Mock<FakeUserManager> mockUserManager = new Mock<FakeUserManager>();
            mockUserManager.Setup(x => x.FindByIdAsync(It.IsAny<string>())).Returns(() => null);
            Mock<FakeSignInManager> mockSignIn = new Mock<FakeSignInManager>();

            AccountController controller = new AccountController(mockUserManager.Object, mockSignIn.Object, mockEmailService.Object);

            ViewResult result = controller.Register() as ViewResult;

            Assert.Equal("Регистрация", result?.ViewData["Title"]);
            Assert.NotNull(result);
            Assert.Equal("Register", result?.ViewName);
        }

        [Fact]
        public void LoginTest()
        {
            //Mock<EmailService> mockEmailService = new Mock<EmailService>();
            //Mock<FakeUserManager> mockUserManager = new Mock<FakeUserManager>();
            //Mock<FakeSignInManager> mockSignIn = new Mock<FakeSignInManager>();

            //AccountController controller = new AccountController(mockUserManager.Object, mockSignIn.Object, mockEmailService.Object);

            //ViewResult result = controller.Login("pam-pam") as ViewResult;

            //Assert.Equal("Вход", result?.ViewData["Title"]);
            //Assert.NotNull(result);
            //Assert.Equal("Login", result?.ViewName);
        }
    }
}
