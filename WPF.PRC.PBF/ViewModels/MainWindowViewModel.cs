using System;
using System.Collections.Generic;
using Catel.Data;
using Catel;
using Catel.MVVM;
using System.Threading.Tasks;
using System.Windows;
using Catel.IoC;
using Catel.Messaging;
using Catel.MVVM.Views;
using Catel.Windows.Controls;

namespace WPF.PRC.PBF.ViewModels
{
    
    public class MainWindowViewModel : ViewModelBase
    {
        public override string Title => "Test";


        #region Private fields

        private readonly IMessageMediator _messageMediator;

        #endregion
        
        
        #region Default constructor

        public MainWindowViewModel(IMessageMediator messageMediator)
        {
            Argument.IsNotNull(() => messageMediator);
            
            _messageMediator = messageMediator;
            
            Person = new Person();
        }

        #endregion


        #region Public properties

        [Model]
        public Person Person { get; set; }
        
        [ViewModelToModel]
        public Citizenship Citizenship { get; set; }

        [ViewModelToModel]
        public PlaceOfBirth PlaceOfBirth { get; set; }

        #endregion

        
        #region Methods

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            _messageMediator.Register<ISuggestable>(this, entity =>
            {
                if (entity.GetType() == typeof(Citizenship))
                {
                    Citizenship = (Citizenship)entity;
                }
                else if(entity.GetType() == typeof(PlaceOfBirth))
                {
                    PlaceOfBirth = (PlaceOfBirth)entity;
                }
            });
        }

        protected override async Task CloseAsync()
        {
            // unsubscribe from events here

            await base.CloseAsync();
        }

        #endregion
    }
}
