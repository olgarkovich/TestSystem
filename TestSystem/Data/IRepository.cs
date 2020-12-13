using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Models;

namespace TestSystem.Data
{
    public interface IRepository
    {
        Task<List<Question>> GetAllQuestions();
        Task<List<Answer>> GetAllAnswers();
        Task<List<UserAnswer>> GetUserTestTry(int testTry);
        Task<List<Answer>> GetUserAnswersByQuestionId(uint id);
        Task<List<UserAnswer>> GetUserAnswers();
        Task AddUserAnswer(UserAnswer userAnswer);
        Task<List<Question>> GetQuestionsByCategoryOpen(string category);
        List<Message> GetAllMessages();
        Task<Profile> GetUserByNameAsync(string name);
    }
}
