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
        /// <summary>
        /// Получает или устанавливает значение кода причины постановки на учет.
        /// </summary>
        public string KPP { get; set; }

        /// <summary>
        /// Получает или устанавливает значение общероссийского классификатора предприятий и организаций.
        /// </summary>
        public string OKPO { get; set; }

        /// <summary>
        /// Получает или устанавливает значение OKVED.
        /// </summary>
        public string OKVED { get; set; }

        /// <summary>
        /// Получает или устанавливает значение cвидетельства о государственной регистрации.
        /// </summary>
        public virtual RegistrationCertificate RegistrationCertificate { get; set; }

        /// <summary>
        /// Получает или устанавливает значение единоличного исполнительного органа юридического лица.
        /// </summary>
        public Unit FirstPersonOfCompany { get; set; }

        /// <summary>
        /// Получает или устанавливает указание на то, является ли данное лицо эмитентом.
        /// </summary>
        public bool RoleIsSecuritiesIssuerFlag { get; set; }

        /// <summary>
        /// Получает или устанавливает значение организационно-правовой формы юридического лица.
        /// </summary>
        public FormOfIncorporation FormOfIncorporation { get; set; }

        /// <summary>
        /// Получает или устанавливает значение краткого наименования по Уставу.
        /// </summary>
        public string ShortName { get; set; }
        
        /// <summary>
        /// Получает или устанавливает значение выпусков ценных бумаг данного юридического лица.
        /// </summary>
        public ObservableCollection<IssueOfSecurities> IssuesOfSecurities { get; set; }
    }
}