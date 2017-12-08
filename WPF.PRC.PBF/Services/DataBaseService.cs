using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using WPF.PRC.PBF.Services.Interfaces;

namespace WPF.PRC.PBF.Services
{
    internal class DataBaseService : IDataBaseService
    {
        private readonly DbContext _db;

        public DataBaseService()
        {
            _db = new PBFDataContext();
        }

        public ObservableCollection<T> LoadObservableCollectionOf<T>() where T : ISuggestable
        {
            try
            {
                var key = typeof(T).Name;
                var adapter = (IObjectContextAdapter) _db;
                var objectContext = adapter.ObjectContext;

                var container = objectContext.MetadataWorkspace.GetEntityContainer(
                    objectContext.DefaultContainerName,
                    DataSpace.CSpace);

                //Если в данной строке происходит исключение, нужно проверить реализацию в прошлой версии
                var name = container.BaseEntitySets.FirstOrDefault(o => o.ElementType.Name.Equals(key))?.Name;

                var query = objectContext.CreateQuery<T>($"[{name}]");

                return new ObservableCollection<T>(query.AsEnumerable());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid Entity Type supplied for Lookup", ex);
            }
        }
    }
}