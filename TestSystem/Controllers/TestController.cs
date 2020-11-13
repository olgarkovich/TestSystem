using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Data;
using TestSystem.Models;

namespace TestSystem.Controllers
{
    public class TestController : Controller
    {
        private readonly AppDbContext context;
        const int QUESTION_NUMBER = 5;

        public TestController(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var listQuestions = await context.Questions.ToListAsync();
            var countTest = listQuestions.Count / QUESTION_NUMBER;

            List<Test> listGeneralTest = new List<Test>();

            for (int i = 0; i < countTest; i++)
            {
                listGeneralTest.Add(new Test());
                listGeneralTest.ElementAt(i).Name = $"Общий тест {i + 1}";
                listGeneralTest.ElementAt(i).Id = i;
            }

            return View(listGeneralTest);
        }

        public async Task<IActionResult> GeneralTestAsync(int index = 0)
        {
            var listQuestions = await context.Questions.ToListAsync();
            Test test = new Test
            {
                CloseQuestions = new List<CloseQuestion>()
            };

            test.Name = $"Общий тест {index + 1}";

            for (int i = 0; i < QUESTION_NUMBER; i++) 
            {
                var cq = new CloseQuestion(listQuestions.ElementAt(index * QUESTION_NUMBER + i))
                {
                    Answers = await context.Answers.Where(a => a.QuestionId == index * QUESTION_NUMBER + i + 1).ToListAsync()
                };
                test.CloseQuestions.Add(cq);
                //test.CloseQuestions.Add(new CloseQuestion(listQuestions.ElementAt(index * QUESTION_NUMBER + i)));
            }

            return View(test);
        }

        public async Task<IActionResult> CategoryAsync(string category)
        {
            var listQuestions = await context.Questions.Where(q => q.Category == category).ToListAsync();
            var countTest = listQuestions.Count / QUESTION_NUMBER;

            List<Test> listCategoryTest = new List<Test>();

            for (int i = 0; i < countTest; i++)
            {
                listCategoryTest.Add(new Test(i, $"{category} {i + 1}", category));
                //listCategoryTest.ElementAt(i).Name = $"{category} {i + 1}";
                //listCategoryTest.ElementAt(i).Id = i;
                //listCategoryTest.ElementAt(i).Category = category;
            }
            return View(listCategoryTest);
        }

        public async Task<IActionResult> CategoryTestAsync(int index = 0, string category = "Орфография")
        {
            var listQuestions = await context.Questions.Where(q => q.Category == category).ToListAsync();
            
            Test test = new Test
            {
                CloseQuestions = new List<CloseQuestion>()
            };

            test.Name = $"Тест по разделу '{category}' {index + 1}";

            for (int i = 0; i < QUESTION_NUMBER; i++)
            {
                var cq = new CloseQuestion(listQuestions.ElementAt(index * QUESTION_NUMBER + i))
                {
                    Answers = await context.Answers.Where(a => a.QuestionId == index * QUESTION_NUMBER + i + 1).ToListAsync()
                };
                test.CloseQuestions.Add(cq);
                //test.CloseQuestions.Add(new CloseQuestion(listQuestions.ElementAt(index * QUESTION_NUMBER + i)));
            }

            return View(test);
        }
    }
}
