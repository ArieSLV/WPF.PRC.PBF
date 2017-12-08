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
        #region CardIDId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных у документа, удостоверяющего личность физического лица.
        /// </summary>
        public long CardIDId
        {
            get => GetValue<long>(CardIDIdProperty);
            set => SetValue(CardIDIdProperty, value);
        }

        /// <summary>
        ///     CardIDId property data.
        /// </summary>
        public static readonly PropertyData CardIDIdProperty = RegisterProperty<CardID, long>(model => model.CardIDId);

        #endregion
        
        #region CardIDType свойство

        /// <summary>
        ///     Получает или устанавливает значение типа документа, удостоверяющего личность физического лица.
        /// </summary>
        public CardIDType CardIDType
        {
            get => GetValue<CardIDType>(CardIDTypeProperty);
            set => SetValue(CardIDTypeProperty, value);
        }

        /// <summary>
        ///     CardIDType property data.
        /// </summary>
        public static readonly PropertyData CardIDTypeProperty =
            RegisterProperty<CardID, CardIDType>(model => model.CardIDType);

        #endregion
        
        #region Series свойство

        /// <summary>
        ///     Получает или устанавливает значение cериb документа, удостоверяющего личность физического лица.
        /// </summary>
        public string Series
        {
            get => GetValue<string>(SeriesProperty);
            set => SetValue(SeriesProperty, value);
        }

        /// <summary>
        ///     Series property data.
        /// </summary>
        public static readonly PropertyData SeriesProperty = RegisterProperty<CardID, string>(model => model.Series);

        #endregion
        
        #region Number свойство

        /// <summary>
        ///     Получает или устанавливает значение номера документа, удостоверяющего личность физического лица.
        /// </summary>
        public string Number
        {
            get => GetValue<string>(NumberProperty);
            set => SetValue(NumberProperty, value);
        }

        /// <summary>
        ///     Number property data.
        /// </summary>
        public static readonly PropertyData NumberProperty = RegisterProperty<CardID, string>(model => model.Number);

        #endregion

        #region IssueDate свойство

        /// <summary>
        ///     Получает или устанавливает значение даты выдачи документа, удостоверяющего личность физического лица.
        /// </summary>
        public DateTime? IssueDate
        {
            get => GetValue<DateTime?>(IssueDateProperty);
            set => SetValue(IssueDateProperty, value);
        }

        /// <summary>
        ///     IssueDate property data.
        /// </summary>
        public static readonly PropertyData IssueDateProperty =
            RegisterProperty<CardID, DateTime?>(model => model.IssueDate);

        #endregion
        
        #region CardIDIssuer свойство

        /// <summary>
        ///     Получает или устанавливает значение органа выдачи документа, удостоверяющего личность физического лица.
        /// </summary>
        public CardIDIssuer CardIDIssuer
        {
            get => GetValue<CardIDIssuer>(CardIDIssuerProperty);
            set => SetValue(CardIDIssuerProperty, value);
        }

        /// <summary>
        ///     CardIDIssuer property data.
        /// </summary>
        public static readonly PropertyData CardIDIssuerProperty =
            RegisterProperty<CardID, CardIDIssuer>(model => model.CardIDIssuer);

        #endregion
    }
}