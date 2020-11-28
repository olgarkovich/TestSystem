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
        private readonly AppDbContext context;
        public ChatController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Message> messages = null;
            try
            {
                messages = context.Messages.ToList();
                messages.Reverse();
            }
            catch (Exception) { }

            return View(messages);
        }
    }
}
