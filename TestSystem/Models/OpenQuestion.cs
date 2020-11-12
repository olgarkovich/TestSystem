using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class OpenQuestion : Question
    {
        public string RightAnswer { get; set; }
        public string Choice { get; set; } //user input
    }
}
