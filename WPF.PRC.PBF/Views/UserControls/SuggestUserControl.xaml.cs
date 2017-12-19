using System.Windows;
using Catel.MVVM.Views;
using WPF.PRC.PBF.ViewModels.Enums;

namespace WPF.PRC.PBF.Views.UserControls
{
    public partial class SuggestUserControl
    {
        static SuggestUserControl()
        {
            typeof(SuggestUserControl).AutoDetectViewPropertiesToSubscribe();
        }
        
        public SuggestUserControl()
        {
            InitializeComponent();
        }

        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public SuggestEntityType EntityType
        {
            get => (SuggestEntityType) GetValue(EntityTypeProperty);
            set => SetValue(EntityTypeProperty, value);
        }

        public static readonly DependencyProperty EntityTypeProperty = DependencyProperty.Register(
            "EntityType", typeof(SuggestEntityType), typeof(SuggestUserControl), new PropertyMetadata(default(SuggestEntityType)));
    }
}
