using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Models;
using TestSystem.Services;
using TestSystem.ViewModels;

namespace TestSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Profile> userManager;
        private readonly SignInManager<Profile> signInManager;
        private readonly EmailService emailService;

        public AccountController(UserManager<Profile> userManager, 
                                 SignInManager<Profile> signInManager, 
                                 EmailService emailService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailService = emailService;

        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewData["Title"] = "Регистрация";
            return View("Register");
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new Profile 
                { 
                    Surname = model.Surname,
                    Name = model.Name,
                    UserName = model.UserName, 
                    Email = model.Email 
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    emailService.Send(model.Email, "Вы зарегистрированы на сайте testsystemasp.azurewebsites.net .", "Регистрация профиля");
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Title"] = "Вход";
            return View("Login");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Profile signedUser = await userManager.FindByEmailAsync(model.Email);
                var result = await signInManager.PasswordSignInAsync(signedUser.UserName, model.Password, 
                                                                     model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Неверный адрес электронной почты и/или пароль");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

