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
        #region EmailId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных адреса электронной почты.
        /// </summary>
        public long EmailId
        {
            get => GetValue<long>(EmailIdProperty);
            set => SetValue(EmailIdProperty, value);
        }

        /// <summary>
        ///     EmailId property data.
        /// </summary>
        public static readonly PropertyData EmailIdProperty = RegisterProperty<Email, long>(model => model.EmailId);

        #endregion

        #region Value свойство

        /// <summary>
        ///     Получает или устанавливает значение текстового написания адреса электронной почты.
        /// </summary>
        public string Value
        {
            get => GetValue<string>(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        /// <summary>
        ///     Value property data.
        /// </summary>
        public static readonly PropertyData ValueProperty = RegisterProperty<Email, string>(model => model.Value);

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
        public static readonly PropertyData TypeProperty = RegisterProperty<Email, ContactType>(model => model.Type);

        #endregion

        #region Comment свойство

        /// <summary>
        ///     Получает или устанавливает значение коментария к адресу электронной почты.
        /// </summary>
        public string Comment
        {
            get => GetValue<string>(CommentProperty);
            set => SetValue(CommentProperty, value);
        }

        /// <summary>
        ///     Comment property data.
        /// </summary>
        public static readonly PropertyData CommentProperty = RegisterProperty<Email, string>(model => model.Comment);

        #endregion
    }
}