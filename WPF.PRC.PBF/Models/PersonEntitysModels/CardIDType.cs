using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    /// Тип документа, удостоверяющего личность физического лица
    /// </summary>
    [Table("CardIDTypes")]
    public class CardIDType : ModelBase
    {
        #region CardIDTypeId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных типа документа, удостоверяющего личность физического лица.
        /// </summary>
        public long CardIDTypeId
        {
            get => GetValue<long>(CardIDTypeIdProperty);
            set => SetValue(CardIDTypeIdProperty, value);
        }

        /// <summary>
        ///     CardIDTypeId property data.
        /// </summary>
        public static readonly PropertyData CardIDTypeIdProperty =
            RegisterProperty<CardIDType, long>(model => model.CardIDTypeId);

        #endregion
        
        #region Value свойство

        /// <summary>
        ///     Получает или устанавливает значение наименования типа документа, удостоверяющего личность физического лица.
        /// </summary>
        public string Value
        {
            get => GetValue<string>(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        /// <summary>
        ///     Value property data.
        /// </summary>
        public static readonly PropertyData ValueProperty = RegisterProperty<CardIDType, string>(model => model.Value);

        #endregion
        
        /// <summary>
        ///     Явное уазание текстового представления типа документа, удостоверяющего личность физического лица
        /// </summary>
        public override string ToString() => Value;
        public override bool Equals(object obj) => (obj as CardIDType)?.CardIDTypeId == CardIDTypeId;
        public override int GetHashCode() => base.GetHashCode();
    }
}