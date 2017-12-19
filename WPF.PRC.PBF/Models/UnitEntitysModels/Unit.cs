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
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных лица.
        /// </summary>
        public long UnitId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение способа получения дивидендов.
        /// </summary>
        public DividentsPaymentWays DividentsPaymentWay { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает указание на то, что документы для проведения операций могут представляться почтовым
        ///     отправлением в случаях, предусмотренных Правилами ведения реестра Регистратора.
        /// </summary>
        public bool OnlyPersonalPresenceFlag { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение Индивидуального номера налогоплатильщика.
        /// </summary>
        public string INN { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает указание на то, что почтовый адрес совпадает с адресом места регистрации.
        /// </summary>
        public bool MailingAddressEqualRegistrationAddressFlag { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение гражданства\страны регистрации.
        /// </summary>
        public Citizenship Citizenship { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение адреса регистрации\юридического адреса.
        /// </summary>
        public Address AddressRegistration { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение почтового адреса.
        /// </summary>
        public Address MailingAddress { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение набора телефонных номеров.
        /// </summary>
        public ObservableCollection<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение набора адресов электронной почты.
        /// </summary>
        public ObservableCollection<Email> Emails { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение банковских реквизитов.
        /// </summary>
        public BankDetails BankDetails { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение коллекции лицевых счетов, принадлежащих данному лицу.
        /// </summary>
        public ObservableCollection<ShareholderAccount> ShareholderAccounts { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает указание на то, является ли лицо акционером.
        /// </summary>
        public bool RoleIsShareHolderFlag { get; set; }

        /// <summary>
        ///     Получает или устанавливает указание на то, является ли лицо единоличным исполнительным органом.
        /// </summary>
        public bool RoleIsFirstPersonOfTheCompany { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение даты создания (последнего редактирования) записи о лице.
        /// </summary>
        public DateTime? TimeStamp { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение полного наименования лица.
        /// </summary>
        public string FullName { get; set; }
    }
}