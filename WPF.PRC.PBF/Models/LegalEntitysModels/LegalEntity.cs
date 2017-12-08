using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    /// Юридическое лицо
    /// </summary>
    [Serializable]
    [Table("LegalEntities")]
    public class LegalEntity : Unit
    {
        #region KPP свойство

        /// <summary>
        /// Получает или устанавливает значение кода причины постановки на учет.
        /// </summary>
        public string KPP
        {
            get => GetValue<string>(KPPProperty);
            set => SetValue(KPPProperty, value);
        }

        /// <summary>
        /// KPP property data.
        /// </summary>
        public static readonly PropertyData KPPProperty = RegisterProperty<LegalEntity, string>(model => model.KPP);

        #endregion

        #region OKPO свойство

        /// <summary>
        /// Получает или устанавливает значение общероссийского классификатора предприятий и организаций.
        /// </summary>
        public string OKPO
        {
            get => GetValue<string>(OKPOProperty);
            set => SetValue(OKPOProperty, value);
        }

        /// <summary>
        /// OKPO property data.
        /// </summary>
        public static readonly PropertyData OKPOProperty = RegisterProperty<LegalEntity, string>(model => model.OKPO);

        #endregion

        #region OKVED свойство

        /// <summary>
        /// Получает или устанавливает значение OKVED.
        /// </summary>
        public string OKVED
        {
            get => GetValue<string>(OKVEDProperty);
            set => SetValue(OKVEDProperty, value);
        }

        /// <summary>
        /// OKVED property data.
        /// </summary>
        public static readonly PropertyData OKVEDProperty = RegisterProperty<LegalEntity, string>(model => model.OKVED);

        #endregion

        #region RegistrationCertificate свойство

        /// <summary>
        /// Получает или устанавливает значение cвидетельства о государственной регистрации.
        /// </summary>
        public virtual RegistrationCertificate RegistrationCertificate
        {
            get => GetValue<RegistrationCertificate>(RegistrationCertificateProperty);
            set => SetValue(RegistrationCertificateProperty, value);
        }

        /// <summary>
        /// RegistrationCertificate property data.
        /// </summary>
        public static readonly PropertyData RegistrationCertificateProperty = RegisterProperty<LegalEntity, RegistrationCertificate>(model => model.RegistrationCertificate);

        #endregion
        
        #region FirstPersonOfCompany свойство

        /// <summary>
        /// Получает или устанавливает значение единоличного исполнительного органа юридического лица.
        /// </summary>
        public Unit FirstPersonOfCompany
        {
            get => GetValue<Unit>(FirstPersonOfCompanyProperty);
            set => SetValue(FirstPersonOfCompanyProperty, value);
        }

        /// <summary>
        /// FirstPersonOfCompany property data.
        /// </summary>
        public static readonly PropertyData FirstPersonOfCompanyProperty = RegisterProperty<LegalEntity, Unit>(model => model.FirstPersonOfCompany);

        #endregion

        #region RoleIsSecuritiesIssuerFlag свойство

        /// <summary>
        /// Получает или устанавливает указание на то, является ли данное лицо эмитентом.
        /// </summary>
        public bool RoleIsSecuritiesIssuerFlag
        {
            get => GetValue<bool>(RoleIsSecuritiesIssuerFlagProperty);
            set => SetValue(RoleIsSecuritiesIssuerFlagProperty, value);
        }

        /// <summary>
        /// RoleIsSecuritiesIssuerFlag property data.
        /// </summary>
        public static readonly PropertyData RoleIsSecuritiesIssuerFlagProperty = RegisterProperty<LegalEntity, bool>(model => model.RoleIsSecuritiesIssuerFlag);

        #endregion
        
        #region FormOfIncorporation свойство

        /// <summary>
        /// Получает или устанавливает значение организационно-правовой формы юридического лица.
        /// </summary>
        public FormOfIncorporation FormOfIncorporation
        {
            get => GetValue<FormOfIncorporation>(FormOfIncorporationProperty);
            set => SetValue(FormOfIncorporationProperty, value);
        }

        /// <summary>
        /// FormOfIncorporation property data.
        /// </summary>
        public static readonly PropertyData FormOfIncorporationProperty = RegisterProperty<LegalEntity, FormOfIncorporation>(model => model.FormOfIncorporation);

        #endregion
        
        #region ShortName свойство

        /// <summary>
        /// Получает или устанавливает значение краткого наименования по Уставу.
        /// </summary>
        public string ShortName
        {
            get => GetValue<string>(ShortNameProperty);
            set => SetValue(ShortNameProperty, value);
        }

        /// <summary>
        /// ShortName property data.
        /// </summary>
        public static readonly PropertyData ShortNameProperty = RegisterProperty<LegalEntity, string>(model => model.ShortName);

        #endregion

        #region IssuesOfSecurities свойство

        /// <summary>
        /// Получает или устанавливает значение выпусков ценных бумаг данного юридического лица.
        /// </summary>
        public ObservableCollection<IssueOfSecurities> IssuesOfSecurities
        {
            get => GetValue<ObservableCollection<IssueOfSecurities>>(IssuesOfSecuritiesProperty);
            set => SetValue(IssuesOfSecuritiesProperty, value);
        }

        /// <summary>
        /// IssuesOfSecurities property data.
        /// </summary>
        public static readonly PropertyData IssuesOfSecuritiesProperty = RegisterProperty<LegalEntity, ObservableCollection<IssueOfSecurities>>(model => model.IssuesOfSecurities);

        #endregion
    }
}