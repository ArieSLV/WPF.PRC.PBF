using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <inheritdoc />
    /// <summary>
    ///     Банковские реквизиты лицевого счета
    /// </summary>
    [Table("BankDetails")]
    public class BankDetails : ModelBase
    {
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных Банковских реквизитов лицевого счета.
        /// </summary>
        public long BankDetailsId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение лицевого счет лица.
        /// </summary>
        public string PersonalAccount { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение наименование отделения банка.
        /// </summary>
        public string BankBranchName { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение счета получателя платежа.
        /// </summary>
        public string MainAccount { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение корреспондентского счета.
        /// </summary>
        public string CorrAccount { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение наименования банка.
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение банковского идентификационного кода.
        /// </summary>
        public string BIK { get; set; } 
        
        /// <summary>
        ///     Получает или устанавливает значение города банка.
        /// </summary>
        public string BankCity { get; set; }
    }
}