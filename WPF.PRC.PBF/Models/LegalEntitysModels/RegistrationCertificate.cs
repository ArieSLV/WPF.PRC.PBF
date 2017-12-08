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
        #region RegistrationCertificateId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных у данного Свидетельства о государственной регистрации.
        /// </summary>
        public long RegistrationCertificateId
        {
            get => GetValue<long>(RegistrationCertificateIdProperty);
            set => SetValue(RegistrationCertificateIdProperty, value);
        }

        /// <summary>
        ///     RegistrationCertificateId property data.
        /// </summary>
        public static readonly PropertyData RegistrationCertificateIdProperty =
            RegisterProperty<RegistrationCertificate, long>(model => model.RegistrationCertificateId);

        #endregion
        
        #region Number свойство

        /// <summary>
        ///     Получает или устанавливает значение номера Свидетельства о государственной регистрации.
        /// </summary>
        public string Number
        {
            get => GetValue<string>(NumberProperty);
            set => SetValue(NumberProperty, value);
        }

        /// <summary>
        ///     Number property data.
        /// </summary>
        public static readonly PropertyData NumberProperty =
            RegisterProperty<RegistrationCertificate, string>(model => model.Number);

        #endregion
        
        #region IssueDate свойство

        /// <summary>
        ///     Получает или устанавливает значение даты выдачи Свидетельства о государственной регистрации.
        /// </summary>
        public DateTime? IssueDate
        {
            get => GetValue<DateTime?>(IssueDateProperty);
            set => SetValue(IssueDateProperty, value);
        }

        /// <summary>
        ///     IssueDate property data.
        /// </summary>
        public static readonly PropertyData IssueDateProperty =
            RegisterProperty<RegistrationCertificate, DateTime?>(model => model.IssueDate);

        #endregion
        
        #region RegistrationCertificateIssuer свойство

        /// <summary>
        ///     Получает или устанавливает значение органа выдачи Свидетельства о государственной регистрации.
        /// </summary>
        public RegistrationCertificateIssuer RegistrationCertificateIssuer
        {
            get => GetValue<RegistrationCertificateIssuer>(RegistrationCertificateIssuerProperty);
            set => SetValue(RegistrationCertificateIssuerProperty, value);
        }

        /// <summary>
        ///     RegistrationCertificateIssuer property data.
        /// </summary>
        public static readonly PropertyData RegistrationCertificateIssuerProperty =
            RegisterProperty<RegistrationCertificate, RegistrationCertificateIssuer>(model =>
                model.RegistrationCertificateIssuer);

        #endregion
    }
}