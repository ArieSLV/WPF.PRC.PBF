namespace WPF.PRC.PBF
{
    public enum SecuritiesTypes
    {
        /// <summary>
        /// Акция обыкновенная именная
        /// </summary>
        [StringValue("Акция обыкновенная именная")]
        SimpleShare,

        /// <summary>
        /// Акция привилегированная именная типа А
        /// </summary>
        [StringValue("Акция привилегированная именная типа А")]
        PreferredTypaAShare,

        /// <summary>
        /// Акция привилегированная именная
        /// </summary>
        [StringValue("Акция привилегированная именная")]
        PreferredShare,

        Unknown
    }
}