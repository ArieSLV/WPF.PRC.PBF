using System;
using System.Globalization;

namespace WPF.PRC.PBF
{
    /// <inheritdoc cref="BaseValueConverter{T}"/>
    /// <summary>
    /// Конвертирует полученный объект в <see cref="bool"/>:<para />
    ///     !null == true, null == false.
    /// </summary>
    internal class NotNullToBoolTrue : BaseValueConverter<NotNullToBoolTrue>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }
    }
}
