using System.Threading.Tasks;
using Catel.IoC;
using Catel.MVVM;
using Catel.MVVM.Views;
using Catel.Services;

namespace WPF.PRC.PBF
{
    public static class  CitizenshipExtensions
    {
        public static async Task<TViewModel> OpenEntityWindow<TEntity, TViewModel, TView>(this TEntity entity) where TEntity : ISuggestable
            where TViewModel : IViewModel
            where TView : IView
        {
            var serviceLocator = ServiceLocator.Default;
            var typeFactory = serviceLocator.ResolveType<ITypeFactory>();
            var uiVisualizerService = serviceLocator.ResolveType<IUIVisualizerService>();

            var viewModel = typeFactory.CreateInstanceWithParametersAndAutoCompletion<TViewModel>(entity);
            if (!uiVisualizerService.IsRegistered(typeof(TViewModel)))
                uiVisualizerService.Register(typeof(TViewModel), typeof(TView));

            if (await uiVisualizerService.ShowDialogAsync(viewModel) ?? false)
            {
                if (uiVisualizerService.IsRegistered(typeof(TViewModel))) uiVisualizerService.Unregister(typeof(TViewModel));
                return viewModel;
            }

            if (uiVisualizerService.IsRegistered(typeof(TViewModel))) uiVisualizerService.Unregister(typeof(TViewModel));
            return default(TViewModel);
        }
    }
}
