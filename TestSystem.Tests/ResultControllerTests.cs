using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using TestSystem.Controllers;
using TestSystem.Data;
using TestSystem.Models;
using TestSystem.Services;
using Xunit;

namespace TestSystem.Tests
{
    public class ResultControllerTests
    {
        [Fact]
        public void GetCorrectUserTest()
        {
            Mock<EmailService> mockEmailService = new Mock<EmailService>();
            Mock<FakeUserManager> mockUserManager = new Mock<FakeUserManager>();
            mockUserManager.Setup(x => x.FindByIdAsync(It.IsAny<string>())).Returns(() => null);
            Mock<FakeSignInManager> mockSignIn = new Mock<FakeSignInManager>();

            var mock = new Mock<IRepository>();
            var name = "Misha";
            mock.Setup(r => r.GetUserByNameAsync(name)).Returns(GetTestProfile(name));
            var user = mock.Object.GetUserByNameAsync(name);

            Assert.NotNull(user);
            Assert.Equal("Misha", user.Name);

        }

        [Fact]
        public void GetErrorUserTest()
        {

            Mock<EmailService> mockEmailService = new Mock<EmailService>();
            Mock<FakeUserManager> mockUserManager = new Mock<FakeUserManager>();
            mockUserManager.Setup(x => x.FindByIdAsync(It.IsAny<string>())).Returns(() => null);
            Mock<FakeSignInManager> mockSignIn = new Mock<FakeSignInManager>();

            var mock = new Mock<IRepository>();
            var name = "Masha";
            mock.Setup(r => r.GetUserByNameAsync(name)).Returns(GetTestProfile(name));
            var user = mock.Object.GetUserByNameAsync(name);

            Assert.Null(user);
        }

        private Profile GetTestProfile(string name)
        {
            var profile = new Profile();
            profile.Surname = "Ivanov";
            profile.Name = "Misha";

            if (profile.Name == name)
                return profile;
            else
                return null;
        }
    }
}
