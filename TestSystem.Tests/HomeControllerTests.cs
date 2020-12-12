using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using TestSystem.Controllers;
using Xunit;
using NLog.Web;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace TestSystem.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexViewDataMessage()
        {
            var serviceProvider = new ServiceCollection().AddLogging().BuildServiceProvider();

            var factory = serviceProvider.GetService<ILoggerFactory>();

            var logger = factory.CreateLogger<HomeController>();
            HomeController controller = new HomeController(logger);

            ViewResult result = controller.Index() as ViewResult;

            Assert.Equal("Главная", result?.ViewData["Title"]);
            Assert.NotNull(result);
            Assert.Equal("Index", result?.ViewName);
        }
    }
}
