using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp
{
    /// <summary>
    /// Возможный ответ на вопрос тестирования
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Уникальный индентификатор
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Текст ответа
        /// </summary>
        public string AnswerTitle { get; set; }

        /// <summary>
        /// Правильный ли ответ 
        /// </summary>
        public bool IsTrue { get; set; }

        /// <summary>
        /// Ссылка (внешний ключ) на вопрос 
        /// </summary>
        public Guid QuestionId { get; set; }

        /// <summary>
        /// Вопрос ответа
        /// </summary>
        public Question Question { get; set; }
    }
}
