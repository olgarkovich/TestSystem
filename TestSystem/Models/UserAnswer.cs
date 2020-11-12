using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class UserAnswer
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint QuestionId { get; set; }
        public string Answer { get; set; }
    }
}
