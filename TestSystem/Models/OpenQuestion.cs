using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class OpenQuestion : Question
    {
        public Answer RightAnswer { get; set; }
        public Answer Choice { get; set; } //user input
    }
}
