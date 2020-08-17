using System.Data.Entity;

namespace TestApp
{
    /// <summary>
    /// База данных
    /// </summary>
    public class TestContext : DbContext
    {
        /// <summary>
        /// Инициализация
        /// </summary>
        static TestContext()
        {
            Database.SetInitializer<TestContext>(new TestContextInitializer());
        }

        /// <summary>
        /// Подключение
        /// </summary>
        public TestContext()
            : base("TestAppDBConnectionString")
        { }

        /// <summary>
        /// Список хранимых категорий
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Список хранимых наборов
        /// </summary>
        public DbSet<CategorySet> CategorySet { get; set; }

        /// <summary>
        /// Список хранимых ответов
        /// </summary>
        public DbSet<Answer> Answers { get; set; }

        /// <summary>
        /// Список хранимых вопросов
        /// </summary>
        public DbSet<Question> Questions { get; set; }

        /// <summary>
        /// Список хранимой теории
        /// </summary>
        public DbSet<Theory> Theories { get; set; }
    }
}
