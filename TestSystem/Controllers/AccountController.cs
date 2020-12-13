using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        public async Task<IActionResult> Login(string resultUrl)
        {
            ViewData["Title"] = "Вход";

            LoginViewModel model = new LoginViewModel
            {
                ReturnUrl = resultUrl,
                ExternalLogin = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(model);
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

        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "Account",
                new { ReturnUrl = returnUrl });
            var property = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            return new ChallengeResult(provider, property);

        }

        public async Task<IActionResult> ExternalLoginCallback(string resultUrl = null, string remoteError = null)
        {
            resultUrl = resultUrl ?? Url.Content("~/");
            LoginViewModel loginViewModel = new LoginViewModel
            {
                ReturnUrl = resultUrl,
                ExternalLogin = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from eternal provider: {remoteError}");
                return View("Login", loginViewModel);
            }

            var info = await signInManager.GetExternalLoginInfoAsync();
            if(info == null)
            {
                ModelState.AddModelError(string.Empty, "Error loading external login information.");
                return View("Login", loginViewModel);
            }

            var signInResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false, true);

            if (signInResult.Succeeded)
            {
                return LocalRedirect(resultUrl);
            }
            else
            {
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);

                if (email != null)
                {
                    var user = await userManager.FindByEmailAsync(email);

                    await userManager.AddLoginAsync(user, info);
                    await signInManager.SignInAsync(user, false);

                    return LocalRedirect(resultUrl);
                }
            }

            return View("Login", loginViewModel);
        }
    }
}

