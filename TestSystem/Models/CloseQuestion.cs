using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class CloseQuestion : Question
    {
        public List<string> WrongAnswer { get; set; }
        public List<string> RightAnswer { get; set; }
        public int Points { get; set; }
        public List<string> Choice { get; set; }
    }
}
