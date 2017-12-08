using Catel.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPF.PRC.PBF
{
    public enum SecuritiesTypes
    {
        /// <summary>
        /// Акция обыкновенная именная
        /// </summary>
        [StringValue("Акция обыкновенная именная")]
        SimpleShare,

        /// <summary>
        /// Акция привилегированная именная типа А
        /// </summary>
        [StringValue("Акция привилегированная именная типа А")]
        PreferredTypaAShare,

        /// <summary>
        /// Акция привилегированная именная
        /// </summary>
        [StringValue("Акция привилегированная именная")]
        PreferredShare,

        Unknown
    }

    /// <summary>
    /// Выпуск ценных бумаг
    /// </summary>
    [Table("IssuesOfSecurities")]
    public class IssueOfSecurities :ModelBase
    {
        #region IssueOfSecuritiesId свойство

        /// <summary>
        /// Получает или устанавливает значение ID выпуска ценных бумаг.
        /// </summary>
        public long IssueOfSecuritiesId
        {
            get => GetValue<long>(IssueOfSecuritiesIdProperty);
            set => SetValue(IssueOfSecuritiesIdProperty, value);
        }

        /// <summary>
        /// IssueOfSecuritiesId property data.
        /// </summary>
        public static readonly PropertyData IssueOfSecuritiesIdProperty = RegisterProperty<IssueOfSecurities, long>(model => model.IssueOfSecuritiesId);

        #endregion
        
        #region Type свойство

        /// <summary>
        /// Получает или устанавливает значение типа ценных бумаг.
        /// </summary>
        public SecuritiesTypes Type
        {
            get => GetValue<SecuritiesTypes>(TypeProperty);
            set => SetValue(TypeProperty, value);
        }

        /// <summary>
        /// Type property data.
        /// </summary>
        public static readonly PropertyData TypeProperty = RegisterProperty<IssueOfSecurities, SecuritiesTypes>(model => model.Type);

        #endregion
        
        #region Number свойство

        /// <summary>
        /// Получает или устанавливает значение номера выпуска ценных бумаг.
        /// </summary>
        public string Number
        {
            get => GetValue<string>(NumberProperty);
            set => SetValue(NumberProperty, value);
        }

        /// <summary>
        /// Number property data.
        /// </summary>
        public static readonly PropertyData NumberProperty = RegisterProperty<IssueOfSecurities, string>(model => model.Number);

        #endregion
    }
}