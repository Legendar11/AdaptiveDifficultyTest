using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp
{
    /// <summary>
    /// Теоретическая информация
    /// </summary>
    public class Theory
    {
        /// <summary>
        /// Уникальный индентификатор
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Тема
        /// </summary>
        public string SubjectTitle { get; set; }

        /// <summary>
        /// Информация
        /// </summary>
        public string Text { get; set; }
    }
}
