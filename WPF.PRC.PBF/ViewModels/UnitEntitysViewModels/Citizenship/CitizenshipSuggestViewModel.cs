
using WPF.PRC.PBF.Services.Interfaces;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     ViewModel юзерконтрола для поиска и выбора Гражданства
    /// </summary>
    public class CitizenshipSuggestViewModel : SuggestModule<Citizenship>
    {
        public CitizenshipSuggestViewModel(IDataBaseService dataBaseService) : base(dataBaseService)
        {
            
        }

        //#region Citizenship свойство

        ///// <summary>
        ///// Получает или устанавливает значение Citizenship.
        ///// </summary>
        //public Citizenship Citizenship
        //{
        //    get => GetValue<Citizenship>(CitizenshipProperty);
        //    set => SetValue(CitizenshipProperty, value);
        //}

        ///// <summary>
        ///// Citizenship property data.
        ///// </summary>
        //public static readonly PropertyData CitizenshipProperty = RegisterProperty<CitizenshipSuggestViewModel, Citizenship>(model => model.Citizenship);

        //#endregion

        //public override void OnAddCommand()
        //{
        //    var newCitizenship = new Citizenship {Value = SearchText};
        //    var viewModel = new CitizenshipEditorWindowViewModel(newCitizenship);
        //    var citizenshipEditorWindow = new CitizenshipEditorWindow {DataContext = viewModel};

        //    if (citizenshipEditorWindow.ShowDialog() == false) return;

        //    Messenger.Default.Send(
        //        new NotificationMessage(
        //            ((CitizenshipEditorWindowViewModel) citizenshipEditorWindow.DataContext).Citizenship,
        //            $"{typeof(Citizenship)}.AddToDB"));

            
        //    SearchText = string.Empty;
        //    SearchText = viewModel.Citizenship.ToString();
        //}

        //public override void OnSelectedItemChanged()
        //{
        //    Citizenship = SelectedItem;
        //}
    }
}