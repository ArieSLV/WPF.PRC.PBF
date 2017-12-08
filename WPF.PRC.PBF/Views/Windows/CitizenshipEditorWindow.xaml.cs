using System;
using System.Windows;

namespace WPF.PRC.PBF
{
    /// <summary>
    /// Interaction logic for CitizenshipEditorWindow.xaml
    /// </summary>
    public partial class CitizenshipEditorWindow : Window
    {
        public CitizenshipEditorWindow()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
