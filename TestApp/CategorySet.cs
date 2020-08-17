using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp
{
    public class CategorySet
    {
        /// <summary>
        /// Уникальный индентификатор
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Текущая категория
        /// </summary>
        public virtual Category Current { get; set; }

        /// <summary>
        /// Другая категория
        /// </summary>
        public virtual Category Other { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public string Type { get; set; }
    }
}
