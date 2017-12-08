using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    /// Место рождения
    /// </summary>
    [Table("PlaceOfBirths")]
    public class PlaceOfBirth : ModelBase
    {
        #region PlaceOfBirthId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных места рождения.
        /// </summary>
        public long PlaceOfBirthId
        {
            get => GetValue<long>(PlaceOfBirthIdProperty);
            set => SetValue(PlaceOfBirthIdProperty, value);
        }

        /// <summary>
        ///     PlaceOfBirthId property data.
        /// </summary>
        public static readonly PropertyData PlaceOfBirthIdProperty =
            RegisterProperty<PlaceOfBirth, long>(model => model.PlaceOfBirthId);

        #endregion

        #region Value свойство

        /// <summary>
        ///     Получает или устанавливает значение наименования места рождения.
        /// </summary>
        public string Value
        {
            get => GetValue<string>(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        /// <summary>
        ///     Value property data.
        /// </summary>
        public static readonly PropertyData ValueProperty = RegisterProperty<PlaceOfBirth, string>(model => model.Value)
            ;

        #endregion

        /// <summary>
        /// Явное указание текстового представления места рождения
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Value;
    }
}