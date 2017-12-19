using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     Телефонный номер
    /// </summary>
    [Table("PhoneNumbers")]
    public class PhoneNumber : ModelBase
    {
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных телефонного номера.
        /// </summary>
        public long PhoneNumberId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение текстового написания телефонного номера.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение типа контакта.
        /// </summary>
        public ContactType Type { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение коментария к телефонному номеру.
        /// </summary>
        public string Comment { get; set; }
    }
}