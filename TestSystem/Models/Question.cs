using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public abstract class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Task{ get; set; } 
        public int Weight { get; set; }
        public string Theme { get; set; }
    }
}
