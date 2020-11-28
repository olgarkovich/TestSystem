using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class CloseQuestion : Question
    {
        public List<Answer> Answers { get; set; }

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
