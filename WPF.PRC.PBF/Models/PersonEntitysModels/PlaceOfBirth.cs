using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    /// Место рождения
    /// </summary>
    [Table("PlaceOfBirths")]
    public class PlaceOfBirth : ModelBase, ISuggestable
    {
        /// <summary>
        ///     Обозначение невыбранного типа места рождения
        /// </summary>
        public string DefaultValue { get; } = "[Место рождения не выбрано]";
        
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных места рождения.
        /// </summary>
        public long PlaceOfBirthId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение наименования места рождения.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Явное указание текстового представления места рождения
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Value;

        public int CompareTo(object obj)
        {
            return string.CompareOrdinal(Value, ((PlaceOfBirth)obj).Value);
        }

        
    }
}