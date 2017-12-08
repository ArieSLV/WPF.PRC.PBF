using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    /// Орган выдачи Свидетельства о государственной регистрации юридического лица
    /// </summary>
    [Table("RegistrationCertificateIssuers")]
    public class RegistrationCertificateIssuer : ModelBase
    {
        #region RegistrationCertificateIssuerId свойство

        /// <summary>
        /// Получает или устанавливает значение ID в базе данных органа выдачи Свидетельства о государственной регистрации юридического лица.
        /// </summary>
        public long RegistrationCertificateIssuerId
        {
            get => GetValue<long>(RegistrationCertificateIssuerIdProperty);
            set => SetValue(RegistrationCertificateIssuerIdProperty, value);
        }

        /// <summary>
        /// RegistrationCertificateIssuerId property data.
        /// </summary>
        public static readonly PropertyData RegistrationCertificateIssuerIdProperty = RegisterProperty<RegistrationCertificateIssuer, long>(model => model.RegistrationCertificateIssuerId);

        #endregion
        
        #region Value свойство

        /// <summary>
        /// Получает или устанавливает значение имени органа выдачи Свидетельства о государственной регистрации юридического лица.
        /// </summary>
        public string Value
        {
            get => GetValue<string>(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        /// <summary>
        /// Value property data.
        /// </summary>
        public static readonly PropertyData ValueProperty = RegisterProperty<RegistrationCertificateIssuer, string>(model => model.Value);

        #endregion
        
        /// <summary>
        /// Явное указание на текстовое представление органа выдачи Свидетельства о государственной регистрации юридического лица
        /// </summary>
        /// <returns>Орган выдачи Свидетельства о государственной регистрации юридического лица</returns>
        public override string ToString() => Value;

        
        public override bool Equals(object obj)
        {
            if (!(obj is RegistrationCertificateIssuer item)) return false;
            return Value == item.Value && RegistrationCertificateIssuerId == item.RegistrationCertificateIssuerId;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}