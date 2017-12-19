using System;
using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     Свидетельство о государственной регистрации
    /// </summary>
    [Table("RegistrationCertificates")]
    public class RegistrationCertificate : ModelBase
    {
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных у данного Свидетельства о государственной регистрации.
        /// </summary>
        public long RegistrationCertificateId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение номера Свидетельства о государственной регистрации.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение даты выдачи Свидетельства о государственной регистрации.
        /// </summary>
        public DateTime? IssueDate { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение органа выдачи Свидетельства о государственной регистрации.
        /// </summary>
        public RegistrationCertificateIssuer RegistrationCertificateIssuer { get; set; }
    }
}