using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class CloseQuestion : Question
    {
        //public List<Answer> WrongAnswer { get; set; }
        //public List<Answer> RightAnswer { get; set; }
        public List<Answer> Answers { get; set; }
        public int points = 5;//number of options
        //public List<UserAnswer> Choice { get; set; } //user input

        public CloseQuestion() { }

        public CloseQuestion(string task, string category, int weight)
        {
            Task = task;
            Category = category;
            Weight = weight;
        }

        public CloseQuestion(Question question, List<Answer> right, List<Answer> wrong)
        {
            Task = question.Task;
            Category = question.Category;
            Weight = question.Weight;
            IsOpen = question.IsOpen;
        }

        public CloseQuestion(Question question)
        {
            Id = question.Id;
            Task = question.Task;
            Category = question.Category;
            Weight = question.Weight;
            IsOpen = question.IsOpen;
        }
    }
}
