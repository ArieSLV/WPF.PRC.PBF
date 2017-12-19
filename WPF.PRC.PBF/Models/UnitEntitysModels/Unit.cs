using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     Лицо
    /// </summary>
    [Table("Units")]
    public class Unit : ModelBase
    {
        #region UnitId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных лица.
        /// </summary>
        public long UnitId
        {
            get => GetValue<long>(UnitIdProperty);
            set => SetValue(UnitIdProperty, value);
        }

        /// <summary>
        ///     UnitId property data.
        /// </summary>
        public static readonly PropertyData UnitIdProperty = RegisterProperty<Unit, long>(model => model.UnitId);

        #endregion

        #region DividentsPaymentWay свойство

        /// <summary>
        ///     Получает или устанавливает значение способа получения дивидендов.
        /// </summary>
        public DividentsPaymentWays DividentsPaymentWay
        {
            get => GetValue<DividentsPaymentWays>(DividentsPaymentWayProperty);
            set => SetValue(DividentsPaymentWayProperty, value);
        }

        /// <summary>
        ///     DividentsPaymentWay property data.
        /// </summary>
        public static readonly PropertyData DividentsPaymentWayProperty =
            RegisterProperty<Unit, DividentsPaymentWays>(model => model.DividentsPaymentWay);

        #endregion

        #region OnlyPersonalPresenceFlag свойство

        /// <summary>
        ///     Получает или устанавливает указание на то, что документы для проведения операций могут представляться почтовым
        ///     отправлением в случаях, предусмотренных Правилами ведения реестра Регистратора.
        /// </summary>
        public bool OnlyPersonalPresenceFlag
        {
            get => GetValue<bool>(OnlyPersonalPresenceFlagProperty);
            set => SetValue(OnlyPersonalPresenceFlagProperty, value);
        }

        /// <summary>
        ///     OnlyPersonalPresenceFlag property data.
        /// </summary>
        public static readonly PropertyData OnlyPersonalPresenceFlagProperty =
            RegisterProperty<Unit, bool>(model => model.OnlyPersonalPresenceFlag);

        #endregion

        #region INN свойство

        /// <summary>
        ///     Получает или устанавливает значение Индивидуального номера налогоплатильщика.
        /// </summary>
        public string INN
        {
            get => GetValue<string>(INNProperty);
            set => SetValue(INNProperty, value);
        }

        /// <summary>
        ///     INN property data.
        /// </summary>
        public static readonly PropertyData INNProperty = RegisterProperty<Unit, string>(model => model.INN);

        #endregion

        #region MailingAddressEqualRegistrationAddressFlag свойство

        /// <summary>
        ///     Получает или устанавливает указание на то, что почтовый адрес совпадает с адресом места регистрации.
        /// </summary>
        public bool MailingAddressEqualRegistrationAddressFlag
        {
            get => GetValue<bool>(MailingAddressEqualRegistrationAddressFlagProperty);
            set => SetValue(MailingAddressEqualRegistrationAddressFlagProperty, value);
        }

        /// <summary>
        ///     MailingAddressEqualRegistrationAddressFlag property data.
        /// </summary>
        public static readonly PropertyData MailingAddressEqualRegistrationAddressFlagProperty =
            RegisterProperty<Unit, bool>(model => model.MailingAddressEqualRegistrationAddressFlag);

        #endregion

        #region Citizenship свойство

        /// <summary>
        ///     Получает или устанавливает значение гражданства\страны регистрации.
        /// </summary>
        public Citizenship Citizenship
        {
            get => GetValue<Citizenship>(CitizenshipProperty);
            set => SetValue(CitizenshipProperty, value);
        }

        /// <summary>
        ///     Citizenship property data.
        /// </summary>
        public static readonly PropertyData CitizenshipProperty =
            RegisterProperty<Unit, Citizenship>(model => model.Citizenship);

        #endregion

        #region AddressRegistration свойство

        /// <summary>
        ///     Получает или устанавливает значение адреса регистрации\юридического адреса.
        /// </summary>
        public Address AddressRegistration
        {
            get => GetValue<Address>(AddressRegistrationProperty);
            set => SetValue(AddressRegistrationProperty, value);
        }

        /// <summary>
        ///     AddressRegistration property data.
        /// </summary>
        public static readonly PropertyData AddressRegistrationProperty =
            RegisterProperty<Unit, Address>(model => model.AddressRegistration);

        #endregion

        #region MailingAddress свойство

        /// <summary>
        ///     Получает или устанавливает значение почтового адреса.
        /// </summary>
        public Address MailingAddress
        {
            get => GetValue<Address>(MailingAddressProperty);
            set => SetValue(MailingAddressProperty, value);
        }

        /// <summary>
        ///     MailingAddress property data.
        /// </summary>
        public static readonly PropertyData MailingAddressProperty =
            RegisterProperty<Unit, Address>(model => model.MailingAddress);

        #endregion

        #region PhoneNumbers свойство

        /// <summary>
        ///     Получает или устанавливает значение набора телефонных номеров.
        /// </summary>
        public ObservableCollection<PhoneNumber> PhoneNumbers
        {
            get => GetValue<ObservableCollection<PhoneNumber>>(PhoneNumbersProperty);
            set => SetValue(PhoneNumbersProperty, value);
        }

        /// <summary>
        ///     PhoneNumbers property data.
        /// </summary>
        public static readonly PropertyData PhoneNumbersProperty =
            RegisterProperty<Unit, ObservableCollection<PhoneNumber>>(model => model.PhoneNumbers);

        #endregion

        #region Emails свойство

        /// <summary>
        ///     Получает или устанавливает значение набора адресов электронной почты.
        /// </summary>
        public ObservableCollection<Email> Emails
        {
            get => GetValue<ObservableCollection<Email>>(EmailsProperty);
            set => SetValue(EmailsProperty, value);
        }

        /// <summary>
        ///     Emails property data.
        /// </summary>
        public static readonly PropertyData EmailsProperty =
            RegisterProperty<Unit, ObservableCollection<Email>>(model => model.Emails);

        #endregion

        #region BankDetails свойство

        /// <summary>
        ///     Получает или устанавливает значение банковских реквизитов.
        /// </summary>
        public BankDetails BankDetails
        {
            get => GetValue<BankDetails>(BankDetailsProperty);
            set => SetValue(BankDetailsProperty, value);
        }

        /// <summary>
        ///     BankDetails property data.
        /// </summary>
        public static readonly PropertyData BankDetailsProperty =
            RegisterProperty<Unit, BankDetails>(model => model.BankDetails);

        #endregion

        #region ShareholderAccounts свойство

        /// <summary>
        ///     Получает или устанавливает значение коллекции лицевых счетов, принадлежащих данному лицу.
        /// </summary>
        public ObservableCollection<ShareholderAccount> ShareholderAccounts
        {
            get => GetValue<ObservableCollection<ShareholderAccount>>(ShareholderAccountsProperty);
            set => SetValue(ShareholderAccountsProperty, value);
        }

        /// <summary>
        ///     ShareholderAccounts property data.
        /// </summary>
        public static readonly PropertyData ShareholderAccountsProperty =
            RegisterProperty<Unit, ObservableCollection<ShareholderAccount>>(model => model.ShareholderAccounts);

        #endregion

        #region RoleIsShareHolderFlag свойство

        /// <summary>
        ///     Получает или устанавливает указание на то, является ли лицо акционером.
        /// </summary>
        public bool RoleIsShareHolderFlag
        {
            get => GetValue<bool>(RoleIsShareHolderFlagProperty);
            set => SetValue(RoleIsShareHolderFlagProperty, value);
        }

        /// <summary>
        ///     RoleIsShareHolderFlag property data.
        /// </summary>
        public static readonly PropertyData RoleIsShareHolderFlagProperty =
            RegisterProperty<Unit, bool>(model => model.RoleIsShareHolderFlag);

        #endregion

        #region RoleIsFirstPersonOfTheCompany свойство

        /// <summary>
        ///     Получает или устанавливает указание на то, является ли лицо единоличным исполнительным органом.
        /// </summary>
        public bool RoleIsFirstPersonOfTheCompany
        {
            get => GetValue<bool>(RoleIsFirstPersonOfTheCompanyProperty);
            set => SetValue(RoleIsFirstPersonOfTheCompanyProperty, value);
        }

        /// <summary>
        ///     RoleIsFirstPersonOfTheCompany property data.
        /// </summary>
        public static readonly PropertyData RoleIsFirstPersonOfTheCompanyProperty =
            RegisterProperty<Unit, bool>(model => model.RoleIsFirstPersonOfTheCompany);

        #endregion

        #region TimeStamp свойство

        /// <summary>
        ///     Получает или устанавливает значение даты создания (последнего редактирования) записи о лице.
        /// </summary>
        public DateTime? TimeStamp
        {
            get => GetValue<DateTime?>(TimeStampProperty);
            set => SetValue(TimeStampProperty, value);
        }

        /// <summary>
        ///     TimeStamp property data.
        /// </summary>
        public static readonly PropertyData TimeStampProperty =
            RegisterProperty<Unit, DateTime?>(model => model.TimeStamp);

        #endregion

        #region FullName свойство

        /// <summary>
        ///     Получает или устанавливает значение полного наименования лица.
        /// </summary>
        public string FullName
        {
            get => GetValue<string>(FullNameProperty);
            set => SetValue(FullNameProperty, value);
        }

        /// <summary>
        ///     FullName property data.
        /// </summary>
        public static readonly PropertyData FullNameProperty = RegisterProperty<Unit, string>(model => model.FullName);

        #endregion
    }
}