using Catel.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPF.PRC.PBF
{
    /// <summary>
    /// Выпуск ценных бумаг
    /// </summary>
    [Table("IssuesOfSecurities")]
    public class IssueOfSecurities :ModelBase
    {
        /// <summary>
        /// Получает или устанавливает значение ID выпуска ценных бумаг.
        /// </summary>
        public long IssueOfSecuritiesId { get; set; }

        /// <summary>
        /// Получает или устанавливает значение типа ценных бумаг.
        /// </summary>
        public SecuritiesTypes Type { get; set; }

        /// <summary>
        /// Получает или устанавливает значение номера выпуска ценных бумаг.
        /// </summary>
        public string Number { get; set; }
    }
}