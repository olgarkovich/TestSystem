using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Models;

namespace TestSystem.Data
{
    public class EfRepository : IRepository
    {
        private readonly AppDbContext context;
        private readonly AppIdentityDbContext idContext;

        public EfRepository(AppDbContext context, AppIdentityDbContext idContext)
        {
            this.context = context;
            this.idContext = idContext;
        }

        public Task AddUserAnswer(UserAnswer userAnswer)
        {
            context.UserAnswers.Add(userAnswer);
            return context.SaveChangesAsync();
        }

        public Task<List<Answer>> GetAllAnswers()
        {
            return context.Answers.ToListAsync();
        }

        public List<Message> GetAllMessages()
        {
            return context.Messages.ToList();
        }

        public Task<List<Question>> GetAllQuestions()
        {
            return context.Questions.ToListAsync();
        }

        public Task<List<Question>> GetQuestionsByCategoryOpen(string category)
        {
            return context.Questions.Where(q => q.Category == category && !q.IsOpen).ToListAsync();
        }

        public Task<List<UserAnswer>> GetUserAnswers()
        {
            return context.UserAnswers.ToListAsync();
        }

        public Task<List<Answer>> GetUserAnswersByQuestionId(uint id)
        {
            return context.Answers.Where(a => a.QuestionId == id).ToListAsync();
        }

        public Task<List<UserAnswer>> GetUserTestTry(int testTry)
        {
            return context.UserAnswers.Where(t => t.TestTry == testTry).ToListAsync();
        }

        public Profile GetUserByName(string name)
        {
            var profiles = idContext.Users.Where(u => u.UserName == name).ToListAsync();
            var profile = profiles.Result.ElementAt(0);
            return profile;
        }

    }
}
