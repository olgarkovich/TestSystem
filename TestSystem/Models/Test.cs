using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CloseQuestion> CloseQuestions { get; set; }
        public List<OpenQuestion> OpenQuestions { get; set; }
    }
}
