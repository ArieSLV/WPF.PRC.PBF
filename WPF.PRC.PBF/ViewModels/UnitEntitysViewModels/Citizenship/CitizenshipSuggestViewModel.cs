using Catel.Data;
using Catel.Messaging;
using Catel.MVVM.Views;
using WPF.PRC.PBF.Services.Interfaces;

namespace WPF.PRC.PBF
{
    /// <summary>
    ///     ViewModel юзерконтрола для поиска и выбора Гражданства
    /// </summary>
    public class CitizenshipSuggestViewModel : SuggestModule<Citizenship>
    {
        public CitizenshipSuggestViewModel(IDataBaseService dataBaseService, IMessageMediator messageMediator) : base(dataBaseService, messageMediator)
        {
            
        }

        

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

        

    }
}