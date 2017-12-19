using System;
using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    /// Документ, удостоверяющий личность физического лица
    /// </summary>
    [Table("CardID")]
    public class CardID : ModelBase
    {
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных у документа, удостоверяющего личность физического лица.
        /// </summary>
        public long CardIDId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение типа документа, удостоверяющего личность физического лица.
        /// </summary>
        public CardIDType CardIDType { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение cериb документа, удостоверяющего личность физического лица.
        /// </summary>
        public string Series { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение номера документа, удостоверяющего личность физического лица.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение даты выдачи документа, удостоверяющего личность физического лица.
        /// </summary>
        public DateTime? IssueDate { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение органа выдачи документа, удостоверяющего личность физического лица.
        /// </summary>
        public CardIDIssuer CardIDIssuer { get; set; }
    }
}