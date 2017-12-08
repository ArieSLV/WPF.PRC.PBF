using System.Windows;
using System.Windows.Interactivity;
using Catel.Windows.Controls;
using WPF.PRC.PBF.Views.UserControls;

namespace WPF.PRC.PBF
{
    internal class CloseControlOnDataContextNull : Behavior<UserControl>
    {
        protected override void OnAttached()
        {
            AssociatedObject.DataContextChanged += AssociatedObject_DataContextChanged;
        }

        private void AssociatedObject_DataContextChanged(object sender,
            DependencyPropertyChangedEventArgs e)
        {
            if (AssociatedObject.DataContext == null)
            {
                ((SuggestUserControl) sender).Popup.IsOpen = false;
                AssociatedObject.Visibility = Visibility.Collapsed;
            }
            else
            {
                AssociatedObject.Visibility = Visibility.Visible;
            }
        }
    }
}