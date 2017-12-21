using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using Catel;
using Catel.Data;
using Catel.IoC;
using Catel.Messaging;
using Catel.MVVM;
using Catel.MVVM.Views;
using Catel.Services;
using WPF.PRC.PBF.Services.Interfaces;
using WPF.PRC.PBF.ViewModels.Enums;

namespace WPF.PRC.PBF
{
    public class SuggestUserControlViewModel : ViewModelBase 
    {
        #region Private fields

        private readonly char[] _delimiterChars = {' ', ',', '.', ':', ';'};
        private int _filtredItemsCounter;
        private readonly IDataBaseService _dataBaseService;
        private readonly IMessageMediator _messageMediator;
        private readonly IUIVisualizerService _uiVisualizerService;

        #endregion


        #region Default constructor

        public SuggestUserControlViewModel(IDataBaseService dataBaseService, IMessageMediator messageMediator, IUIVisualizerService uiVisualizerService)
        {
            Argument.IsNotNull(() => dataBaseService);
            Argument.IsNotNull(() => messageMediator);
            Argument.IsNotNull(() => uiVisualizerService);

            _dataBaseService = dataBaseService;
            _messageMediator = messageMediator;
            _uiVisualizerService = uiVisualizerService;
        }

        #endregion


        #region Public properties

        /// <summary>
        ///     Текст текстового поля для фильтрации вариантов
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        ///     Получает или устанавливает значение выбранного варианта
        /// </summary>
        public ISuggestable SelectedItem { get; set; }

        /// <summary>
        ///     Коллекция элементов, из которой происходит выбор варианта
        /// </summary>
        public ObservableCollection<ISuggestable> ItemsCollection { get; set; }
        
        public SuggestEntityType EntityType { get; set; }
        
        #endregion


        #region Commands

        #region CompliteChoise command

        private Command _compliteChoiseCommand;

        /// <summary>
        ///     Gets the CompliteChoise command.
        /// </summary>
        public Command CompliteChoiseCommand => _compliteChoiseCommand ?? (_compliteChoiseCommand = new Command(CompliteChoise));

        /// <summary>
        ///     Method to invoke when the CompliteChoise command is executed.
        /// </summary>
        private void CompliteChoise()
        {
            if (SelectedItem == null) return;

            _messageMediator.SendMessage(SelectedItem);
        }

        #endregion
        
        #region AddNewEntity command

        private TaskCommand _addNewEntityCommand;

        /// <summary>
        /// Gets the AddNewEntity command.
        /// </summary>
        public TaskCommand AddNewEntityCommand => _addNewEntityCommand ?? (_addNewEntityCommand = new TaskCommand(AddNewEntity, CanAddNewEntity));

