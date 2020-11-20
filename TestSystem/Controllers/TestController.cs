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
        const int QUESTIONS_NUMBER = 5;
        const int SPELLING_QUESTION_NUMBER = 3;
        const int PUNCT_QUESTION_NUMBER = 3;
        const int OPEN_QUESTION_NUMBER = 2;

        public TestController(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                var listQuestions = await context.Questions.ToListAsync();
                
                var countTest = listQuestions.Count / (QUESTIONS_NUMBER * 2);

                List<Test> listGeneralTest = new List<Test>();

                for (int i = 0; i < countTest; i++)
                {
                    listGeneralTest.Add(new Test());
                    listGeneralTest.ElementAt(i).Name = $"Общий тест {i + 1}";
                    listGeneralTest.ElementAt(i).Id = i;
                }

                return View(listGeneralTest);
            }

            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public async Task<IActionResult> GeneralTestAsync(int index = 0)
        {
            var listQuestions = await context.Questions.ToListAsync();
            var listAnswers = await context.Answers.ToListAsync();

            var listSpelling = new List<Question>(listQuestions.Where(a => a.Category == "Орфография" && !a.IsOpen));
            var listPunctuation = new List<Question>(listQuestions.Where(a => a.Category == "Пунктуация" && !a.IsOpen));
            var listSyntax = new List<Question>(listQuestions.Where(a => a.Category == "Синтаксис" && !a.IsOpen));
            var listMorphology = new List<Question>(listQuestions.Where(a => a.Category == "Морфология" && !a.IsOpen));
            var listOpen = new List<Question>(listQuestions.Where(a => a.IsOpen));
            
            Test test = new Test
            {
                CloseQuestions = new List<CloseQuestion>(),
                OpenQuestions = new List<OpenQuestion>()
            };

            test.Name = $"Общий тест {index + 1}";

            for (int i = 0; i < SPELLING_QUESTION_NUMBER; i++)
            {
                var cq = new CloseQuestion(listSpelling.ElementAt(index * SPELLING_QUESTION_NUMBER + i));
                test.CloseQuestions.Add(cq);
            }

            for (int i = 0; i < PUNCT_QUESTION_NUMBER; i++)
            {
                var cq = new CloseQuestion(listPunctuation.ElementAt(index * PUNCT_QUESTION_NUMBER + i));
                test.CloseQuestions.Add(cq);
            }

            test.CloseQuestions.Add(new CloseQuestion(listMorphology.ElementAt(index + 1)));
            test.CloseQuestions.Add(new CloseQuestion(listSyntax.ElementAt(index + 1)));

            foreach (var q in test.CloseQuestions)
            {
                q.Answers = new List<Answer>(listAnswers.Where(a => a.QuestionId == q.Id));
            }

            for (int i = 0; i < OPEN_QUESTION_NUMBER; i++)
            {
                var cq = new OpenQuestion(listOpen.ElementAt(index * OPEN_QUESTION_NUMBER + i));
                cq.RightAnswer = listAnswers.Where(a => a.QuestionId == cq.Id).ElementAt(0);
                test.OpenQuestions.Add(cq);
            }

            return View(test);
        }

        public async Task<IActionResult> TestResultAsync(int testTry)
        {
            var userAnswers = await context.UserAnswers.Where(t => t.TestTry == testTry).ToListAsync();
            var listQuestions = await context.Questions.ToListAsync();
            var listAnswer = await context.Answers.ToListAsync();
            
            Test test = new Test
            {
                CloseQuestions = new List<CloseQuestion>(),
                OpenQuestions = new List<OpenQuestion>()
            };


            foreach (var userAnswer in userAnswers)
            {
                var q = new Question();
                q = listQuestions.Where(q => q.Id == userAnswer.QuestionId).ElementAt(0);

                if (q.IsOpen) 
                {
                    var oq = new OpenQuestion(q);
                    oq.Choice = userAnswer.Answer;
                    oq.RightAnswer = listAnswer.Where(a => a.QuestionId == q.Id).ElementAt(0);

                    if (oq.Choice != null)
                    {
                        oq.Choice.ToLower();
                    }
                    oq.RightAnswer.TextAnswer.ToLower();

                    test.OpenQuestions.Add(oq);
                }
                else
                {
                    var cq = new CloseQuestion(q)
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
            }

            double right = 0;
            int wrong = 0;

            foreach (var question in test.CloseQuestions)
            {
                foreach (var answer in question.Answers)
                {
                    if (answer.IsChecked == answer.IsRight)
                        right++;
                    else
                        wrong++;
                }
            }

            foreach (var question in test.OpenQuestions)
            {
                if (question.Choice == question.RightAnswer.TextAnswer)
                    right++;
                else
                    wrong++;
            }

            test.Result = Math.Round(Convert.ToDouble(right / (right + wrong) * 100));

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

                var userAnswer = new UserAnswer(User.Identity.Name, question.Answers[0].QuestionId, answerStr, currentTest);
                context.UserAnswers.Add(userAnswer);
            }

            foreach (var question in test.OpenQuestions)
            {
                var userAnswer = new UserAnswer(User.Identity.Name, question.Id, question.Choice, currentTest);
                context.UserAnswers.Add(userAnswer);
            }

            await context.SaveChangesAsync();
            return RedirectToAction("TestResult", new { testTry = currentTest });
        }

        public async Task<IActionResult> CategoryAsync(string category)
        {
            var listQuestions = await context.Questions.Where(q => q.Category == category && !q.IsOpen).ToListAsync();
            var countTest = listQuestions.Count / QUESTIONS_NUMBER;

            List<Test> listCategoryTest = new List<Test>();

            for (int i = 0; i < countTest; i++)
            {
                listCategoryTest.Add(new Test(i, $"{category} {i + 1}", category));
            }
            return View(listCategoryTest);
        }

        public async Task<IActionResult> CategoryTestAsync(int index = 0, string category = "Орфография")
        {
            var listQuestions = await context.Questions.Where(q => q.Category == category && !q.IsOpen).ToListAsync();

            Test test = new Test
            {
                CloseQuestions = new List<CloseQuestion>()
            };

            test.Name = $"Тест по разделу '{category}' {index + 1}";

            for (int i = 0; i < QUESTIONS_NUMBER; i++)
            {
                var cq = new CloseQuestion(listQuestions.ElementAt(index * QUESTIONS_NUMBER + i));
                cq.Answers = await context.Answers.Where(a => a.QuestionId == cq.Id).ToListAsync();

                test.CloseQuestions.Add(cq);
            }

            return View(test);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryTestAsync(Test test)
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

                var userAnswer = new UserAnswer(User.Identity.Name, question.Id, answerStr, currentTest);
                context.UserAnswers.Add(userAnswer);
            }

            await context.SaveChangesAsync();
            return RedirectToAction("TestResult", new { testTry = currentTest });
        }
    }
}
