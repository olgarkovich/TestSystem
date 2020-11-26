using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult ErrorPage(int statusCode)
        {
            switch(statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Ошибка. Запрашиваемый ресурс не был найден. Повторите попытку позже";
                    break;
                default:
                    ViewBag.ErrorMessage = "Что-то пошло не так. Повторите попытку позже";
                    break;
            }
            return View("NotFound");
        }
    }
}
