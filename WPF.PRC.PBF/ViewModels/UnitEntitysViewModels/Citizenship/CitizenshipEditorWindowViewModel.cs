using Catel.MVVM;

namespace WPF.PRC.PBF
{
    class CitizenshipEditorWindowViewModel : ViewModelBase
    {
        public CitizenshipEditorWindowViewModel(Citizenship citizenship)
        {
            Citizenship = citizenship ?? new Citizenship();
        }

        public Citizenship Citizenship { get; set; }

       

       
    }
}
