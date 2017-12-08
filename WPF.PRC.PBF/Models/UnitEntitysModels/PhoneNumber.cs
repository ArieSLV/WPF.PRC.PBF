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
        #region PhoneNumberId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных телефонного номера.
        /// </summary>
        public long PhoneNumberId
        {
            get => GetValue<long>(PhoneNumberIdProperty);
            set => SetValue(PhoneNumberIdProperty, value);
        }

        /// <summary>
        ///     PhoneNumberId property data.
        /// </summary>
        public static readonly PropertyData PhoneNumberIdProperty =
            RegisterProperty<PhoneNumber, long>(model => model.PhoneNumberId);

        #endregion

        #region Value свойство

        /// <summary>
        ///     Получает или устанавливает значение текстового написания телефонного номера.
        /// </summary>
        public string Value
        {
            get => GetValue<string>(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        /// <summary>
        ///     Value property data.
        /// </summary>
        public static readonly PropertyData ValueProperty = RegisterProperty<PhoneNumber, string>(model => model.Value);

        #endregion

        #region Type свойство

        /// <summary>
        ///     Получает или устанавливает значение типа контакта.
        /// </summary>
        public ContactType Type
        {
            get => GetValue<ContactType>(TypeProperty);
            set => SetValue(TypeProperty, value);
        }

        /// <summary>
        ///     Type property data.
        /// </summary>
        public static readonly PropertyData TypeProperty =
            RegisterProperty<PhoneNumber, ContactType>(model => model.Type);

        #endregion

        #region Comment свойство

        /// <summary>
        ///     Получает или устанавливает значение коментария к телефонному номеру.
        /// </summary>
        public string Comment
        {
            get => GetValue<string>(CommentProperty);
            set => SetValue(CommentProperty, value);
        }

        /// <summary>
        ///     Comment property data.
        /// </summary>
        public static readonly PropertyData CommentProperty =
            RegisterProperty<PhoneNumber, string>(model => model.Comment);

        #endregion
    }
}