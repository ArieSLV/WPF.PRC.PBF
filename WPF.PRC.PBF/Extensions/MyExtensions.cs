using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     Набор расширений
    /// </summary>
    public static class MyExtensions
    {
        [Obsolete]
        public static ObservableCollection<T> GetEntityObservableCollection<T>(this DbContext ctx) where T : ISuggestable
        {
            try
            {
                var key = typeof(T).Name;
                var adapter = (IObjectContextAdapter)ctx;
                var objectContext = adapter.ObjectContext;

                var container = objectContext.MetadataWorkspace.GetEntityContainer(objectContext.DefaultContainerName,
                    System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);

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

        /// <summary>
        /// Сортировка <see cref="ObservableCollection{T}"/> из элементов, реализующих <see cref="ISuggestable"/> интерфейс
        /// </summary>
        /// <typeparam name="T">ISuggestable</typeparam>
        /// <param name="collection"></param>
        public static void Sort<T>(this ObservableCollection<T> collection) where T : ISuggestable
        {
            var sorted = collection.OrderBy(x => x).ToList();
            for (var i = 0; i < sorted.Count; i++)
                collection.Move(collection.IndexOf(sorted[i]), i);
        }

        #region Obsolete methods

        public static object GetIDPropertyValue<T>(this T obj) where T : ISuggestable
        {
            var t = typeof(T);
            if (t.BaseType?.Name == "ModelBase") return t.GetProperty($"{t.Name}Id").GetValue(obj, null);

            return t.GetProperty($"{t.BaseType.Name}Id").GetValue(obj, null);
        }

        [Obsolete]
        public static void SetMainPropertyValue<T>(this T obj, object valueToSet) where T : ISuggestable
        {
            var t = typeof(T);
            t.GetProperty(t.GetField("MainField").GetValue(obj).ToString()).SetValue(obj, valueToSet);
        }

        [Obsolete]
        public static object GetFieldValue<T>(this T obj, string name) where T : ISuggestable
        {
            var t = typeof(T);
            return t.GetField($"<{name}>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)
                ?.GetValue(obj);
        }

        [Obsolete]
        public static object GetMainPropertyName<T>(this T obj) where T : ISuggestable
        {
            try
            {
                var t = typeof(T);
                return t.GetField("<MainField>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.GetValue(obj);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid Entity Type supplied for Lookup", ex);
            }
        }

        [Obsolete]
        public static object GetEntityMainPropertyValue<T>(this T obj) where T : ISuggestable
        {
            var t = typeof(T);
            return obj == null
                ? default(object)
                : t.GetProperty(t.GetField("<MainField>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(obj).ToString()).GetValue(obj, null);
        }

        [Obsolete]
        public static object GetEntityDefaultValue<T>(this T obj) where T : ISuggestable
        {
            var t = typeof(T);
            if (obj == null) return default(object);

            return t.GetField("<DefaultValue>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic)
                .GetValue(obj);
        }

        [Obsolete]
        public static T GetDefaultCollectionItem<T>(this ObservableCollection<T> obj) where T : ISuggestable
        {
            return obj.SingleOrDefault(o =>
            {
                if (o.GetEntityMainPropertyValue() == null || o.GetFieldValue("DefaultValue") == null) return false;

                var defaultEntityValue = o.GetEntityMainPropertyValue().ToString();
                var defaultFieldValue = o.GetFieldValue("DefaultValue").ToString();
                return defaultEntityValue == defaultFieldValue;
            });
        }

        [Obsolete]
        public static DbSet GetDbSet<T>(this DbContext ctx)
        {
            try
            {
                var dbSet = ctx.Set(typeof(T));
                return dbSet;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid Entity Type supplied for Lookup", ex);
            }
        }

        //public static AsYouTypeFormatter RemoveLastDigit(this AsYouTypeFormatter asYouTypeFormatter)
        //{
        //    var tmpString = asYouTypeFormatter.InputDigit(' ');
        //    var tmpaytf = new AsYouTypeFormatter("RU");

        //    foreach (var character in tmpString.Substring(0, tmpString.Length - 3))
        //    {
        //        if (character != ' ' && character != '-') tmpaytf.InputDigit(character);
        //    }


        //    return tmpaytf;
        //}
        
        //[Obsolete]
        //public static string GetRawText(this MaskedTextBox maskedTextBox)
        //{
        //    var maskedTextProvider = maskedTextBox?.MaskedTextProvider;

        //    return maskedTextProvider?.ToString(true, false, false, 0, maskedTextProvider.Length) ?? string.Empty;
        //}

        [Obsolete]
        public static DependencyObject GetRootControl(this DependencyObject reference)
        {
            var parentDependencyObject = VisualTreeHelper.GetParent(reference);

            DependencyObject rootElement = null;

            while (parentDependencyObject != null)
            {
                rootElement = parentDependencyObject;
                parentDependencyObject = VisualTreeHelper.GetParent(parentDependencyObject);
            }

            return rootElement;
        }
        
        //public static IViewModel GetRootIViewModel(this ViewModelBase reference)
        //{
        //    var parentViewModel = reference.ParentViewModel;

        //    IViewModel rootViewModel = null;

        //    while (parentViewModel != null)
        //    {
        //        rootViewModel = parentViewModel;
        //        parentViewModel = ((ViewModelBase)parentViewModel).ParentViewModel;
        //    }

        //    return rootViewModel;
        //}

        //public static int GetTabIndexOfRootUsercontrol(this DependencyObject dependencyObject)
        //{
        //    var parentDependencyObject = VisualTreeHelper.GetParent(dependencyObject);

        //    DependencyObject rootElement = null;

        //    while (!(parentDependencyObject is UserControl))
        //    {
        //        parentDependencyObject = VisualTreeHelper.GetParent(parentDependencyObject);
        //        rootElement = parentDependencyObject;
        //    }

        //    var test = 0;
        //    var frameworkElement = (FrameworkElement)rootElement;
        //    if (frameworkElement?.Parent != null) test = ((Control) frameworkElement.Parent).TabIndex;

        //    return test;
        //}

        //public static ObservableCollection<Unit> GetAuthorizedUnitsCollection(this ShareholderAccount sha)
        //{
        //    var unitsCollectionForReturn = new ObservableCollection<Unit>();

        //    using (var dbContextManager = DbContextManager<PBFContext>.GetManager())
        //    {
        //        var shads = new ObservableCollection<ShareholderAuthorizesDocument>(dbContextManager.Context.ShareholderAuthorizesDocuments
        //            .Where(o => o.WhoGivingAuthority.ShareholderAccountId == sha.ShareholderAccountId));
        //        foreach (var authorizedUnit in shads.SelectMany(shad => shad.AuthorizedUnits))
        //        {
        //            unitsCollectionForReturn.Add(authorizedUnit);
        //        }
        //    }

        //    return unitsCollectionForReturn;
        //}

        #endregion

    }
}