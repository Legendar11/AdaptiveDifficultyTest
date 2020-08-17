using System.Collections.Generic;
using System.Data.Entity;
using System.IO;

namespace TestApp
{
    /// <summary>
    /// Инициализатор базы данных
    /// </summary>
    class TestContextInitializer : DropCreateDatabaseAlways<TestContext>
    {
        /// <summary>
        /// Инициализация базы данных
        /// </summary>
        /// <param name="db">База данных</param>
        protected override void Seed(TestContext db)
        {
            #region Categories
            List<Category> categories = new List<Category>();
            List<CategorySet> categoriesSet = new List<CategorySet>();

            categories.Add(new Category()
            {
                Name = "Easy",
                NextCount = 1,
                PrevCount = 2,
                Coef = 0.7
            });

            categories.Add(new Category()
            {
                Name = "Medium",
                NextCount = 2,
                PrevCount = 2,
                Coef = 1.2
            });

            categories.Add(new Category()
            {
                Name = "Hard",
                NextCount = 2,
                PrevCount = 2,
                Coef = 1.5
            });

            categoriesSet.Add(new CategorySet()
            {
                Current = categories[0],
                Other = categories[1],
                Type = "next"
            });

            categoriesSet.Add(new CategorySet()
            {
                Current = categories[1],
                Other = categories[2],
                Type = "next"
            });

            categoriesSet.Add(new CategorySet()
            {
                Current = categories[1],
                Other = categories[0],
                Type = "prev"
            });

            categoriesSet.Add(new CategorySet()
            {
                Current = categories[2],
                Other = categories[1],
                Type = "prev"
            });

            db.Categories.AddRange(categories);
            db.CategorySet.AddRange(categoriesSet);
            #endregion

            #region Questions

            List<Question> questions = new List<Question>();

            #region Q1
            List<Answer> Q1_A = new List<Answer>() {
                new Answer { AnswerTitle = "Конечный набор правил, который определяет последовательность операций", IsTrue = true },
                new Answer { AnswerTitle = "Система специфических команд", IsTrue = false },
                new Answer { AnswerTitle = "Свободно организованный набор лексем", IsTrue = false },
                new Answer { AnswerTitle = "Интерпретация программы", IsTrue = false }
            };

            db.Answers.AddRange(Q1_A);

            Theory T1 = new Theory { SubjectTitle = "Общие сведения о алгоритмах", Text = File.ReadAllText("TheoryTexts/algorithm.txt") };

            db.Theories.Add(T1);

            questions.Add(new Question
            {
                QuesionTitle = "Что такое алгоритм?",
                Answers = Q1_A,
                TheoryOfQuestion = T1,
                Mark = 1,
                isTren = false,
                Category = categories[0]
            });
            #endregion

            #region Q2
            List<Answer> Q2_A = new List<Answer>() {
                new Answer { AnswerTitle = "Линейный", IsTrue = true },
                new Answer { AnswerTitle = "Цикличный", IsTrue = true },
                new Answer { AnswerTitle = "Рассыпчатый", IsTrue = false },
                new Answer { AnswerTitle = "Компактный", IsTrue = false }
            };

            db.Answers.AddRange(Q2_A);

            Theory T2 = new Theory { SubjectTitle = "Типы алгоритмов", Text = File.ReadAllText("TheoryTexts/types_of_algorithms.txt") };

            db.Theories.Add(T2);

            questions.Add(new Question
            {
                QuesionTitle = "Выберите существующие типы алгоритмов",
                Answers = Q2_A,
                TheoryOfQuestion = T2,
                Mark = 1,
                isTren = false,
                Category = categories[0]
            });
            #endregion

            #region Q3
            List<Answer> Q3_A = new List<Answer>() {
                new Answer { AnswerTitle = "Тот, кто составил алгоритм", IsTrue = false },
                new Answer { AnswerTitle = "Тот, кто успешно выпонил алгоритм", IsTrue = false },
                new Answer { AnswerTitle = "Тот, кто умеет запускать алгоритм", IsTrue = false },
                new Answer { AnswerTitle = "Тот, для кого составлен алгоритм", IsTrue = true }
            };

            db.Answers.AddRange(Q3_A);

            Theory T3 = new Theory { SubjectTitle = "Исполнитель алгоритмов", Text = File.ReadAllText("TheoryTexts/worker.txt") };

            db.Theories.Add(T3);

            questions.Add(new Question
            {
                QuesionTitle = "Кто такой исполнитель алгорима?",
                Answers = Q3_A,
                TheoryOfQuestion = T3,
                Mark = 1,
                isTren = false,
                Category = categories[0]
            });
            #endregion

            #region Q4
            List<Answer> Q4_A = new List<Answer>() {
                new Answer { AnswerTitle = "Снизу-вверх", IsTrue = true },
                new Answer { AnswerTitle = "Сверху-вниз", IsTrue = true },
                new Answer { AnswerTitle = "Круговой", IsTrue = false },
                new Answer { AnswerTitle = "Хаотичный", IsTrue = false }
            };

            db.Answers.AddRange(Q4_A);

            Theory T4 = new Theory { SubjectTitle = "Вспомогательные алгоритмы", Text = File.ReadAllText("TheoryTexts/in_algorithm.txt") };

            db.Theories.Add(T4);

            questions.Add(new Question
            {
                QuesionTitle = "Какие методы разработки сложных алгоритмов вы знаете?",
                Answers = Q4_A,
                TheoryOfQuestion = T4,
                Mark = 2,
                isTren = false,
                Category = categories[1]
            });
            #endregion

            #region Q5
            List<Answer> Q5_A = new List<Answer>() {
                new Answer { AnswerTitle = "Да", IsTrue = false },
                new Answer { AnswerTitle = "Нет", IsTrue = true }
            };

            db.Answers.AddRange(Q5_A);

            Theory T5 = new Theory { SubjectTitle = "Си-Шарп", Text = File.ReadAllText("TheoryTexts/c_sharp.txt") };

            db.Theories.Add(T5);

            questions.Add(new Question
            {
                QuesionTitle = "C# является алгоритмом?",
                Answers = Q5_A,
                TheoryOfQuestion = T5,
                Mark = 2,
                isTren = false,
                Category = categories[1]
            });
            #endregion

            #region Q6
            List<Answer> Q6_A = new List<Answer>() {
                new Answer { AnswerTitle = "Да", IsTrue = true },
                new Answer { AnswerTitle = "Нет", IsTrue = false }
            };

            db.Answers.AddRange(Q6_A);

            questions.Add(new Question
            {
                QuesionTitle = "C# можем выступать исполнителем алгоритма?",
                Answers = Q6_A,
                TheoryOfQuestion = T5,
                Mark = 2,
                isTren = false,
                Category = categories[1]
            });
            #endregion

            #region Q7
            List<Answer> Q7_A = new List<Answer>() {
                new Answer { AnswerTitle = "Графический", IsTrue = true },
                new Answer { AnswerTitle = "Словесный", IsTrue = true },
                new Answer { AnswerTitle = "Партиционный", IsTrue = false },
                new Answer { AnswerTitle = "Псевдоязык", IsTrue = true }
            };

            db.Answers.AddRange(Q7_A);

            questions.Add(new Question
            {
                QuesionTitle = "Укажите способы описания алгоритма",
                Answers = Q7_A,
                TheoryOfQuestion = T1,
                Mark = 2,
                isTren = false,
                Category = categories[1]
            });
            #endregion

            #region Q8
            List<Answer> Q8_A = new List<Answer>() {
                new Answer { AnswerTitle = "Точность", IsTrue = true },
                new Answer { AnswerTitle = "Понятность", IsTrue = true },
                new Answer { AnswerTitle = "Интерпретационность", IsTrue = false },
                new Answer { AnswerTitle = "Корреляционность", IsTrue = false }
            };

            db.Answers.AddRange(Q8_A);

            questions.Add(new Question
            {
                QuesionTitle = "Укажите важные параметры для алгоритма",
                Answers = Q8_A,
                TheoryOfQuestion = T2,
                Mark = 3,
                isTren = false,
                Category = categories[2]
            });
            #endregion

            #region Q9
            List<Answer> Q9_A = new List<Answer>() {
                new Answer { AnswerTitle = "Да", IsTrue = true },
                new Answer { AnswerTitle = "Нет", IsTrue = false }
            };

            db.Answers.AddRange(Q9_A);

            questions.Add(new Question
            {
                QuesionTitle = "Работающая программа реализует собой некоторый алгоритм?",
                Answers = Q9_A,
                TheoryOfQuestion = T1,
                Mark = 3,
                isTren = false,
                Category = categories[2]
            });
            #endregion

            #region Q10
            List<Answer> Q10_A = new List<Answer>() {
                new Answer { AnswerTitle = "Да", IsTrue = true },
                new Answer { AnswerTitle = "Нет", IsTrue = false }
            };

            db.Answers.AddRange(Q10_A);

            questions.Add(new Question
            {
                QuesionTitle = "Можно ли обмануть данный тест, используя некий алгоритм?",
                Answers = Q10_A,
                TheoryOfQuestion = T1,
                Mark = 3,
                isTren = false,
                Category = categories[2]
            });
            #endregion

            #region T1
            List<Answer> T1_A = new List<Answer>() {
                new Answer { AnswerTitle = "Смена цветов на сфетофоре", IsTrue = true },
                new Answer { AnswerTitle = "Создание картины", IsTrue = false },
                new Answer { AnswerTitle = "Вселенские процессы", IsTrue = false },
                new Answer { AnswerTitle = "Фрактальные снежинки", IsTrue = false }
            };

            db.Answers.AddRange(T1_A);

            questions.Add(new Question
            {
                QuesionTitle = "Что можно представить в виде алгоритма?",
                Answers = T1_A,
                TheoryOfQuestion = T1,
                Mark = 1,
                isTren = true
            });
            #endregion

            #region T2
            List<Answer> T2_A = new List<Answer>() {
                new Answer { AnswerTitle = "Алхимик, конструирующий реактив", IsTrue = false },
                new Answer { AnswerTitle = "Музыкант, играющий по нотной грамоте", IsTrue = true },
                new Answer { AnswerTitle = "Начальник с указаниями о необходимых действиях", IsTrue = false },
                new Answer { AnswerTitle = "Импровизирующий оратор", IsTrue = false }
            };

            db.Answers.AddRange(T2_A);

            questions.Add(new Question
            {
                QuesionTitle = "Кто здесь является исполнителем алгоритма?",
                Answers = T2_A,
                TheoryOfQuestion = T3,
                Mark = 1,
                isTren = true
            });
            #endregion

            #region T3
            List<Answer> T3_A = new List<Answer>() {
                new Answer { AnswerTitle = "Нужность(необходимость) алгоритма", IsTrue = false },
                new Answer { AnswerTitle = "Коммерческую ценность алгоритма", IsTrue = false },
                new Answer { AnswerTitle = "Распространенность алгоритма", IsTrue = false },
                new Answer { AnswerTitle = "Трудоемкость алгоритма", IsTrue = true }
            };

            db.Answers.AddRange(T3_A);

            questions.Add(new Question
            {
                QuesionTitle = "При построении алгоритма необходимо учитывать...",
                Answers = T3_A,
                TheoryOfQuestion = T1,
                Mark = 1,
                isTren = true
            });
            #endregion

            db.Questions.AddRange(questions);
            #endregion

            db.SaveChanges();
        }
    }
}
