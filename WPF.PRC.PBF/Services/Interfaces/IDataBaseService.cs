using System.Collections.ObjectModel;
using System.Data.Entity;

namespace WPF.PRC.PBF.Services.Interfaces
{
    public interface IDataBaseService
    {
        ObservableCollection<T> LoadObservableCollectionOf<T>() where T : ISuggestable;
    }
}