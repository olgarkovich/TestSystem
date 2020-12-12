using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Data;
using TestSystem.Models;

namespace TestSystem.Controllers
{
    public class ChatController : Controller
    {
        private readonly IRepository repository;

        public ChatController(IRepository r)
        {
            repository = r;
        }

        public IActionResult Index()
        {
            List<Message> messages = null;
            try
            {
                messages = repository.GetAllMessages();
                messages.Reverse();
            }
            catch (Exception) { }

            return View(messages);
        }
    }
}
