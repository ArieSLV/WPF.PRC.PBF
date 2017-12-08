using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <inheritdoc />
    /// <summary>
    /// Организационно-правовая форма
    /// </summary>
    [Table("FormOfIncorporations")]
    public class FormOfIncorporation : ModelBase
    {
        #region FormOfIncorporationId свойство

        /// <summary>
        /// Получает или устанавливает значение FormOfIncorporationId.
        /// </summary>
        public long FormOfIncorporationId
        {
            get => GetValue<long>(FormOfIncorporationIdProperty);
            set => SetValue(FormOfIncorporationIdProperty, value);
        }

        /// <summary>
        /// FormOfIncorporationId property data.
        /// </summary>
        public static readonly PropertyData FormOfIncorporationIdProperty = RegisterProperty<FormOfIncorporation, long>(model => model.FormOfIncorporationId);

        #endregion

        #region ShortForm свойство

        /// <summary>
        /// Получает или устанавливает значение ShortForm.
        /// </summary>
        public string ShortForm
        {
            get => GetValue<string>(ShortFormProperty);
            set => SetValue(ShortFormProperty, value);
        }

        /// <summary>
        /// ShortForm property data.
        /// </summary>
        public static readonly PropertyData ShortFormProperty = RegisterProperty<FormOfIncorporation, string>(model => model.ShortForm);

        #endregion

        #region FullForm свойство

        /// <summary>
        /// Получает или устанавливает значение организационно-правовой формы.
        /// </summary>
        public string FullForm
        {
            get => GetValue<string>(FullFormProperty);
            set => SetValue(FullFormProperty, value);
        }

        /// <summary>
        /// FullForm property data.
        /// </summary>
        public static readonly PropertyData FullFormProperty = RegisterProperty<FormOfIncorporation, string>(model => model.FullForm);

        #endregion

        /// <summary>
        /// Явное указание текстового представления организационно-правовой формы.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{FullForm} ({ShortForm})";
    }
}