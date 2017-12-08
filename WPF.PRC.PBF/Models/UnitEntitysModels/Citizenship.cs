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

        #region CitizenshipId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных гражданства.
        /// </summary>
        public long CitizenshipId
        {
            get => GetValue<long>(CitizenshipIdProperty);
            set => SetValue(CitizenshipIdProperty, value);
        }

        /// <summary>
        ///     CitizenshipId property data.
        /// </summary>
        public static readonly PropertyData CitizenshipIdProperty =
            RegisterProperty<Citizenship, long>(model => model.CitizenshipId);

        #endregion

        #region Value свойство

        /// <summary>
        ///     Получает или устанавливает значение имени страны.
        /// </summary>
        public string Value
        {
            get => GetValue<string>(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        /// <summary>
        ///     Value property data.
        /// </summary>
        public static readonly PropertyData ValueProperty = RegisterProperty<Citizenship, string>(model => model.Value);

        #endregion

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