using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Data;

namespace TestSystem.Controllers
{
    public class OpenQuestionController : Controller
    {
        private readonly AppDbContext context;
        public OpenQuestionController(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var list = await context.Questions.Where(q => q.IsOpen).ToListAsync();
            return View(list);
        }
    }
}
