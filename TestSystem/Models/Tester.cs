using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class Tester
    {
        public int UserId { get; set; }
        public Profile TestedUser { get; set; }

        public Test CurrentTest { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTest { get; set; }

        [DataType(DataType.Time)]
        public DateTime TestTime { get; set; }
        public int Result { get; set; }
    }
}
