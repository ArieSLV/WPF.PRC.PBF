﻿using System.Windows.Forms;
using Catel.MVVM;
using WPF.PRC.PBF.Services;
using WPF.PRC.PBF.Services.Interfaces;
using WPF.PRC.PBF.Views.UserControls;

namespace WPF.PRC.PBF
{
    using System.Windows;
    using Catel.ApiCop;
    using Catel.ApiCop.Listeners;
    using Catel.IoC;
    using Catel.Logging;
    using Catel.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        protected override void OnStartup(StartupEventArgs e)

        {
#if DEBUG
            LogManager.AddDebugListener();
#endif

            Log.Info("Starting application");

            // Want to improve performance? Uncomment the lines below. Note though that this will disable
            // some features. 
            //
            // For more information, see http://docs.catelproject.com/vnext/faq/performance-considerations/

            // Log.Info("Improving performance");
            // Catel.Windows.Controls.UserControl.DefaultCreateWarningAndErrorValidatorForViewModelValue = false;
            // Catel.Windows.Controls.UserControl.DefaultSkipSearchingForInfoBarMessageControlValue = true;

            // TODO: Register custom types in the ServiceLocator
            Log.Info("Registering custom types");
            var serviceLocator = ServiceLocator.Default;
            serviceLocator.RegisterType<IDataBaseService, DataBaseService>();
            serviceLocator.RegisterType<ICitizenshipRepository, CitizenshipRepository>(RegistrationType.Transient);
            

            Log.Info("Ручное сопоставление View и ViewModel");
            var viewLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            viewLocator.Register(typeof(SuggestUserControl), typeof(SuggestUserControlViewModel));
            viewLocator.Register(typeof(CitizenshipEditorWindow), typeof(CitizenshipEditorWindowViewModel));

            var viewModelLovator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            viewModelLovator.Register(typeof(SuggestUserControlViewModel), typeof(SuggestUserControl));
            viewModelLovator.Register(typeof(CitizenshipEditorWindowViewModel), typeof(CitizenshipEditorWindow));

            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));

            Log.Info("Calling base.OnStartup");
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // Get advisory report in console
            ApiCopManager.AddListener(new ConsoleApiCopListener());
            ApiCopManager.WriteResults();

            base.OnExit(e);
        }
    }
}