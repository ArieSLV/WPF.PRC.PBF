using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     Орган выдачи документа, удостоверяющего личность физического лица
    /// </summary>
    [Table("CardIDIssuers")]
    public class CardIDIssuer : ModelBase
    {
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных органа выдачи документа, удостоверяющего личность физического
        ///     лица.
        /// </summary>
        public long CardIDIssuerId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение имени органа выдачи документа, удостоверяющего личность физического лица.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение кода подразделения органа выдачи документа, удостоверяющего личность
        ///     физического лица.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     Явное указание на текстовое представление органа выдачи документа, удостоверяющего личность физического лица
        /// </summary>
        public override string ToString() => string.IsNullOrEmpty(Code) ? Name : $"{Name}, {Code}";
    }
}