﻿using System;
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
        public string Category { get; set; }
        public List<uint> UserChoices { get; set; }

        public Test() { }

        public Test(int id, string name, string category)
        {
            Id = id;
            Name = name;
            Category = category;
        }

        //public Test(Test test)
        //{
        //    Id = test.Id;
        //    Name = test.Name;
        //    CloseQuestions = test.CloseQuestions;
        //    OpenQuestions = test.OpenQuestions;
        //    Category = test.Category;
        //}

        //public List<uint> createAnswers(Test test)
        //{
        //    foreach (CloseQuestion cl in test.CloseQuestions)
        //    {
        //        foreach(Answer a in cl.Answers)
        //        {
        //            if (a.IsChecked)
        //            {
        //                UserChoices.Add(a.Id);
        //            }
        //        }
        //    }
        //    return UserChoices;
        //}

    }

    //public enum CategoryEnum
    //{
    //    Spelling = 1,
    //    Punctuation,
    //    Syntax,
    //    Morphology,
    //    Lexis
    //}
}
