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
        #region AddressId свойство

        /// <summary>
        ///     Получает или устанавливает значение ID в базе данных адреса.
        /// </summary>
        public long AddressId
        {
            get => GetValue<long>(AddressIdProperty);
            set => SetValue(AddressIdProperty, value);
        }

        /// <summary>
        ///     AddressId property data.
        /// </summary>
        public static readonly PropertyData AddressIdProperty =
            RegisterProperty<Address, long>(model => model.AddressId);

        #endregion

        #region Index свойство

        /// <summary>
        ///     Получает или устанавливает значение почтового индекса.
        /// </summary>
        public string Index
        {
            get => GetValue<string>(IndexProperty);
            set => SetValue(IndexProperty, value);
        }

        /// <summary>
        ///     Index property data.
        /// </summary>
        public static readonly PropertyData IndexProperty = RegisterProperty<Address, string>(model => model.Index);

        #endregion

        #region RegionType свойство

        /// <summary>
        ///     Получает или устанавливает значение типа региона.
        /// </summary>
        public string RegionType
        {
            get => GetValue<string>(RegionTypeProperty);
            set => SetValue(RegionTypeProperty, value);
        }

        /// <summary>
        ///     RegionType property data.
        /// </summary>
        public static readonly PropertyData RegionTypeProperty =
            RegisterProperty<Address, string>(model => model.RegionType);

        #endregion

        #region RegionName свойство

        /// <summary>
        ///     Получает или устанавливает значение имени региона.
        /// </summary>
        public string RegionName
        {
            get => GetValue<string>(RegionNameProperty);
            set => SetValue(RegionNameProperty, value);
        }

        /// <summary>
        ///     RegionName property data.
        /// </summary>
        public static readonly PropertyData RegionNameProperty =
            RegisterProperty<Address, string>(model => model.RegionName);

        #endregion

        #region DistrictType свойство

        /// <summary>
        ///     Получает или устанавливает значение типа местности.
        /// </summary>
        public string DistrictType
        {
            get => GetValue<string>(DistrictTypeProperty);
            set => SetValue(DistrictTypeProperty, value);
        }

        /// <summary>
        ///     DistrictType property data.
        /// </summary>
        public static readonly PropertyData DistrictTypeProperty =
            RegisterProperty<Address, string>(model => model.DistrictType);

        #endregion

        #region DistrictName свойство

        /// <summary>
        ///     Получает или устанавливает значение имени местности.
        /// </summary>
        public string DistrictName
        {
            get => GetValue<string>(DistrictNameProperty);
            set => SetValue(DistrictNameProperty, value);
        }

        /// <summary>
        ///     DistrictName property data.
        /// </summary>
        public static readonly PropertyData DistrictNameProperty =
            RegisterProperty<Address, string>(model => model.DistrictName);

        #endregion

        #region CityType свойство

        /// <summary>
        ///     Получает или устанавливает значение типа поселения.
        /// </summary>
        public string CityType
        {
            get => GetValue<string>(CityTypeProperty);
            set => SetValue(CityTypeProperty, value);
        }

        /// <summary>
        ///     CityType property data.
        /// </summary>
        public static readonly PropertyData CityTypeProperty =
            RegisterProperty<Address, string>(model => model.CityType);

        #endregion

        #region CityName свойство

        /// <summary>
        ///     Получает или устанавливает значение имени поселения.
        /// </summary>
        public string CityName
        {
            get => GetValue<string>(CityNameProperty);
            set => SetValue(CityNameProperty, value);
        }

        /// <summary>
        ///     CityName property data.
        /// </summary>
        public static readonly PropertyData CityNameProperty =
            RegisterProperty<Address, string>(model => model.CityName);

        #endregion

        #region LocalityType свойство

        /// <summary>
        ///     Получает или устанавливает значение типа локального населенного пункта.
        /// </summary>
        public string LocalityType
        {
            get => GetValue<string>(LocalityTypeProperty);
            set => SetValue(LocalityTypeProperty, value);
        }

        /// <summary>
        ///     LocalityType property data.
        /// </summary>
        public static readonly PropertyData LocalityTypeProperty =
            RegisterProperty<Address, string>(model => model.LocalityType);

        #endregion

        #region LocalityName свойство

        /// <summary>
        ///     Получает или устанавливает значение имени локального населенного пункта.
        /// </summary>
        public string LocalityName
        {
            get => GetValue<string>(LocalityNameProperty);
            set => SetValue(LocalityNameProperty, value);
        }

        /// <summary>
        ///     LocalityName property data.
        /// </summary>
        public static readonly PropertyData LocalityNameProperty =
            RegisterProperty<Address, string>(model => model.LocalityName);

        #endregion

        #region StreetType свойство

        /// <summary>
        ///     Получает или устанавливает значение типа улицы.
        /// </summary>
        public string StreetType
        {
            get => GetValue<string>(StreetTypeProperty);
            set => SetValue(StreetTypeProperty, value);
        }

        /// <summary>
        ///     StreetType property data.
        /// </summary>
        public static readonly PropertyData StreetTypeProperty =
            RegisterProperty<Address, string>(model => model.StreetType);

        #endregion

        #region StreetName свойство

        /// <summary>
        ///     Получает или устанавливает значение имени улицы.
        /// </summary>
        public string StreetName
        {
            get => GetValue<string>(StreetNameProperty);
            set => SetValue(StreetNameProperty, value);
        }

        /// <summary>
        ///     StreetName property data.
        /// </summary>
        public static readonly PropertyData StreetNameProperty =
            RegisterProperty<Address, string>(model => model.StreetName);

        #endregion

        #region BuildingType свойство

        /// <summary>
        ///     Получает или устанавливает значение типа здания.
        /// </summary>
        public string BuildingType
        {
            get => GetValue<string>(BuildingTypeProperty);
            set => SetValue(BuildingTypeProperty, value);
        }

        /// <summary>
        ///     BuildingType property data.
        /// </summary>
        public static readonly PropertyData BuildingTypeProperty =
            RegisterProperty<Address, string>(model => model.BuildingType);

        #endregion

        #region BuildingValue свойство

        /// <summary>
        ///     Получает или устанавливает значение номера здания.
        /// </summary>
        public string BuildingValue
        {
            get => GetValue<string>(BuildingValueProperty);
            set => SetValue(BuildingValueProperty, value);
        }

        /// <summary>
        ///     BuildingValue property data.
        /// </summary>
        public static readonly PropertyData BuildingValueProperty =
            RegisterProperty<Address, string>(model => model.BuildingValue);

        #endregion

        #region SubBuildingType свойство

        /// <summary>
        ///     Получает или устанавливает значение корпуса\строения\литеры.
        /// </summary>
        public string SubBuildingType
        {
            get => GetValue<string>(SubBuildingTypeProperty);
            set => SetValue(SubBuildingTypeProperty, value);
        }

        /// <summary>
        ///     SubBuildingType property data.
        /// </summary>
        public static readonly PropertyData SubBuildingTypeProperty =
            RegisterProperty<Address, string>(model => model.SubBuildingType);

        #endregion

        #region SubBuildingValue свойство

        /// <summary>
        ///     Получает или устанавливает значение номера корпуса\строения\литеры.
        /// </summary>
        public string SubBuildingValue
        {
            get => GetValue<string>(SubBuildingValueProperty);
            set => SetValue(SubBuildingValueProperty, value);
        }

        /// <summary>
        ///     SubBuildingValue property data.
        /// </summary>
        public static readonly PropertyData SubBuildingValueProperty =
            RegisterProperty<Address, string>(model => model.SubBuildingValue);

        #endregion

        #region FlatType свойство

        /// <summary>
        ///     Получает или устанавливает значение квартиры\офиса.
        /// </summary>
        public string FlatType
        {
            get => GetValue<string>(FlatTypeProperty);
            set => SetValue(FlatTypeProperty, value);
        }

        /// <summary>
        ///     FlatType property data.
        /// </summary>
        public static readonly PropertyData FlatTypeProperty =
            RegisterProperty<Address, string>(model => model.FlatType);

        #endregion

        #region FlatValue свойство

        /// <summary>
        ///     Получает или устанавливает значение номера квартиры\офиса.
        /// </summary>
        public string FlatValue
        {
            get => GetValue<string>(FlatValueProperty);
            set => SetValue(FlatValueProperty, value);
        }

        /// <summary>
        ///     FlatValue property data.
        /// </summary>
        public static readonly PropertyData FlatValueProperty =
            RegisterProperty<Address, string>(model => model.FlatValue);

        #endregion
    }
}