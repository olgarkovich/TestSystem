using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class Answer
    {
        [Key]
        public uint Id { get; set; }
        public string TextAnswer { get; set; }
        public bool IsRight { get; set; }
        public uint QuestionId { get; set; } 
        public bool IsChecked { get; set; }
    }
}
