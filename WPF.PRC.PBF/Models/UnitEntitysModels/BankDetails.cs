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
        #region BankDetailsId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных Банковских реквизитов лицевого счета.
        /// </summary>
        public long BankDetailsId
        {
            get => GetValue<long>(BankDetailsIdProperty);
            set => SetValue(BankDetailsIdProperty, value);
        }

        /// <summary>
        ///     BankDetailsId property data.
        /// </summary>
        public static readonly PropertyData BankDetailsIdProperty =
            RegisterProperty<BankDetails, long>(model => model.BankDetailsId);

        #endregion

        #region PersonalAccount свойство

        /// <summary>
        ///     Получает или устанавливает значение лицевого счет лица.
        /// </summary>
        public string PersonalAccount
        {
            get => GetValue<string>(PersonalAccountProperty);
            set => SetValue(PersonalAccountProperty, value);
        }

        /// <summary>
        ///     PersonalAccount property data.
        /// </summary>
        public static readonly PropertyData PersonalAccountProperty =
            RegisterProperty<BankDetails, string>(model => model.PersonalAccount);

        #endregion

        #region BankBranchName свойство

        /// <summary>
        ///     Получает или устанавливает значение наименование отделения банка.
        /// </summary>
        public string BankBranchName
        {
            get => GetValue<string>(BankBranchNameProperty);
            set => SetValue(BankBranchNameProperty, value);
        }

        /// <summary>
        ///     BankBranchName property data.
        /// </summary>
        public static readonly PropertyData BankBranchNameProperty =
            RegisterProperty<BankDetails, string>(model => model.BankBranchName);

        #endregion

        #region MainAccount свойство

        /// <summary>
        ///     Получает или устанавливает значение счета получателя платежа.
        /// </summary>
        public string MainAccount
        {
            get => GetValue<string>(MainAccountProperty);
            set => SetValue(MainAccountProperty, value);
        }

        /// <summary>
        ///     MainAccount property data.
        /// </summary>
        public static readonly PropertyData MainAccountProperty =
            RegisterProperty<BankDetails, string>(model => model.MainAccount);

        #endregion

        #region CorrAccount свойство

        /// <summary>
        ///     Получает или устанавливает значение корреспондентского счета.
        /// </summary>
        public string CorrAccount
        {
            get => GetValue<string>(CorrAccountProperty);
            set => SetValue(CorrAccountProperty, value);
        }

        /// <summary>
        ///     CorrAccount property data.
        /// </summary>
        public static readonly PropertyData CorrAccountProperty =
            RegisterProperty<BankDetails, string>(model => model.CorrAccount);

        #endregion

        #region BankName свойство

        /// <summary>
        ///     Получает или устанавливает значение наименования банка.
        /// </summary>
        public string BankName
        {
            get => GetValue<string>(BankNameProperty);
            set => SetValue(BankNameProperty, value);
        }

        /// <summary>
        ///     BankName property data.
        /// </summary>
        public static readonly PropertyData BankNameProperty =
            RegisterProperty<BankDetails, string>(model => model.BankName);

        #endregion

        #region BIK свойство

        /// <summary>
        ///     Получает или устанавливает значение банковского идентификационного кода.
        /// </summary>
        public string BIK
        {
            get => GetValue<string>(BIKProperty);
            set => SetValue(BIKProperty, value);
        }

        /// <summary>
        ///     BIK property data.
        /// </summary>
        public static readonly PropertyData BIKProperty = RegisterProperty<BankDetails, string>(model => model.BIK);

        #endregion

        #region BankCity свойство

        /// <summary>
        ///     Получает или устанавливает значение города банка.
        /// </summary>
        public string BankCity
        {
            get => GetValue<string>(BankCityProperty);
            set => SetValue(BankCityProperty, value);
        }

        /// <summary>
        ///     BankCity property data.
        /// </summary>
        public static readonly PropertyData BankCityProperty =
            RegisterProperty<BankDetails, string>(model => model.BankCity);

        #endregion
    }
}