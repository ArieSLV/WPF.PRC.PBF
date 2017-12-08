using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     Тип лицевого счета
    /// </summary>
    public enum ShareholderAccountType
    {
        /// <summary>
        ///     Владелец
        /// </summary>
        [StringValue("Владелец")] Owner,

        /// <summary>
        ///     Номинальный держатель
        /// </summary>
        [StringValue("Номинальный держатель")] Nominee,

        /// <summary>
        ///     Доверительный управляющий
        /// </summary>
        [StringValue("Доверительный управляющий")] Trustee,

        /// <summary>
        ///     Депозитный
        /// </summary>
        [StringValue("Депозитный")] Deposit,

        /// <summary>
        ///     Казначейский
        /// </summary>
        [StringValue("Казначейский")] Treasury,

        /// <summary>
        ///     Центральный депозитарий
        /// </summary>
        [StringValue("Центральный депозитарий")] CentralDepository
    }

    /// <summary>
    ///     Лицевой счет акционера
    /// </summary>
    [Serializable]
    [Table("ShareholderAccount")]
    public class ShareholderAccount : ModelBase
    {
        #region ShareholderAccountId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных лицевого счета.
        /// </summary>
        public long ShareholderAccountId
        {
            get => GetValue<long>(ShareholderAccountIdProperty);
            set => SetValue(ShareholderAccountIdProperty, value);
        }

        /// <summary>
        ///     ShareholderAccountId property data.
        /// </summary>
        public static readonly PropertyData ShareholderAccountIdProperty =
            RegisterProperty<ShareholderAccount, long>(model => model.ShareholderAccountId);

        #endregion

        #region Number свойство

        /// <summary>
        ///     Получает или устанавливает значение номера лицевого счета.
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
            RegisterProperty<ShareholderAccount, string>(model => model.Number);

        #endregion

        #region SecuritiesIssuer свойство

        /// <summary>
        ///     Получает или устанавливает значение эмитента, в реестре которого открыт лицевой счет.
        /// </summary>
        public virtual LegalEntity SecuritiesIssuer
        {
            get => GetValue<LegalEntity>(SecuritiesIssuerProperty);
            set => SetValue(SecuritiesIssuerProperty, value);
        }

        /// <summary>
        ///     SecuritiesIssuer property data.
        /// </summary>
        public static readonly PropertyData SecuritiesIssuerProperty =
            RegisterProperty<ShareholderAccount, LegalEntity>(model => model.SecuritiesIssuer);

        #endregion

        #region ShareholderAccountType свойство

        /// <summary>
        ///     Получает или устанавливает значение типа лицевого счета.
        /// </summary>
        public ShareholderAccountType ShareholderAccountType
        {
            get => GetValue<ShareholderAccountType>(ShareholderAccountTypeProperty);
            set => SetValue(ShareholderAccountTypeProperty, value);
        }

        /// <summary>
        ///     ShareholderAccountType property data.
        /// </summary>
        public static readonly PropertyData ShareholderAccountTypeProperty =
            RegisterProperty<ShareholderAccount, ShareholderAccountType>(model => model.ShareholderAccountType);

        #endregion

        #region Unit свойство

        /// <summary>
        ///     Получает или устанавливает значение лица, которому принадлежит лицевой счет.
        /// </summary>
        public Unit Unit
        {
            get => GetValue<Unit>(UnitProperty);
            set => SetValue(UnitProperty, value);
        }

        /// <summary>
        ///     Unit property data.
        /// </summary>
        public static readonly PropertyData UnitProperty =
            RegisterProperty<ShareholderAccount, Unit>(model => model.Unit);

        #endregion


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