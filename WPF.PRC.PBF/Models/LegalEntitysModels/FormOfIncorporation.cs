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
        /// <summary>
        /// Получает или устанавливает значение FormOfIncorporationId.
        /// </summary>
        public long FormOfIncorporationId { get; set; }

        /// <summary>
        /// Получает или устанавливает значение ShortForm.
        /// </summary>
        public string ShortForm { get; set; }

        /// <summary>
        /// Получает или устанавливает значение организационно-правовой формы.
        /// </summary>
        public string FullForm { get; set; }

        /// <summary>
        /// Явное указание текстового представления организационно-правовой формы.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{FullForm} ({ShortForm})";
    }
}