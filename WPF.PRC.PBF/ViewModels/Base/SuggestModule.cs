using System.Collections.ObjectModel;
using System.Windows.Data;
using Catel;
using Catel.Data;
using Catel.MVVM;
using WPF.PRC.PBF.Services.Interfaces;

namespace WPF.PRC.PBF
{
    public class SuggestModule<TEntity> : ViewModelBase 
        where TEntity : class, ISuggestable, new()
    {
        #region Private fields

        private readonly char[] _delimiterChars = {' ', ',', '.', ':', ';'};
        private int _filtredItemsCounter;
        private readonly IDataBaseService _dataBaseService;

        #endregion


        #region Default constructor

        public SuggestModule(IDataBaseService dataBaseService)
        {
            Argument.IsNotNull(() => dataBaseService);
            _dataBaseService = dataBaseService;

            //Загрузка данных из контекста
            var collection = _dataBaseService.LoadObservableCollectionOf<TEntity>();
            ItemsCollection = new ObservableCollection<TEntity>(collection);

            //Сортировка данных
            ItemsCollection.Sort();
        }

        #endregion

        
        #region Public properties

        #region SearchText property

        public string SearchText
        {
            get => GetValue<string>(SearchTextProperty);
            set => SetValue(SearchTextProperty, value);
        }

        public static readonly PropertyData SearchTextProperty = RegisterProperty("SearchText", typeof(string), null,
            (sender, e) => ((SuggestModule<TEntity>)sender).SearchTextTextChanged());

        #endregion

        #region SelectedItem property

        /// <summary>
        ///     Gets or sets the SelectedItem value.
        /// </summary>
        public TEntity SelectedItem
        {
            get => GetValue<TEntity>(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        /// <summary>
        ///     SelectedItem property data.
        /// </summary>
        public static readonly PropertyData SelectedItemProperty =
            RegisterProperty("SelectedItem", typeof(TEntity), null,
                (sender, e) => ((SuggestModule<TEntity>) sender).OnSelectedItemChanged());

        

        
        #endregion

        #region ItemsCollection property

        public ObservableCollection<TEntity> ItemsCollection
        {
            get => GetValue<ObservableCollection<TEntity>>(ItemsCollectionProperty);
            set => SetValue(ItemsCollectionProperty, value);
        }

        public static readonly PropertyData ItemsCollectionProperty =
            RegisterProperty("ItemsCollection", typeof(ObservableCollection<TEntity>));

        #endregion

        #endregion


        #region Commands

        #region AddNewEntry command

        private Command _addNewEntryCommand;

        /// <summary>
        ///     Gets the AddNewEntry command.
        /// </summary>
        public Command AddNewEntryCommand => _addNewEntryCommand ?? (_addNewEntryCommand = new Command(AddNewEntry));

        /// <summary>
        ///     Method to invoke when the AddNewEntry command is executed.
        /// </summary>
        public virtual void AddNewEntry()
        {
            // TODO: Handle command logic in derived class
        }
        
        #endregion

        #endregion


        #region Methods

        

        /// <summary>
        ///     Method to invoke when the SearchText changed.
        /// </summary>
        private void SearchTextTextChanged()
        {
            //Обнуляем счётчик отфильтрованных Item'ов
            _filtredItemsCounter = 0;


            //Фильтрация
            CollectionViewSource.GetDefaultView(ItemsCollection).Filter = item =>
            {
                var tEntity = item as TEntity;

                foreach (var filterWord in SearchText.ToLower().Split(_delimiterChars))

                    if (tEntity != null && !tEntity.ToString().ToLower().Contains(filterWord.ToLower())) return false;

                _filtredItemsCounter += 1;

                if (_filtredItemsCounter == 1) SelectedItem = tEntity;

                return true;
            };

            if (SearchText.Length <= 0) SelectedItem = null;

            ////Отправляем выбранный Item
            //if (_filtredItemsCounter == 1)
            //    Messenger.Default.Send(new NotificationMessage(SelectedItem, typeof(TEntity).ToString()));
        }

        /// <summary>
        /// Called when the SelectedItem property has changed.
        /// </summary>
        public virtual void OnSelectedItemChanged() { }

        #endregion
    }
}