        /// <summary>
        /// Method to invoke when the AddNewEntity command is executed.
        /// </summary>
        private async Task AddNewEntity()
        {
            using (var uow = new UnitOfWork<PBFDataContext>())
            {
                switch (EntityType)
                {
                    case SuggestEntityType.Citizenship:
                        var citizenship = new Citizenship { Value = SearchText };

                        var citizenshipViewModel = await OpenEntityWindow<Citizenship, CitizenshipEditorWindowViewModel, CitizenshipEditorWindow>(citizenship);

                        if (citizenshipViewModel == null)
                        {
                            SearchText = string.Empty;
                            SelectedItem = null;
                        }
                        else SelectedItem = uow.GetRepository<ICitizenshipRepository>().AddIfNotExist(citizenshipViewModel.Citizenship);
                        
                        
                        break;
                    case SuggestEntityType.PlaceOfBirth:
                        break;
                    case SuggestEntityType.Unknown:
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                uow.SaveChanges();
                CompliteChoiseCommand.Execute();
                OnEntityTypeChanged();
            }
        }

        /// <summary>
        ///     Method to check whether the AddNewEntity command can be executed.
        /// </summary>
        /// <returns><c>true</c> if the command can be executed; otherwise <c>false</c></returns>
        private bool CanAddNewEntity()
        {
            return !string.IsNullOrWhiteSpace(SearchText);
        }
        
        #endregion

        #region EditEntity command

        private TaskCommand _editEntityCommand;

        /// <summary>
        ///     Gets the EditEntity command.
        /// </summary>
        public TaskCommand EditEntityCommand => _editEntityCommand ?? (_editEntityCommand = new TaskCommand(EditEntity));

        /// <summary>
        ///     Method to invoke when the EditEntity command is executed.
        /// </summary>
        private async Task EditEntity()
        {
            using (var uow = new UnitOfWork<PBFDataContext>())
            {
                switch (EntityType)
                {
                    case SuggestEntityType.Citizenship:
                        var citizenship = (Citizenship) SelectedItem;

                        var citizenshipViewModel = await ((Citizenship)SelectedItem).OpenEntityWindow<Citizenship, CitizenshipEditorWindowViewModel, CitizenshipEditorWindow>();

                        if (citizenshipViewModel != null)
                        {
                            uow.GetRepository<ICitizenshipRepository>().Update(citizenshipViewModel.Citizenship);
                            SelectedItem = citizenshipViewModel.Citizenship;
                            
                        }
                        else SelectedItem = null;
                        break;
                    case SuggestEntityType.PlaceOfBirth:
                        break;
                    case SuggestEntityType.Unknown:
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                CompliteChoiseCommand.Execute();
                OnEntityTypeChanged();
                uow.SaveChanges();
            }
        }

        #endregion

        #region DeleteEntity command

        private Command _deleteEntityCommand;

        /// <summary>
        /// Gets the DeleteEntity command.
        /// </summary>
        public Command DeleteEntityCommand => _deleteEntityCommand ?? (_deleteEntityCommand = new Command(DeleteEntity));

        /// <summary>
        /// Method to invoke when the DeleteEntity command is executed.
        /// </summary>
        private void DeleteEntity()
        {
            using (var uow = new UnitOfWork<PBFDataContext>())
            {
                switch (EntityType)
                {
                    case SuggestEntityType.Citizenship:
                        uow.GetRepository<ICitizenshipRepository>().Delete(citizenship =>
                            citizenship.CitizenshipId == ((Citizenship) SelectedItem).CitizenshipId);
                        SelectedItem = null;
                        break;
                    case SuggestEntityType.PlaceOfBirth:
                        break;
                    case SuggestEntityType.Unknown:
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                uow.SaveChanges();
                CompliteChoiseCommand.Execute();
                OnEntityTypeChanged();
            }
        }

        #endregion

        #endregion


        #region Methods

        /// <summary>
        ///     A method that opens the entity edit window in which the entity is edited and the edited entity is returned
        /// </summary>
        /// <typeparam name="TEntity">Type of entity being edited</typeparam>
        /// <typeparam name="TViewModel">ViewModel of type of entity being edited</typeparam>
        /// <typeparam name="TView">Model of type of entity being edited</typeparam>
        /// <param name="entity">Entity to edit</param>
        /// <returns>ViewModel with edited entity</returns>
        private async Task<TViewModel> OpenEntityWindow<TEntity, TViewModel, TView>(TEntity entity) where TEntity    : ISuggestable
                                                                                                    where TViewModel : IViewModel
                                                                                                    where TView      : IView
        {
            var typeFactory = this.GetTypeFactory();
            var viewModel = typeFactory.CreateInstanceWithParametersAndAutoCompletion<TViewModel>(entity);
            if (!_uiVisualizerService.IsRegistered(typeof(TViewModel)))
                _uiVisualizerService.Register(typeof(TViewModel), typeof(TView));

            if (await _uiVisualizerService.ShowDialogAsync(viewModel) ?? false)
            {
                if (_uiVisualizerService.IsRegistered(typeof(TViewModel))) _uiVisualizerService.Unregister(typeof(TViewModel));
                return viewModel;
            }

            if (_uiVisualizerService.IsRegistered(typeof(TViewModel))) _uiVisualizerService.Unregister(typeof(TViewModel));
            return default(TViewModel);
        }
        
        /// <summary>
        ///     Method to invoke when the SearchText changed.
        /// </summary>
        private void OnSearchTextChanged()
        {
            //Обнуляем счётчик отфильтрованных Item'ов
            _filtredItemsCounter = 0;


            //Фильтрация
            CollectionViewSource.GetDefaultView(ItemsCollection).Filter = item =>
            {
                var tEntity = item as ISuggestable;


                if (SearchText.ToLower().Split(_delimiterChars).Any(filterWord => tEntity != null && !tEntity.ToString().ToLower().Contains(filterWord.ToLower())))
                {
                    return false;
                }
                
                _filtredItemsCounter += 1;

                if (_filtredItemsCounter == 1) SelectedItem = tEntity;

                return true;
            };

            if (SearchText.Length <= 0) SelectedItem = null;
        }

        /// <summary>
        ///     Method to invoke when the EntityType changed
        /// </summary>
        private void OnEntityTypeChanged()
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
        }

        #endregion
    }
}
