using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class Tester
    {
        public User TestedUser { get; set; }
        public Test CurrentTest { get; set; }
        public DateTime StartTest { get; set; }
        public DateTime TestTime { get; set; }
        public int Result { get; set; }
    }
}
