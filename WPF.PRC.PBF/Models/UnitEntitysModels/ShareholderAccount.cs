using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     Лицевой счет акционера
    /// </summary>
    [Serializable]
    [Table("ShareholderAccount")]
    public class ShareholderAccount : ModelBase
    {
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных лицевого счета.
        /// </summary>
        public long ShareholderAccountId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение номера лицевого счета.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение эмитента, в реестре которого открыт лицевой счет.
        /// </summary>
        public virtual LegalEntity SecuritiesIssuer { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение типа лицевого счета.
        /// </summary>
        public ShareholderAccountType ShareholderAccountType { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение лица, которому принадлежит лицевой счет.
        /// </summary>
        public Unit Unit { get; set; }

        /// <summary>
        ///     Явное указание текстового представления лицевого счета
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var stringToReturn = new StringBuilder();

            var unitToReturn = Unit?.ToString() ?? string.Empty;
            var numberToReturn = Number ?? string.Empty;
            var siToReturn = SecuritiesIssuer != null ? SecuritiesIssuer.ShortName : string.Empty;

            if (!string.IsNullOrWhiteSpace(unitToReturn)) stringToReturn.Append($"{unitToReturn}");
            if (!string.IsNullOrWhiteSpace(numberToReturn) &&
                !string.IsNullOrWhiteSpace(siToReturn) &&
                !string.IsNullOrWhiteSpace(unitToReturn)) stringToReturn.Append(" (");
            if (!string.IsNullOrWhiteSpace(numberToReturn)) stringToReturn.Append(numberToReturn);
            if (numberToReturn != "[лицевой счет не выбран]")
                stringToReturn.Append($", {StringEnum.GetStringValue(ShareholderAccountType)}");
            if (!string.IsNullOrWhiteSpace(siToReturn)) stringToReturn.Append($", {siToReturn}");
            if (!string.IsNullOrWhiteSpace(numberToReturn) &&
                !string.IsNullOrWhiteSpace(siToReturn) &&
                !string.IsNullOrWhiteSpace(unitToReturn)) stringToReturn.Append(")");


            return stringToReturn.ToString();
        }
    }
}