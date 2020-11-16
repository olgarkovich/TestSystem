using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.Models
{
    public class UserAnswer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        public uint UserId { get; set; }
        public uint QuestionId { get; set; }
        public string Answer { get; set; }
        public int TestTry { get; set; }

        public UserAnswer(uint userId, uint questionId, string answer, int testTry)
        {
            UserId = userId;
            QuestionId = questionId;
            Answer = answer;
            TestTry = testTry;
        }
    }
}
