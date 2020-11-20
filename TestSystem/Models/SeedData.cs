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
                            Id = 1,
                            Task = "Пишется а на месте пропуска в словах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 2,
                            Task = "Пишется е на месте всех пропусков в рядах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 3,
                            Task = "Двойные согласные пишутся в словах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 4,
                            Task = "Пишется о на месте пропуска в словах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 5,
                            Task = "Укажите ряды, в которых на месте двух пропусков пишется одна и та же буква:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 6,
                            Task = "Пишется е на месте всех пропусков в рядах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 7,
                            Task = "Пишется e на месте пропуска в словах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 8,
                            Task = "Пишется НН на месте всех пропусков в рядах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 9,
                            Task = "Пишется не раздельно во всех случаях в рядах:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 10,
                            Task = "Через дефис пишутся слова:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 11,
                            Task = "Раздельно пишутся выделенные слова в предложениях:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 12,
                            Task = "Тире на месте пропуска обязательно ставится в предложениях:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 13,
                            Task = "Какие предложения соответствуют данной схеме (учтите, что в предложениях знаки препинания не расставлены)?\n[… сущ., [причастный оборот), … ].",
                            Weight = 1,
                            Category = "Синтаксис",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 14,
                            Task = "Укажите предложения, в которых выделенные слова (словосочетания) являются вводными (учтите, что знаки препинания в предложениях не расставлены):",
                            Weight = 1,
                            Category = "Синтаксис",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 15,
                            Task = "Запятая на месте всех пропусков ставится в предложениях:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 16,
                            Task = "Знаки препинания расставлены правильно в предложениях:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 17,
                            Task = "Укажите бессоюзные сложные предложения, в которых на месте пропуска ставится двоеточие, так как вторая часть называет причину, основание того, о чём говорится в первой части:",
                            Weight = 1,
                            Category = "Синтаксис",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 18,
                            Task = "Укажите предложения с правильным пунктуационным оформлением чужой речи:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 19,
                            Task = "Запятая ставится на месте всех пропусков в предложениях:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 20,
                            Task = "Укажите номера пропусков, на месте которых нужно поставить запятую:\nВесь день на улице пекло 1)_ и 2)_ хотя солнце уже стояло в нескольких метрах от горизонта, было очевидно 3)_ нестерпимый зной 4)_ уничтожая последние капли влаги 5)_ не спадёт и к вечеру.",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 21,
                            Task = "Запятая ставится на месте всех пропусков в предложениях:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 22,
                            Task = "Какие морфологические признаки соответствуют выделенному в предложении имени существительному?\nВаля никак не могла запомнить его <имя>.",
                            Weight = 1,
                            Category = "Морфология",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 23,
                            Task = "Верными являются утверждения:",
                            Weight = 1,
                            Category = "Морфология",
                            IsOpen = false
                        },

                        new Question
                        {
                            Id = 24,
                            Task = "Речевые нормы нарушены в предложениях:",
                            Weight = 1,
                            Category = "Морфология",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 25,
                            Task = "Синтаксические нормы нарушены в предложениях:",
                            Weight = 1,
                            Category = "Синтаксис",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 26,
                            Task = "Пишется а на месте пропусков:",
                            Weight = 1,
                            Category = "Орфография",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 27,
                            Task = "Тире на месте пропуска обязательно ставится в предложениях:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 28,
                            Task = "Запятая ставится на месте всех пропусков в рядах:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 29,
                            Task = "Знаки препинания расставлены правильно в предложениях:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 30,
                            Task = "Какие морфологические признаки соответствуют выделенному в предложении имени существительному?\nНа место происшествия прибыл <отряд> спасателей.",
                            Weight = 1,
                            Category = "Морфология",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 31,
                            Task = "Знаки препинания расставлены правильно:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 32,
                            Task = "Укажите предложения с правильным пунктуационным оформлением чужой речи.",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 33,
                            Task = "Запятая ставится на месте всех пропусков в предложениях:",
                            Weight = 1,
                            Category = "Пунктуация",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 34,
                            Task = "Верными являются утверждения:",
                            Weight = 1,
                            Category = "Морфология",
                            IsOpen = false
                        },
                        new Question
                        {
                            Id = 35,
                            Task = "Определите морфемный состав слов и установите соответствие между столбцами таблицы:\n\nА.оформление\nБ.по - деревенски\nВ.мыслитель\nГ.заварочный\n\n1.корень + суффикс + суффикс\n2.корень + суффикс + суффикс + окончание\n3.приставка + корень + суффикс + суффикс\n4.приставка + корень + суффикс + окончание\n5.приставка + корень + суффикс + суффикс + окончание",
                            Weight = 2,
                            Category = "Морфология",
                            IsOpen = true
                        },
                        new Question
                        {
                            Id = 36,
                            Task = "Установите соответствие между выделенными словами и их характеристикой:\n\nА.<Наперекор> всем невзгодам я был бодр и весел.\nБ.Таня хотела знать, приду <ли> я на репетицию.\n\nВ.В отвесной скале, <куда> вёл мост, виднелось несколько больших пещер.\nГ.<Только> река шумит да стучат камни, уносимые водой.\n\n1.наречие\n2.предлог\n3.частица\n4.союз\n5.местоимение",
                            Weight = 2,
                            Category = "Морфология",
                            IsOpen = true
                        },
                        new Question
                        {
                            Id = 37,
                            Task = "Установите соответствие между предложениями и их характеристикой:\n\nA.Как полагают разработчики закона, экологическая безопасность — важное направление государственной деятельности.\nБ.Свет в доме я нарочно не погасил, и освещённое окно было хорошо видно, пока я спускался по тропинке к реке.\nB.Как образовалась Земля и является ли она единственной на - селённой планетой ?\nГ.Когда он, сидя на камне у горной реки, следил за полётом ласточек, скользящих крылом по воде, или прислушивался к жужжанию пчёл, на душе становилось легко и ясно.\n\n1.простое осложнённое предложение\n2.сложносочинённое предложение\n3.сложноподчинённое предложение\n4.бессоюзное сложное предложение\n5.сложное предложение с разными видами связи",
                            Weight = 2,
                            Category = "Синтаксис",
                            IsOpen = true
                        },
                        new Question
                        {
                            Id = 38,
                            Task = "В данном ниже предложении допущена орфографическая ошибка. Найдите слово с ошибкой и запишите его в область ответов в исправленном виде (в той форме, в которой оно употреблено в тексте).\n\nПодобно большому художнику, природа не растрачивает своих чудесных красок на какую - нибудь одну картину, чтобы затем бесконечно повторять себя; все её картины отличаются целосностью и неповторимостью.",
                            Weight = 2,
                            Category = "Орфография",
                            IsOpen = true
                        },
                        new Question
                        {
                            Id = 39,
                            Task = "В данном ниже предложении допущено нарушение морфологической нормы. Найдите слово с ошибкой и запишите его, исправив, в нужной форме в область ответов.\n\nРазмер этого фрукта колеблется от ста до шестиста граммов.",
                            Weight = 2,
                            Category = "Морфология",
                            IsOpen = true
                        },
                        new Question
                        {
                            Id = 40,
                            Task = "Определите морфемный состав слов и установите соответствие между столбцами таблицы:\n\nА.перегораживавший\nБ.по - честному\nВ.отголосок\nГ.сладостный\n\n1.корень + суффикс + окончание\n2.корень + суффикс + суффикс + окончание\n3.приставка + корень + суффикс + суффикс\n4.приставка + корень + суффикс + окончание\n5.приставка + корень + суффикс + суффикс + окончание",
                            Weight = 2,
                            Category = "Морфология",
                            IsOpen = true
                        },
                        new Question
                        {
                            Id = 41,
                            Task = "Установите соответствие между словами-синонимами:\nА.рубеж\nБ.кавалерия\nВ.баталия\nГ.суверенитет\n\n1.граница\n2.битва, сражение\n3.независимость\n4.гвардия\n5.конница",
                            Weight = 2,
                            Category = "Морфология",
                            IsOpen = true
                        },
                        new Question
                        {
                            Id = 42,
                            Task = "Установите соответствие между выделенными словами и их характеристикой:\nА.Договорившись насчёт завтрашнего дня, они расстались.\nБ.Лиля посмотрела на Никиту и вдруг улыбнулась.\nВ.Только природа всегда совершенна и прекрасна.\nГ.Все гадали, выпадет ли снег к Новому году.\n\n1.наречие\n2.предлог\n3.частица\n4.союз\n5.местоимение",
                            Weight = 2,
                            Category = "Морфология",
                            IsOpen = true
                        },
                        new Question 
                        { 
                            Id = 43,
                            Task = "В данном ниже предложении допущено нарушение морфологической нормы. Найдите слово с ошибкой и запишите его, исправив, в нужной форме в область ответов.\nЛось свободно поднимает вьюк массой до ста килограммов, а в санной упряжке везёт и более четырёхста килограммов.",
                            Weight = 2,
                            Category = "Морфология",
                            IsOpen = true
                        }
                    );

                }

                if (!context.Answers.Any())
                {
                    context.Answers.AddRange(
                        new Answer
                        {
                            Id = 1,
                            TextAnswer = "заб_влять",
                            QuestionId = 1,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 2,
                            TextAnswer = "к_нтинент",
                            QuestionId = 1,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 3,
                            TextAnswer = "оз_рить",
                            QuestionId = 1,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 4,
                            TextAnswer = "обн_влённый",
                            QuestionId = 1,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 5,
                            TextAnswer = "выр_щенный",
                            QuestionId = 1,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 6,
                            TextAnswer = "ж_мчужина",
                            QuestionId = 2,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 7,
                            TextAnswer = "сост_зание",
                            QuestionId = 2,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 8,
                            TextAnswer = "щ_бетание",
                            QuestionId = 2,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 9,
                            TextAnswer = "увл_каться",
                            QuestionId = 2,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 10,
                            TextAnswer = "уб_раю на кухне",
                            QuestionId = 2,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 11,
                            TextAnswer = "о(т/тт)аять",
                            QuestionId = 3,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 12,
                            TextAnswer = "диску(с/сс)ия",
                            QuestionId = 3,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 13,
                            TextAnswer = "при(м/мм)итивный",
                            QuestionId = 3,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 14,
                            TextAnswer = "ра(с/сс)писать",
                            QuestionId = 3,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 15,
                            TextAnswer = "дива(н/нн)ый",
                            QuestionId = 3,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 16,
                            TextAnswer = "щ_лкать орехи",
                            QuestionId = 4,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 17,
                            TextAnswer = "держать в еж_вых рукавицах",
                            QuestionId = 4,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 18,
                            TextAnswer = "запеч_м",
                            QuestionId = 4,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 19,
                            TextAnswer = "со скрипач_м",
                            QuestionId = 4,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 20,
                            TextAnswer = "прож_рливый",
                            QuestionId = 4,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 21,
                            TextAnswer = "меж_языковой, фел_етон",
                            QuestionId = 5,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 22,
                            TextAnswer = "с_грать, пред_дущий",
                            QuestionId = 5,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 23,
                            TextAnswer = "он смуглолиц_й, иниц_атор",
                            QuestionId = 5,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 24,
                            TextAnswer = "без_скусный, меж_здательский",
                            QuestionId = 5,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 25,
                            TextAnswer = "ударить наотмаш_, обжеч_ся",
                            QuestionId = 5,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 26,
                            TextAnswer = "в этой речк_, овраж_к",
                            QuestionId = 6,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 27,
                            TextAnswer = "на голубеющ_м небосвод_",
                            QuestionId = 6,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 28,
                            TextAnswer = "из-за робост_, этот добровол_ц",
                            QuestionId = 6,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 29,
                            TextAnswer = "минувш_м днём, пугов_чка",
                            QuestionId = 6,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 30,
                            TextAnswer = "упрекать в слабоволи_, ландыш_вый",
                            QuestionId = 6,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 31,
                            TextAnswer = "он удерж_т",
                            QuestionId = 7,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 32,
                            TextAnswer = "ты рассерд_шься",
                            QuestionId = 7,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 33,
                            TextAnswer = "подкле_вший обложку",
                            QuestionId = 7,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 34,
                            TextAnswer = "возгора_мый",
                            QuestionId = 7,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 35,
                            TextAnswer = "изъезж_нная колея",
                            QuestionId = 7,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 36,
                            TextAnswer = "маринова_ый чеснок, коше_ый на рассвете луг",
                            QuestionId = 8,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 37,
                            TextAnswer = "комната освеще_а лампой, скова_ые движения",
                            QuestionId = 8,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 38,
                            TextAnswer = "имени_ик, горячие варе_ики",
                            QuestionId = 8,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 39,
                            TextAnswer = "бараба_ый стук, растеря_ый вид",
                            QuestionId = 8,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 40,
                            TextAnswer = "говорить увере_о, редакцио_ый отдел",
                            QuestionId = 8,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 41,
                            TextAnswer = "крайне (не)убедительный аргумент; (не)оглядываться",
                            QuestionId = 9,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 42,
                            TextAnswer = "(не)отличающийся качеством; (не)слушая учителя",
                            QuestionId = 9,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 43,
                            TextAnswer = "весьма (не)простая задача; (не)раздражающий свет",
                            QuestionId = 9,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 44,
                            TextAnswer = "(не)опасное, но неприятное заболевание; мыслить (не)зависимо",
                            QuestionId = 9,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 45,
                            TextAnswer = "это (не)почтительность, а лесть; нарциссы (не)высажены",
                            QuestionId = 9,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 46,
                            TextAnswer = "(буржуазно)помещичий",
                            QuestionId = 10,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 47,
                            TextAnswer = "(био)сфера",
                            QuestionId = 10,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 48,
                            TextAnswer = "(горно)лыжный",
                            QuestionId = 10,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 49,
                            TextAnswer = "(пол)апельсина",
                            QuestionId = 10,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 50,
                            TextAnswer = "гулять (по)вечернему саду",
                            QuestionId = 10,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 51,
                            TextAnswer = "(В)виду опасности обрушения стены работу прекратили",
                            QuestionId = 11,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 52,
                            TextAnswer = "Организм ослаблен (в)следствие перенесённой болезни",
                            QuestionId = 11,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 53,
                            TextAnswer = "Дорога то взлетала (в)высь, то опускалась в овраг",
                            QuestionId = 11,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 54,
                            TextAnswer = "Что (бы) там ни говорили, а вопрос надо решать, и немедленно",
                            QuestionId = 11,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 55,
                            TextAnswer = "Она танцевала так (же) легко и грациозно, как и десять лет назад",
                            QuestionId = 11,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 56,
                            TextAnswer = "Памятник _ это узелок истории, знак взлётов и падений человека и человечества",
                            QuestionId = 12,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 57,
                            TextAnswer = "Дитя _ словно тесто: каким замесили, таким оно и выросло",
                            QuestionId = 12,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 58,
                            TextAnswer = "Удел учителя _ трудиться годы и годы, чтобы увидеть плоды своего труда в характере повзрослевшего ученика",
                            QuestionId = 12,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 59,
                            TextAnswer = "Ни брат, ни сестра, ни отец _ никто из семьи не навестил меня в лагере",
                            QuestionId = 12,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 60,
                            TextAnswer = "Достижение высших добродетелей _ есть цель человека",
                            QuestionId = 12,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 61,
                            TextAnswer = "Даже опытные охотники забывая это правило теряют добычу.",
                            QuestionId = 13,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 62,
                            TextAnswer = "Старинные картины развешанные по стенам казались в жёлтом ламповом свете какими-то отдалёнными и смутными.",
                            QuestionId = 13,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 63,
                            TextAnswer = "Мой дядя всю жизнь начинавший свой рабочий день вместе с природой и в старости продолжал трудиться.",
                            QuestionId = 13,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 64,
                            TextAnswer = "На зелёном берегу поросшем сочной травой мы сделали привал.",
                            QuestionId = 13,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 65,
                            TextAnswer = "Егерь догонял по следу подстреленного мною лося.",
                            QuestionId = 13,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 66,
                            TextAnswer = "Наш приход был очень кстати.",
                            QuestionId = 14,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 67,
                            TextAnswer = "Разговор разумеется будет долгим.",
                            QuestionId = 14,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 68,
                            TextAnswer = "Ветви елей тянутся к вам как будто хотят оставить на память лёгкую царапину.",
                            QuestionId = 14,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 69,
                            TextAnswer = "Солнце и кажется само небо прятались за скалами.",
                            QuestionId = 14,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 70,
                            TextAnswer = "Возможно тебе другое задание дадут.",
                            QuestionId = 14,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 71,
                            TextAnswer = "Мы и исследования провели_ и написали отчёт_ и оформили документы_ и теперь вы можете дать нам отпуск.",
                            QuestionId = 15,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 72,
                            TextAnswer = "Я помню осинник зябкий_ да речушку узкую_ да синий бор_ да жёлтые поля.",
                            QuestionId = 15,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 73,
                            TextAnswer = "Постоянство в отношениях_ и взглядах, чувствах_ и привычках было главным его жизненным принципом.",
                            QuestionId = 15,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 74,
                            TextAnswer = "Накануне праздничного вечера мама отгладила для Артёма пиджак_ и брюки_ и дала ему новую рубашку.",
                            QuestionId = 15,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 75,
                            TextAnswer = "Сейчас во многих странах завтрак_ или обед немыслим без стакана апельсинового_ либо грейпфрутового сока_ или напитка на их основе.",
                            QuestionId = 15,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 76,
                            TextAnswer = "Трава полна прозрачных слёз, и гром вдали гремит раскатом.",
                            QuestionId = 16,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 77,
                            TextAnswer = "Лапы ели были так густы, что, когда Тедди забрался под них, он почти не увидел неба.",
                            QuestionId = 16,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 78,
                            TextAnswer = "Счастливый случай помогает тому кто делает всё, чтобы его не упустить.",
                            QuestionId = 16,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 79,
                            TextAnswer = "Наконец-то во дворе зазеленели палисадники, да акации расцвели.",
                            QuestionId = 16,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 80,
                            TextAnswer = "Пете даже показалось, что всё вокруг потемнело и солнце скрылось в грозовой туче, хотя на самом деле безоблачный полдень продолжал сиять в предгорьях Карпат.",
                            QuestionId = 16,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 81,
                            TextAnswer = "Биться в одиночку_ жизни не перевернуть.",
                            QuestionId = 17,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 82,
                            TextAnswer = "Идти здесь было очень трудно_ мелкий камень осыпи под ногами рассыпался и полз.",
                            QuestionId = 17,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 83,
                            TextAnswer = "Дунул ветер_ всё дрогнуло, ожило и засмеялось.",
                            QuestionId = 17,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 84,
                            TextAnswer = "Трав и цветов мало в большом лесу_ постоянная тень неблагоприятна для растительности.",
                            QuestionId = 17,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 85,
                            TextAnswer = "На другой день проснулся, смотрю_ дед ходит по баштану как ни в чём не бывало и прикрывает лопухом арбузы.",
                            QuestionId = 17,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 86,
                            TextAnswer = "Учительница посмотрела на нас и вдруг спросила: — Ребята, а кто из вас был в этом музее? — Я, —ответил Пашка.",
                            QuestionId = 18,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 87,
                            TextAnswer = "— Думайте сами, — сурово сдвинула брови секретарша: — От вас не диктант требуется написать, а заявление!",
                            QuestionId = 18,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 88,
                            TextAnswer = "«Вы случайно не покупаете лошадей? — спросил Семёнов, но, заметив грозный взгляд жены, прибавил: — Извините, это я так».",
                            QuestionId = 18,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 89,
                            TextAnswer = "По словам одного из философов: «перестав быть спорной, мысль перестаёт быть интересной».",
                            QuestionId = 18,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 90,
                            TextAnswer = "Я крикнул в телефонную трубку: «Бабушка не может подойти!»",
                            QuestionId = 18,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 91,
                            TextAnswer = "Что вы скажете о человеке, который ежедневно отправляется на подвиг_ как ходят на службу?",
                            QuestionId = 19,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 92,
                            TextAnswer = "Это состояние было_ как обморок.",
                            QuestionId = 19,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 93,
                            TextAnswer = "Машина встала_ как вкопанная.",
                            QuestionId = 19,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 94,
                            TextAnswer = "Роман задуман Пушкиным_ как широкая историческая картина.",
                            QuestionId = 19,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 95,
                            TextAnswer = "Вся история Европы в XIX веке есть не что иное_ как история разочарования в рационалистических идеалах XVIII века.",
                            QuestionId = 19,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 96,
                            TextAnswer = "1",
                            QuestionId = 20,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 97,
                            TextAnswer = "2",
                            QuestionId = 20,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 98,
                            TextAnswer = "3",
                            QuestionId = 20,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 99,
                            TextAnswer = "4",
                            QuestionId = 20,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 100,
                            TextAnswer = "5",
                            QuestionId = 20,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 101,
                            TextAnswer = "Капитан в шлюпке оглядывался то на ребёнка_ то на пароход.",
                            QuestionId = 21,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 102,
                            TextAnswer = "После обеда она выходила на балкон или со скрипкой_ или с шитьём_ или с чтением.",
                            QuestionId = 21,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 103,
                            TextAnswer = "День ласковый_ и солнечный_ и легко_ и спокойно на душе.",
                            QuestionId = 21,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 104,
                            TextAnswer = "Сейчас в комнате, украшенной ветками сосны_ и берёзы_ и ели, чинно сидят ожившие с древних картин красавицы.",
                            QuestionId = 21,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 105,
                            TextAnswer = "На клумбе были посажены розы_ и тюльпаны, ноготки_ и какие-то неизвестные никому цветы.",
                            QuestionId = 21,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 106,
                            TextAnswer = "среднего рода",
                            QuestionId = 22,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 107,
                            TextAnswer = "в форме именительного падежа",
                            QuestionId = 22,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 108,
                            TextAnswer = "в форме винительного падежа",
                            QuestionId = 22,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 109,
                            TextAnswer = "в форме единственного числа",
                            QuestionId = 22,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 110,
                            TextAnswer = "второго склонения",
                            QuestionId = 22,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 111,
                            TextAnswer = "Нагинаюсь, нагинался — это правильно образованные формы глагола нагибаться.",
                            QuestionId = 23,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 112,
                            TextAnswer = "В русском языке есть разноспрягаемые глаголы.",
                            QuestionId = 23,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 113,
                            TextAnswer = "В глагольных формах предложить, предложив ударение падает на последний слог.",
                            QuestionId = 23,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 114,
                            TextAnswer = "В предложении Даша попросила его объяснить задачу инфинитив является частью составного глагольного сказуемого.",
                            QuestionId = 23,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 115,
                            TextAnswer = "От глаголов несовершенного вида нельзя образовать деепричастия совершенного вида.",
                            QuestionId = 23,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 116,
                            TextAnswer = "Ежегодно на исследования в области альтернативной энергетики правительством выделяются огромные суммы.",
                            QuestionId = 24,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 117,
                            TextAnswer = "Молодожёнам предоставили двухкомнатную квартиру.",
                            QuestionId = 24,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 118,
                            TextAnswer = "Я хочу получить в банке инвестицию на образование.",
                            QuestionId = 24,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 119,
                            TextAnswer = "Во втором действии комедии действия развиваются интересно и динамично.",
                            QuestionId = 24,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 120,
                            TextAnswer = "В этом деле положительную роль имеет согласие всего коллектива.",
                            QuestionId = 24,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 121,
                            TextAnswer = "Поселившись в деревне, мы с женой посадили перед домом множество цветов.",
                            QuestionId = 25,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 122,
                            TextAnswer = "Скоро ты сам сможешь убедиться в моей правоте.",
                            QuestionId = 25,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 123,
                            TextAnswer = "Мы поинтересуемся и договоримся о месте встречи.",
                            QuestionId = 25,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 124,
                            TextAnswer = "Поддерживаемая дисциплина учениками во время урока — залог их успешной учёбы.",
                            QuestionId = 25,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 125,
                            TextAnswer = "Я шёпотом спросил, что не стоило ли нам сначала представиться.",
                            QuestionId = 25,
                            IsRight = true
                        },
                        new Answer
                        {
                            Id = 126,
                            TextAnswer = "непром_каемый плащ",
                            QuestionId = 26,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 127,
                            TextAnswer = "усл_жнить задачу",
                            QuestionId = 26,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 128,
                            TextAnswer = "п_триот",
                            QuestionId = 26,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 129,
                            TextAnswer = "ур_внение",
                            QuestionId = 26,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 130,
                            TextAnswer = "раск_лить сковородку",
                            QuestionId = 26,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 131,
                            TextAnswer = "Многие думают, что Каракумы _ это только пески, но в пустыне много и плодородной земли.",
                            QuestionId = 27,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 132,
                            TextAnswer = "Электрический свет _ словно жидкий янтарь.",
                            QuestionId = 27,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 133,
                            TextAnswer = "Забота воспитателя _ утвердить в детском сердце чувство любви к матери.",
                            QuestionId = 27,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 134,
                            TextAnswer = "Зелёная трава на улице, шумящая листва на деревьях, солнце над головой _ всё кругом выглядело радостным и привлекательным.",
                            QuestionId = 27,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 135,
                            TextAnswer = "Язык _ есть способ существования мысли.",
                            QuestionId = 27,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 136,
                            TextAnswer = "Я вышел на террасу и_ перегнувшись через перила_ поглядел вниз.",
                            QuestionId = 28,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 137,
                            TextAnswer = "Поздней осенью листья _казавшиеся вырезанными из бронзы _топорщились на ветках кряжистого дуба.",
                            QuestionId = 28,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 138,
                            TextAnswer = "Все_ прилегающие к площади_ улицы были заполнены людьми.",
                            QuestionId = 28,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 139,
                            TextAnswer = "К плоскостям и вертикалям _окружённого с двух сторон небоскрёбами_ проспекта примыкает старая московская улочка.",
                            QuestionId = 28,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 140,
                            TextAnswer = "Дёргающий крыльями _ он не издавал ни звука.",
                            QuestionId = 28,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 141,
                            TextAnswer = "В своих статьях я не пытаюсь объяснить, что такое добро и почему добрый человек внутренне красив.",
                            QuestionId = 29,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 142,
                            TextAnswer = "Ольга рассудила, что, если она поспешит спрятаться в шалаш, то её не заметят и пройдут мимо.",
                            QuestionId = 29,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 143,
                            TextAnswer = "На гладкой воде изредка ходили круги да вздрагивали речные лилии, потревоженные весёлой рыбой.",
                            QuestionId = 29,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 144,
                            TextAnswer = "Писатель должен острее других видеть всё, что его окружает и стараться быть человеком мудрым",
                            QuestionId = 29,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 145,
                            TextAnswer = "Там где дорога кончилась, переходя в глухую тропу, у ног Ассоль завертелась чёрная собака с белой грудью.",
                            QuestionId = 29,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 146,
                            TextAnswer = "мужского рода",
                            QuestionId = 30,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 147,
                            TextAnswer = "в форме именительного падежа",
                            QuestionId = 30,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 148,
                            TextAnswer = "второго склонения",
                            QuestionId = 30,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 149,
                            TextAnswer = "одушевлённое",
                            QuestionId = 30,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 150,
                            TextAnswer = "в форме винительного падежа",
                            QuestionId = 30,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 151,
                            TextAnswer = "Дунул ветер — всё дрогнуло, ожило и засмеялось.",
                            QuestionId = 31,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 152,
                            TextAnswer = "Биться в одиночку: жизни не перевернуть.",
                            QuestionId = 31,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 153,
                            TextAnswer = "Идти здесь было очень трудно, мелкий камень под ногами рассыпался и полз.",
                            QuestionId = 31,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 154,
                            TextAnswer = "На другой день проснулся, смотрю: дед ходит как ни в чём не бывало.",
                            QuestionId = 31,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 155,
                            TextAnswer = "Трав и цветов мало в большом лесу — постоянная тень неблагоприятна для растительности.",
                            QuestionId = 31,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 156,
                            TextAnswer = "«Не помню я, о чём они говорили, — закричал Коля и шёпотом добавил: — С перепугу не помню».",
                            QuestionId = 32,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 157,
                            TextAnswer = "По словам Эпикура: «глупо просить у богов то, что человек сам может себе доставить».",
                            QuestionId = 32,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 158,
                            TextAnswer = "Мальчик снял шапку и поинтересовался: — Дядя, а вы настоящий художник? — Да. А почему ты об этом спрашиваешь? — засмеялся Никитин.",
                            QuestionId = 32,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 159,
                            TextAnswer = "«Ты так убедительно просишь, — сказал Браницкий: — Как будто предчувствуешь отказ».",
                            QuestionId = 32,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 160,
                            TextAnswer = "— Лена, кто там? — донёсся из соседней комнаты приглушённый бас.",
                            QuestionId = 32,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 161,
                            TextAnswer = "Изображения гепардов трактуются на древнеегипетских фресках и барельефах_ как символ храбрости.",
                            QuestionId = 33,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 162,
                            TextAnswer = "Сёстры бросились обниматься_ как будто они не виделись несколько месяцев.",
                            QuestionId = 33,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 163,
                            TextAnswer = "Легенда о великом потопе есть не что иное_ как гипотеза какого-нибудь древнего учёного о способе образования проливов между островами.",
                            QuestionId = 33,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 164,
                            TextAnswer = "Посреди площади, утрамбованной_ как мостовая_ стоит дощатое сооружение.",
                            QuestionId = 33,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 165,
                            TextAnswer = "В Вологде были распространены_ как парная техника плетения кружев_ так и сцепная.",
                            QuestionId = 33,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 166,
                            TextAnswer = "Жжёт, жжёшь — это правильно образованные формы глагола жечь.",
                            QuestionId = 34,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 167,
                            TextAnswer = "Деепричастие имеет признаки глагола и прилагательного.",
                            QuestionId = 34,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 168,
                            TextAnswer = "Инфинитив (неопределённая форма глагола) имеет все постоянные и все непостоянные грамматические признаки, присущие глаголу.",
                            QuestionId = 34,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 169,
                            TextAnswer = "В предложении Ильин не одобрял намерения нового комбата пройтись по окопам инфинитив выполняет функцию несогласованного определения.",
                            QuestionId = 34,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 170,
                            TextAnswer = "В глагольных формах занять, занята ударение падает на первый слог.",
                            QuestionId = 34,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 171,
                            TextAnswer = "А4Б3В2Г5",
                            QuestionId = 35,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 172,
                            TextAnswer = "А2Б4В1Г3",
                            QuestionId = 36,
                            IsRight = true
                        },
                        new Answer
                        {
                            Id = 173,
                            TextAnswer = "А1Б5В2Г3",
                            QuestionId = 37,
                            IsRight = true
                        },
                        new Answer
                        {
                            Id = 174,
                            TextAnswer = "целостностью",
                            QuestionId = 38,
                            IsRight = true
                        },
                        new Answer
                        {
                            Id = 175,
                            TextAnswer = "шестисот",
                            QuestionId = 39,
                            IsRight = true
                        },
                        new Answer
                        {
                            Id = 176,
                            TextAnswer = "А5Б3В4Г2",
                            QuestionId = 40,
                            IsRight = true
                        },
                        new Answer
                        {
                            Id = 177,
                            TextAnswer = "А1Б5В2Г3",
                            QuestionId = 41,
                            IsRight = true
                        },
                        new Answer
                        {
                            Id = 178,
                            TextAnswer = "А2Б1В3Г4",
                            QuestionId = 42,
                            IsRight = true
                        },
                        new Answer
                        {
                            Id = 179,
                            TextAnswer = "четырёхсот",
                            QuestionId = 43,
                            IsRight = true
                        }

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
