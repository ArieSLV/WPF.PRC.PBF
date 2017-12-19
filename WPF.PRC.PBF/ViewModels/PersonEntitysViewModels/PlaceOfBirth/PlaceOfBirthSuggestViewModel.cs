using Catel.Messaging;
using WPF.PRC.PBF.Services.Interfaces;

namespace WPF.PRC.PBF
{
    class PlaceOfBirthSuggestViewModel : SuggestModule<PlaceOfBirth>
    {
        public PlaceOfBirthSuggestViewModel(IDataBaseService dataBaseService, IMessageMediator messageMediator) : base(dataBaseService, messageMediator)
        {
        }
    }
}
