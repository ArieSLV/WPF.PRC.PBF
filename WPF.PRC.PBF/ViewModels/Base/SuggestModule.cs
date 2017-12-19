using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Data;
using Catel;
using Catel.Data;
using Catel.IoC;
using Catel.Messaging;
using Catel.MVVM;
using Catel.MVVM.Views;
using WPF.PRC.PBF.Services.Interfaces;
using WPF.PRC.PBF.ViewModels.Enums;

namespace WPF.PRC.PBF
{
    public class SuggestModule : ViewModelBase 
    {
        #region Private fields

        private readonly char[] _delimiterChars = {' ', ',', '.', ':', ';'};
        private int _filtredItemsCounter;
        private readonly IDataBaseService _dataBaseService;
        private readonly IMessageMediator _messageMediator;

        #endregion


        #region Default constructor

        public SuggestModule(IDataBaseService dataBaseService, IMessageMediator messageMediator)
        {
            Argument.IsNotNull(() => dataBaseService);
            Argument.IsNotNull(() => messageMediator);

            _dataBaseService = dataBaseService;
            _messageMediator = messageMediator;
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
            (sender, e) => ((SuggestModule)sender).OnSearchTextTextChanged());

        #endregion

        #region SelectedItem property

        /// <summary>
        ///     Gets or sets the SelectedItem value.
        /// </summary>
        public ISuggestable SelectedItem
        {
            get => GetValue<ISuggestable>(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        /// <summary>
        ///     SelectedItem property data.
        /// </summary>
        public static readonly PropertyData SelectedItemProperty =
            RegisterProperty("SelectedItem", typeof(ISuggestable), null,
                (sender, e) => ((SuggestModule) sender).OnSelectedItemChanged());
        
        #endregion
        
        #region ItemsCollection property

        public ObservableCollection<ISuggestable> ItemsCollection
        {
            get => GetValue<ObservableCollection<ISuggestable>>(ItemsCollectionProperty);
            set => SetValue(ItemsCollectionProperty, value);
        }

        public static readonly PropertyData ItemsCollectionProperty =
            RegisterProperty("ItemsCollection", typeof(ObservableCollection<ISuggestable>));

        #endregion

        #region EntityType свойство

        /// <summary>
        /// Получает или устанавливает значение EntityType.
        /// </summary>
        public SuggestEntityType EntityType
        {
            get => GetValue<SuggestEntityType>(EntityTypeProperty);
            set => SetValue(EntityTypeProperty, value);
        }

        /// <summary>
        /// EntityType property data.
        /// </summary>
        public static readonly PropertyData EntityTypeProperty = RegisterProperty<SuggestModule, SuggestEntityType>(model => model.EntityType);

        #endregion

        #endregion


        #region Commands

        #region CompliteChoise command

        private TaskCommand _compliteChoiseCommand;

        /// <summary>
        ///     Gets the CompliteChoise command.
        /// </summary>
        public TaskCommand CompliteChoiseCommand => _compliteChoiseCommand ?? (_compliteChoiseCommand = new TaskCommand(CompliteChoise));

        /// <summary>
        ///     Method to invoke when the CompliteChoise command is executed.
        /// </summary>
        private async Task CompliteChoise()
        {
            if (SelectedItem == null) return;

            var views = ServiceLocator.Default.ResolveType<IViewManager>().GetViewsOfViewModel(this);
            
            views[0].DataContext = null;

            _messageMediator.SendMessage(SelectedItem);
        }

        #endregion


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
        private void OnSearchTextTextChanged()
        {
            //Обнуляем счётчик отфильтрованных Item'ов
            _filtredItemsCounter = 0;


            //Фильтрация
            CollectionViewSource.GetDefaultView(ItemsCollection).Filter = item =>
            {
                var tEntity = item as ISuggestable;

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

        protected override Task InitializeAsync()
        {
            IEnumerable<ISuggestable> collection = new ObservableCollection<ISuggestable>();
            switch (EntityType)
            {
                case SuggestEntityType.PlaceOfBirth:
                    collection = _dataBaseService.LoadObservableCollectionOf<PlaceOfBirth>();
                    break;
                case SuggestEntityType.Citizenship:
                    collection = _dataBaseService.LoadObservableCollectionOf<Citizenship>();
                    break;
            }
            ItemsCollection = new ObservableCollection<ISuggestable>(collection);
            ItemsCollection.Sort();

            return base.InitializeAsync();
        }

        #endregion
    }
}
