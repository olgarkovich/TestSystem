using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Data;

namespace TestSystem.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (!context.Questions.Any())
                {

                    context.Questions.AddRange(
                        new Question
                        {
                            Task = "Пишется а на месте пропуска в словах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Task = "Пишется е на месте всех пропусков в рядах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Task = "Двойные согласные пишутся в словах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Task = "Пишется о на месте пропуска в словах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },
                        new Question
                        {
                            Task = "Укажите ряды, в которых на месте двух пропусков пишется одна и та же буква:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Task = "Пишется е на месте всех пропусков в рядах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },
                        new Question
                        {
                            Task = "Пишется e на месте пропуска в словах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Task = "Пишется НН на месте всех пропусков в рядах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },
                        new Question
                        {
                            Task = "Пишется не раздельно во всех случаях в рядах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Task = "Через дефис пишутся слова:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Task = "Раздельно пишутся выделенные слова в предложениях:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        }
                    );

                }

                if (!context.Answers.Any())
                {
                    context.Answers.AddRange(
                        new Answer
                        {
                            TextAnswer = "заб_влять",
                            QuestionId = 1,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "к_нтинент",
                            QuestionId = 1,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "оз_рить",
                            QuestionId = 1,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "обн_влённый",
                            QuestionId = 1,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "выр_щенный",
                            QuestionId = 1,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "ж_мчужина",
                            QuestionId = 2,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "сост_зание",
                            QuestionId = 2,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "щ_бетание",
                            QuestionId = 2,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "увл_каться",
                            QuestionId = 2,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "уб_раю на кухне",
                            QuestionId = 2,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "о(т/тт)аять",
                            QuestionId = 3,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "диску(с/сс)ия",
                            QuestionId = 3,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "при(м/мм)итивный",
                            QuestionId = 3,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "ра(с/сс)писать",
                            QuestionId = 3,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "дива(н/нн)ый",
                            QuestionId = 3,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "щ_лкать орехи",
                            QuestionId = 4,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "держать в еж_вых рукавицах",
                            QuestionId = 4,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "запеч_м",
                            QuestionId = 4,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "со скрипач_м",
                            QuestionId = 4,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "прож_рливый",
                            QuestionId = 4,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "меж_языковой, фел_етон",
                            QuestionId = 5,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "с_грать, пред_дущий",
                            QuestionId = 5,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "он смуглолиц_й, иниц_атор",
                            QuestionId = 5,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "без_скусный, меж_здательский",
                            QuestionId = 5,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "ударить наотмаш_, обжеч_ся",
                            QuestionId = 5,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "в этой речк_, овраж_к",
                            QuestionId = 6,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "на голубеющ_м небосвод_",
                            QuestionId = 6,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "из-за робост_, этот добровол_ц",
                            QuestionId = 6,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "минувш_м днём, пугов_чка",
                            QuestionId = 6,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "упрекать в слабоволи_, ландыш_вый",
                            QuestionId = 6,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "он удерж_т",
                            QuestionId = 7,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "ты рассерд_шься",
                            QuestionId = 7,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "подкле_вший обложку",
                            QuestionId = 7,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "возгора_мый",
                            QuestionId = 7,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "изъезж_нная колея",
                            QuestionId = 7,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "маринова_ый чеснок, коше_ый на рассвете луг",
                            QuestionId = 8,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "комната освеще_а лампой, скова_ые движения",
                            QuestionId = 8,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "имени_ик, горячие варе_ики",
                            QuestionId = 8,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "бараба_ый стук, растеря_ый вид",
                            QuestionId = 8,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "говорить увере_о, редакцио_ый отдел",
                            QuestionId = 8,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "крайне (не)убедительный аргумент; (не)оглядываться",
                            QuestionId = 9,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "(не)отличающийся качеством; (не)слушая учителя",
                            QuestionId = 9,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "весьма (не)простая задача; (не)раздражающий свет",
                            QuestionId = 9,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "(не)опасное, но неприятное заболевание; мыслить (не)зависимо",
                            QuestionId = 9,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "это (не)почтительность, а лесть; нарциссы (не)высажены",
                            QuestionId = 9,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "(буржуазно)помещичий",
                            QuestionId = 10,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "(био)сфера",
                            QuestionId = 10,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "(горно)лыжный",
                            QuestionId = 10,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "(пол)апельсина",
                            QuestionId = 10,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "гулять (по)вечернему саду",
                            QuestionId = 10,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "(В)виду опасности обрушения стены работу прекратили",
                            QuestionId = 11,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "Организм ослаблен (в)следствие перенесённой болезни",
                            QuestionId = 11,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "Дорога то взлетала (в)высь, то опускалась в овраг",
                            QuestionId = 11,
                            IsRight = false
                        },

                        new Answer
                        {
                            TextAnswer = "Что (бы) там ни говорили, а вопрос надо решать, и немедленно",
                            QuestionId = 11,
                            IsRight = true
                        },

                        new Answer
                        {
                            TextAnswer = "Она танцевала так (же) легко и грациозно, как и десять лет назад",
                            QuestionId = 11,
                            IsRight = true
                        }

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
