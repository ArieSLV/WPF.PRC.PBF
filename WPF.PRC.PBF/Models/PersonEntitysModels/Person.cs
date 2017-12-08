using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <inheritdoc />
    /// <summary>
    ///     Физическое лицо
    /// </summary>
    [Serializable]
    [Table("Persons")]
    public class Person : Unit
    {
        #region LastName свойство

        /// <summary>
        ///     Получает или устанавливает значение Фамилии.
        /// </summary>
        public string LastName
        {
            get => GetValue<string>(LastNameProperty);
            set => SetValue(LastNameProperty, value);
        }

        /// <summary>
        ///     LastName property data.
        /// </summary>
        public static readonly PropertyData LastNameProperty = RegisterProperty<Person, string>(model => model.LastName);

        #endregion
        
        #region FirstName свойство

        /// <summary>
        ///     Получает или устанавливает значение Имени.
        /// </summary>
        public string FirstName
        {
            get => GetValue<string>(FirstNameProperty);
            set => SetValue(FirstNameProperty, value);
        }

        /// <summary>
        ///     FirstName property data.
        /// </summary>
        public static readonly PropertyData FirstNameProperty =
            RegisterProperty<Person, string>(model => model.FirstName);

        #endregion
        
        #region MiddleName свойство

        /// <summary>
        ///     Получает или устанавливает значение Отчества.
        /// </summary>
        public string MiddleName
        {
            get => GetValue<string>(MiddleNameProperty);
            set => SetValue(MiddleNameProperty, value);
        }

        /// <summary>
        ///     MiddleName property data.
        /// </summary>
        public static readonly PropertyData MiddleNameProperty =
            RegisterProperty<Person, string>(model => model.MiddleName);

        #endregion
        
        #region DateOfBirth свойство

        /// <summary>
        ///     Получает или устанавливает значение даты рождения.
        /// </summary>
        public DateTime? DateOfBirth
        {
            get => GetValue<DateTime?>(DateOfBirthProperty);
            set => SetValue(DateOfBirthProperty, value);
        }

        /// <summary>
        ///     DateOfBirth property data.
        /// </summary>
        public static readonly PropertyData DateOfBirthProperty =
            RegisterProperty<Person, DateTime?>(model => model.DateOfBirth);

        #endregion
        
        #region IsOneOfPODFTFlag свойство

        /// <summary>
        ///     Получает или устанавливает Указание на то, относится ли лицо к категории лиц, указанных в подпунктах 1, 5 пункта 1
        ///     статьи 7.3 Федерального
        ///     закона № 115-ФЗ от 07.08.2001 "О противодействии легализации (отмыванию)
        ///     доходов, полученных преступным путем, и финансированию терроризма".
        /// </summary>
        public bool IsOneOfPODFTFlag
        {
            get => GetValue<bool>(IsOneOfPODFTFlagProperty);
            set => SetValue(IsOneOfPODFTFlagProperty, value);
        }

        /// <summary>
        ///     IsOneOfPODFTFlag property data.
        /// </summary>
        public static readonly PropertyData IsOneOfPODFTFlagProperty =
            RegisterProperty<Person, bool>(model => model.IsOneOfPODFTFlag);

        #endregion
        
        #region GotBeneficialOwnerFlag свойство

        /// <summary>
        ///     Получает или устанавливает указание на то, имеет ли лицо бенефициарного владельца и/или выгодоприобретателя.
        /// </summary>
        public bool GotBeneficialOwnerFlag
        {
            get => GetValue<bool>(GotBeneficialOwnerFlagProperty);
            set => SetValue(GotBeneficialOwnerFlagProperty, value);
        }

        /// <summary>
        ///     GotBeneficialOwnerFlag property data.
        /// </summary>
        public static readonly PropertyData GotBeneficialOwnerFlagProperty =
            RegisterProperty<Person, bool>(model => model.GotBeneficialOwnerFlag);

        #endregion
        
        #region IsHeadNonComercialCompanyFlag свойство

        /// <summary>
        ///     Получает или устанавливает Указание на то, что лицо является руководителем или учредителем некоммерческой
        ///     организации,
        ///     иностранной некоммерческой неправительственной организации, её отделения, филиала,
        ///     или представительства, осуществляющих свою деятельность на территории РФ.
        /// </summary>
        public bool IsHeadNonComercialCompanyFlag
        {
            get => GetValue<bool>(IsHeadNonComercialCompanyFlagProperty);
            set => SetValue(IsHeadNonComercialCompanyFlagProperty, value);
        }

        /// <summary>
        ///     IsHeadNonComercialCompanyFlag property data.
        /// </summary>
        public static readonly PropertyData IsHeadNonComercialCompanyFlagProperty =
            RegisterProperty<Person, bool>(model => model.IsHeadNonComercialCompanyFlag);

        #endregion
        
        #region CardID свойство

        /// <summary>
        ///     Получает или устанавливает значение документа удостоверяющий личность.
        /// </summary>
        public CardID CardID
        {
            get => GetValue<CardID>(CardIDProperty);
            set => SetValue(CardIDProperty, value);
        }

        /// <summary>
        ///     CardID property data.
        /// </summary>
        public static readonly PropertyData CardIDProperty = RegisterProperty<Person, CardID>(model => model.CardID);

        #endregion
        
        #region PlaceOfBirth свойство

        /// <summary>
        ///     Получает или устанавливает значение места рождения.
        /// </summary>
        public PlaceOfBirth PlaceOfBirth
        {
            get => GetValue<PlaceOfBirth>(PlaceOfBirthProperty);
            set => SetValue(PlaceOfBirthProperty, value);
        }

        /// <summary>
        ///     PlaceOfBirth property data.
        /// </summary>
        public static readonly PropertyData PlaceOfBirthProperty =
            RegisterProperty<Person, PlaceOfBirth>(model => model.PlaceOfBirth);

        #endregion
        
        /// <summary>
        ///     Явное указание текстового представления физического лица
        /// </summary>
        public override string ToString()
        {
            var stringToReturn = new StringBuilder();

            stringToReturn.Append(!string.IsNullOrWhiteSpace(FullName) ? FullName : "[Имя не указано]");
            if (DateOfBirth != null) stringToReturn.Append($", {DateOfBirth:dd.MM.yyyy}г.р.");
            if (!string.IsNullOrWhiteSpace(CardID?.Series) || !string.IsNullOrWhiteSpace(CardID?.Number))
                stringToReturn.Append(",");
            if (!string.IsNullOrWhiteSpace(CardID?.Series)) stringToReturn.Append($" {CardID.Series}");
            if (!string.IsNullOrWhiteSpace(CardID?.Number)) stringToReturn.Append($" {CardID.Number}");

            return stringToReturn.ToString();
        }
    }
}