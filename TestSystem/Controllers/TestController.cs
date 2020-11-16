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
            }

            return View(test);
        }

        public async Task<IActionResult> TestResultAsync(int testTry)
        {
            var userAnswers = await context.UserAnswers.Where(t => t.TestTry == testTry).ToListAsync();
            var listQuestions = await context.Questions.ToListAsync();
            Test test = new Test
            {
                CloseQuestions = new List<CloseQuestion>()
            };


            foreach (var userAnswer in userAnswers)
            {
                var cq = new CloseQuestion(listQuestions.ElementAt(Convert.ToInt32(userAnswer.QuestionId - 1)))
                {
                    Answers = await context.Answers.Where(a => a.QuestionId == userAnswer.QuestionId).ToListAsync()
                };

                var answerStr = userAnswer.Answer;

                foreach (var answer in cq.Answers)
                {
                    if (answerStr.IndexOf($" {answer.Id} ") != -1)
                    {
                        answer.IsChecked = true;
                    }
                }
                test.CloseQuestions.Add(cq);
            }

            return View(test);
        }


        [HttpPost]
        public async Task<IActionResult> GeneralTestAsync(Test test)
        {
            int currentTest;
            try
            {
                List<UserAnswer> list = await context.UserAnswers.ToListAsync();
                currentTest = list.ElementAt(list.Count - 1).TestTry + 1;
            }

            catch
            {
                currentTest = 1;
            }
            
            foreach (var question in test.CloseQuestions)
            {
                string answerStr = " ";
                foreach (var answer in question.Answers)
                {
                    if (answer.IsChecked)
                    {
                        answerStr += $"{answer.Id} ";
                    }
                }

                var userAnswer = new UserAnswer(1000, question.Id, answerStr, currentTest);
                context.UserAnswers.Add(userAnswer);
            }

            await context.SaveChangesAsync();
            return RedirectToAction("TestResult", new { testTry = currentTest });
        }

        public async Task<IActionResult> CategoryAsync(string category)
        {
            var listQuestions = await context.Questions.Where(q => q.Category == category).ToListAsync();
            var countTest = listQuestions.Count / QUESTION_NUMBER;

            List<Test> listCategoryTest = new List<Test>();

            for (int i = 0; i < countTest; i++)
            {
                listCategoryTest.Add(new Test(i, $"{category} {i + 1}", category));
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
            }

            return View(test);
        }
    }
}
