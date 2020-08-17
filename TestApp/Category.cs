using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp
{
    /// <summary>
    /// Категории
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Уникальный индентификатор
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Коэффицент счета
        /// </summary>
        public double Coef { get; set; }

        /// <summary>
        /// Количество вопросов для перехода на следующую
        /// </summary>
        public int NextCount { get; set; }

        /// <summary>
        /// Количество вопросов для перехода на предыдущую
        /// </summary>
        public int PrevCount { get; set; }

        /// <summary>
        /// Вопросы категории
        /// </summary>
        public ICollection<Question> Questions { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Category() { Questions = new List<Question>(); }
    }
}
