using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using TestSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestSystem.Controllers;
using TestSystem.Data;

namespace TestSystem.Tests
{
    public class TestControllerTests
    {
        [Fact]
        public void IndexTest()
        {
            var mock = new Mock<IRepository>();
            mock.Setup(r => r.GetAllQuestions()).ReturnsAsync(GetTestQuestions());
            var questions = mock.Object.GetAllQuestions().Result;
            Test test = new Test();
            List<Test> tests = new List<Test>();
            var countTest = questions.Count / 5;

            for (int i = 0; i < countTest; i++)
            {
                tests.Add(new Test());
                tests.ElementAt(i).Id = i;
            }

            Assert.Equal(5, questions.Count);
            Assert.Single(tests);
        }

        private List<Question> GetTestQuestions()
        {
            var questions = new List<Question>
            {
               new Question
                {
                    Id = 1,
                    Task = "Пишется а на месте пропуска в словах:",
                    Weight = 1,
                    Category = "Орфография",
                    IsOpen = false
                },

                new Question
                {
                    Id = 2,
                    Task = "Пишется е на месте всех пропусков в рядах:",
                    Weight = 1,
                    Category = "Орфография",
                    IsOpen = false
                },

                new Question
                {
                    Id = 3,
                    Task = "Двойные согласные пишутся в словах:",
                    Weight = 1,
                    Category = "Орфография",
                    IsOpen = false
                },

                new Question
                {
                    Id = 4,
                    Task = "Пишется о на месте пропуска в словах:",
                    Weight = 1,
                    Category = "Орфография",
                    IsOpen = false
                },
                new Question
                {
                    Id = 5,
                    Task = "Укажите ряды, в которых на месте двух пропусков пишется одна и та же буква:",
                    Weight = 1,
                    Category = "Орфография",
                    IsOpen = false
                }
            };
            return questions;
        }
    
    }
}
