using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp
{
    /// <summary>
    /// Вопрос тестирования
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Уникальный индентификатор
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string QuesionTitle { get; set; }

        /// <summary>
        /// Балл за правильный ответ на вопрос
        /// </summary>
        public int Mark { get; set; }

        /// <summary>
        /// Признак тренировочного вопроса
        /// </summary>
        public bool isTren { get; set; }
        
        /// <summary>
        /// Теория по вопросу
        /// </summary>
        public Theory TheoryOfQuestion { get; set; }
        
        /// <summary>
        /// Категория вопроса
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Список ответов на вопрос
        /// </summary>
        public ICollection<Answer> Answers { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Question() { Answers = new List<Answer>(); }
    }
}
