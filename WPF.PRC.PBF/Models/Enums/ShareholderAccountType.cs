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
}