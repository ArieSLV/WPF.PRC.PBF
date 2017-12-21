using Catel.Windows;

namespace WPF.PRC.PBF
{
    public partial class CitizenshipEditorWindow : DataWindow
    {
        public CitizenshipEditorWindow(CitizenshipEditorWindowViewModel viewModel) : base (viewModel)
        {
            InitializeComponent();
        }    
    }
}
