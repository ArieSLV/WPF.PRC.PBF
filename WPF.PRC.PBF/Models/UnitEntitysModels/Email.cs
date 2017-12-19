using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <inheritdoc />
    /// <summary>
    ///     Адрес электронной почты
    /// </summary>
    [Table("Emails")]
    public class Email : ModelBase
    {
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных адреса электронной почты.
        /// </summary>
        public long EmailId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение текстового написания адреса электронной почты.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение типа контакта.
        /// </summary>
        public ContactType Type { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение коментария к адресу электронной почты.
        /// </summary>
        public string Comment { get; set; }
    }
}