using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Data;
using TestSystem.Models;
using TestSystem.Services;

namespace TestSystem.Controllers
{
    public class ResultController : Controller
    {
        private readonly UserManager<Profile> userManager;
        private readonly SignInManager<Profile> signInManager;
        private readonly EmailService emailService;
        private readonly IRepository repository;
        private Profile profile;
        public ResultController(UserManager<Profile> userManager,
                                 SignInManager<Profile> signInManager,
                                 EmailService emailService,
                                 IRepository repository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailService = emailService;
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SendMailAsync(double mark)
        {
            profile = await repository.GetUserByNameAsync(User.Identity.Name);

            Result result = new Result
            {
                Mark = Convert.ToInt32(mark),
                Name = profile.Name,
                Surname = profile.Surname
            };

            return View(result);
        }

        [HttpPost]
        public IActionResult SendMail(Result result)
        {
            if (ModelState.IsValid)
            {
                string message = $"Результат теста {result.Name} {result.Surname}: {result.Mark}";
                emailService.Send(result.ToEmail, message, "Результат теста");
                return RedirectToAction("Index", "Home");
            }

            result.Comment = "Некорректный адрес электронной почты";

            return View(result);
        }
    }
}
