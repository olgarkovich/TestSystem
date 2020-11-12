using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public abstract class Question
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Task{ get; set; } 
        public int Weight { get; set; }
        public string Category { get; set; }
    }
}
