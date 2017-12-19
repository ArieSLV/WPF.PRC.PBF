using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Catel;
using Catel.Collections;
using Catel.IoC;
using Catel.MVVM;
using Catel.MVVM.Converters;
using Catel.Reflection;
using Catel.Logging;

namespace WPF.PRC.PBF.Converter
{
    class CustomViewModelToViewConverter : ValueConverterBase
    {
        private static readonly IViewLocator _viewLocator;

        /// <summary>
        /// Initializes static members of the <see cref="ViewModelToViewConverter"/> class.
        /// </summary>
        static CustomViewModelToViewConverter()
        {
            var dependencyResolver = IoCConfiguration.DefaultDependencyResolver;

            _viewLocator = dependencyResolver.Resolve<IViewLocator>();
        }

        /// <inheritdoc />
        /// <summary>
        /// Modifies the source data before passing it to the target for display in the UI.
        /// </summary>
        /// <param name="value">The source data being passed to the target.</param>
        /// <param name="targetType">The <see cref="T:System.Type" /> of data expected by the target dependency property.</param>
        /// <param name="parameter">An optional parameter to be used in the converter logic.</param>
        /// <returns>The value to be passed to the target dependency property.</returns>
        protected override object Convert(object value, Type targetType, object parameter)
        {
            if (CatelEnvironment.IsInDesignMode || (value == null))
            {
                return ConverterHelper.UnsetValue;
            }

            var viewType = _viewLocator.ResolveView(value.GetType());
            return (viewType != null) ? ViewHelper.ConstructViewWithViewModel(viewType, value) : ConverterHelper.UnsetValue;
        }

        
    }
}
