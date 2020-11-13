using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class Question
    {
        [Key]
        public uint Id { get; set; }
        public string Task{ get; set; } 
        public int Weight { get; set; }
        public string Category { get; set; }
        public bool IsOpen { get; set; }
    }
}
