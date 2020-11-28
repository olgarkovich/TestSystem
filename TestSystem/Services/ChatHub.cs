using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Data;
using TestSystem.Models;

namespace TestSystem.Services
{
    public class ChatHub : Hub
    {
        private readonly AppDbContext context;
        private readonly UserManager<Profile> userManager;

        public ChatHub(AppDbContext context, UserManager<Profile> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task Send(string text, string userName)
        {
            //var message = new Message
            //{
            //    Text = text,
            //    Username = userName
            //};
            //context.Messages.Add(message);
            //await context.SaveChangesAsync();
            await Clients.All.SendAsync("Send", text, userName);
        }
        //public async Task Send(string message, string userName)
        //{
        //    await Clients.All.SendAsync("Send", message, userName);
        //}
    }
}
