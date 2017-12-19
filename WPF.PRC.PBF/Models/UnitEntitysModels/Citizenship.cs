using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     Гражданство
    /// </summary>
    [Table("Citizenships")]
    public class Citizenship : ModelBase, ISuggestable
    {
        /// <summary>
        ///     Обозначение невыбранного типа гражданства
        /// </summary>
        public string DefaultValue { get; } = "[Страна не выбрана]";

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных гражданства.
        /// </summary>
        public long CitizenshipId { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение имени страны.
        /// </summary>
        public string Value { get; set; }
        

        /// <summary>
        ///     Явное указание текстового представления гражданства
        /// </summary>
        public override string ToString()
        {
            return Value;
        }

        public int CompareTo(object obj)
        {
            return string.CompareOrdinal(Value, ((Citizenship) obj).Value);
        }
    }
}