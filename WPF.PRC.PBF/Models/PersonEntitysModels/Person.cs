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
        /// <summary>
        ///     Получает или устанавливает значение Фамилии.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение Имени.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение Отчества.
        /// </summary>
        public string MiddleName { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение даты рождения.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        ///     Получает или устанавливает Указание на то, относится ли лицо к категории лиц, указанных в подпунктах 1, 5 пункта 1
        ///     статьи 7.3 Федерального закона № 115-ФЗ от 07.08.2001 "О противодействии легализации (отмыванию) доходов,
        ///     полученных преступным путем, и финансированию терроризма".
        /// </summary>
        public bool IsOneOfPODFTFlag { get; set; }

        /// <summary>
        ///     Получает или устанавливает указание на то, имеет ли лицо бенефициарного владельца и/или выгодоприобретателя.
        /// </summary>
        public bool GotBeneficialOwnerFlag { get; set; }

        /// <summary>
        ///     Получает или устанавливает Указание на то, что лицо является руководителем или учредителем некоммерческой
        ///     организации,
        ///     иностранной некоммерческой неправительственной организации, её отделения, филиала,
        ///     или представительства, осуществляющих свою деятельность на территории РФ.
        /// </summary>
        public bool IsHeadNonComercialCompanyFlag { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение документа удостоверяющий личность.
        /// </summary>
        public CardID CardID { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение места рождения.
        /// </summary>
        public PlaceOfBirth PlaceOfBirth { get; set; }
        
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