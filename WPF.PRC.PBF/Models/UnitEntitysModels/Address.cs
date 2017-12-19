using System.ComponentModel.DataAnnotations.Schema;
using Catel.Data;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     Адрес
    /// </summary>
    [Table("Addresses")]
    public class Address : ModelBase
    {
        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных адреса.
        /// </summary>
        public long AddressId { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение почтового индекса.
        /// </summary>
        public string Index { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение типа региона.
        /// </summary>
        public string RegionType { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение имени региона.
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение типа местности.
        /// </summary>
        public string DistrictType { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение имени местности.
        /// </summary>
        public string DistrictName { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение типа поселения.
        /// </summary>
        public string CityType { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение имени поселения.
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение типа локального населенного пункта.
        /// </summary>
        public string LocalityType { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение имени локального населенного пункта.
        /// </summary>
        public string LocalityName { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение типа улицы.
        /// </summary>
        public string StreetType { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение имени улицы.
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение типа здания.
        /// </summary>
        public string BuildingType { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение номера здания.
        /// </summary>
        public string BuildingValue { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение корпуса\строения\литеры.
        /// </summary>
        public string SubBuildingType { get; set; }
        
        /// <summary>
        ///     Получает или устанавливает значение номера корпуса\строения\литеры.
        /// </summary>
        public string SubBuildingValue { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение квартиры\офиса.
        /// </summary>
        public string FlatType { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение номера квартиры\офиса.
        /// </summary>
        public string FlatValue { get; set; }
    }
}