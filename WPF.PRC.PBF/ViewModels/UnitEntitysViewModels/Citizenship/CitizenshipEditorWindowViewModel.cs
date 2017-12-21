using Catel;
using Catel.MVVM;

namespace WPF.PRC.PBF
{
    public class CitizenshipEditorWindowViewModel : ViewModelBase
    {
        public override string Title => "Редактирование гражданства";
        
        public CitizenshipEditorWindowViewModel(Citizenship citizenship)
        {
            Argument.IsNotNull("citizenship", citizenship);

            Citizenship = citizenship;
        }

        [Model]
        public Citizenship Citizenship { get; set; }
    }
}
