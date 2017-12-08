using System.Collections.ObjectModel;

namespace WPF.PRC.PBF.Services.Interfaces
{
    public interface IDataBaseService
    {
        ObservableCollection<T> LoadObservableCollectionOf<T>() where T : ISuggestable;
    }
}