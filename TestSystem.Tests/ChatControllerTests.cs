using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestSystem.Controllers;
using TestSystem.Data;
using TestSystem.Models;
using Xunit;

namespace TestSystem.Tests
{
    public class ChatControllerTests
    {
        [Fact]
        public void IndexReturnsAViewResultWithAListOfUsers()
        {
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetAllMessages()).Returns(GetTestMessages());
            var controller = new ChatController(mock.Object);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Message>>(viewResult.Model);
            Assert.Equal(GetTestMessages().Count, model.Count());
        }

        private List<Message> GetTestMessages()
        {
            var users = new List<Message>
            {
                new Message { Id=1, Text="Message 1", Username="User 1"},
                new Message { Id=2, Text="Message 2", Username="User 2"},
                new Message { Id=3, Text="Message 3", Username="User 3"},
                new Message { Id=4, Text="Message 4", Username="User 4"},
            };
            return users;
        }
    }
}
