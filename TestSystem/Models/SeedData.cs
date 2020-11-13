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
                            Task = "Укажите синонимы к фразеологизму за тридевять земель:",
                            Weight = 1,
                            Category = "Лексика",
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
                            TextAnswer = "на краю света",
                            QuestionId = 21,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 102,
                            TextAnswer = "у чёрта на куличках",
                            QuestionId = 21,
                            IsRight = true
                        },

                        new Answer
                        {
                            Id = 103,
                            TextAnswer = "куда ни поверни",
                            QuestionId = 21,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 104,
                            TextAnswer = "света белого не видеть",
                            QuestionId = 21,
                            IsRight = false
                        },

                        new Answer
                        {
                            Id = 105,
                            TextAnswer = "куда Макар телят не гонял",
                            QuestionId = 21,
                            IsRight = true
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
                        }

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
