using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class OpenQuestion : Question
    {
        public Answer RightAnswer { get; set; }
        public string Choice { get; set; } //user input

        public OpenQuestion() { }
        public OpenQuestion (Question question)
        {
            Id = question.Id;
            Task = question.Task;
            Weight = question.Weight;
            Category = question.Category;
            IsOpen = question.IsOpen;
        }
    }
}
