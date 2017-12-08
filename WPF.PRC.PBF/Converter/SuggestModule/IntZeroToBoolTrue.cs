using System;
using System.Globalization;

namespace WPF.PRC.PBF
{
    /// <inheritdoc cref="BaseValueConverter{T}" />
    /// <summary>
    ///     Конвертирует количество в <see cref="T:System.Boolean" />:
    ///     <para />
    ///     0 == true, иначе == false.
    /// </summary>
    internal class IntZeroToBoolTrue : BaseValueConverter<IntZeroToBoolTrue>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            return (int) value == 0;
        }
    }
}