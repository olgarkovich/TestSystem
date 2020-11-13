using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Data;
using TestSystem.Models;

namespace TestSystem.Views
{
    public class TesterController : Controller
    {
        private readonly AppDbContext context;
        private Tester tester;
        public TesterController(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        //public IActionResult Index()
        {
            var tester = new Tester();
            tester.CurrentTest = new Test();

            tester.CurrentTest.CloseQuestions = new List<CloseQuestion>();
            tester.CurrentTest.OpenQuestions = new List<OpenQuestion>();

            var list = await context.Questions.ToListAsync();
            var answers = await context.Answers.ToListAsync();
            for (int i = 1; i < list.Count; i++)
            {
                tester.CurrentTest.CloseQuestions.Add(new CloseQuestion(
                    list.ElementAt(i + 1), 
                    answers.FindAll(a => a.Id == i && a.IsRight),
                    answers.FindAll(a => a.Id == i && !a.IsRight)));
                
            }

            return View();
        }
    }
}
