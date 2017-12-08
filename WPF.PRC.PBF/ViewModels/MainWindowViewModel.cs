using Catel.Data;
using Catel.IoC;

namespace WPF.PRC.PBF.ViewModels
{
    using Catel;
    using Catel.MVVM;
    using System.Threading.Tasks;

    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Person person)
        {
            Argument.IsNotNull(()=>person);

            Person = person;
        }

        public override string Title => "Test";


        #region Person model

        /// <summary>
        /// Получает или устанавливает значение Person.
        /// </summary>
        [Model]
        public Person Person
        {
            get => GetValue<Person>(PersonProperty);
            set => SetValue(PersonProperty, value);
        }

        /// <summary>
        /// Person property data.
        /// </summary>
        public static readonly PropertyData PersonProperty = RegisterProperty<MainWindowViewModel, Person>(model => model.Person);

        #endregion

        #region Citizenship свойство

        /// <summary>
        /// Получает или устанавливает значение Citizenship.
        /// </summary>
        [ViewModelToModel("Person")]
        public Citizenship Citizenship
        {
            get => GetValue<Citizenship>(CitizenshipProperty);
            set => SetValue(CitizenshipProperty, value);
        }

        /// <summary>
        /// Citizenship property data.
        /// </summary>
        public static readonly PropertyData CitizenshipProperty = RegisterProperty<MainWindowViewModel, Citizenship>(model => model.Citizenship);

        #endregion

        #region CitizenshipViewModel свойство

        /// <summary>
        /// Получает или устанавливает значение CitizenshipViewModel.
        /// </summary>
        public IViewModel CitizenshipViewModel
        {
            get => GetValue<IViewModel>(CitizenshipViewModelProperty);
            set => SetValue(CitizenshipViewModelProperty, value);
        }

        /// <summary>
        /// CitizenshipViewModel property data.
        /// </summary>
        public static readonly PropertyData CitizenshipViewModelProperty = RegisterProperty<MainWindowViewModel, IViewModel>(model => model.CitizenshipViewModel);

        #endregion


        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            CitizenshipViewModel = this.GetTypeFactory().CreateInstance<CitizenshipSuggestViewModel>();
            
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }
    }
}
