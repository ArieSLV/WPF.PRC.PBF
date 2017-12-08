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
        #region CardIDIssuerId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных органа выдачи документа, удостоверяющего личность физического
        ///     лица.
        /// </summary>
        public long CardIDIssuerId
        {
            get => GetValue<long>(CardIDIssuerIdProperty);
            set => SetValue(CardIDIssuerIdProperty, value);
        }

        /// <summary>
        ///     CardIDIssuerId property data.
        /// </summary>
        public static readonly PropertyData CardIDIssuerIdProperty =
            RegisterProperty<CardIDIssuer, long>(model => model.CardIDIssuerId);

        #endregion

        #region Name свойство

        /// <summary>
        ///     Получает или устанавливает значение имени органа выдачи документа, удостоверяющего личность физического лица.
        /// </summary>
        public string Name
        {
            get => GetValue<string>(NameProperty);
            set => SetValue(NameProperty, value);
        }

        /// <summary>
        ///     Name property data.
        /// </summary>
        public static readonly PropertyData NameProperty = RegisterProperty<CardIDIssuer, string>(model => model.Name);

        #endregion

        #region Code свойство

        /// <summary>
        ///     Получает или устанавливает значение кода подразделения органа выдачи документа, удостоверяющего личность
        ///     физического лица.
        /// </summary>
        public string Code
        {
            get => GetValue<string>(CodeProperty);
            set => SetValue(CodeProperty, value);
        }

        /// <summary>
        ///     Code property data.
        /// </summary>
        public static readonly PropertyData CodeProperty = RegisterProperty<CardIDIssuer, string>(model => model.Code);

        #endregion

        /// <summary>
        ///     Явное указание на текстовое представление органа выдачи документа, удостоверяющего личность физического лица
        /// </summary>
        public override string ToString() => string.IsNullOrEmpty(Code) ? Name : $"{Name}, {Code}";
    }
}