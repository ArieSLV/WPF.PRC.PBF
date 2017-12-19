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
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных типа документа, удостоверяющего личность физического лица.
        /// </summary>
        public long CardIDTypeId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение наименования типа документа, удостоверяющего личность физического лица.
        /// </summary>
        public string Value { get; set; }
        
        /// <summary>
        ///     Явное уазание текстового представления типа документа, удостоверяющего личность физического лица
        /// </summary>
        public override string ToString() => Value;
        public override bool Equals(object obj) => (obj as CardIDType)?.CardIDTypeId == CardIDTypeId;
        public override int GetHashCode() => base.GetHashCode();
    }
}