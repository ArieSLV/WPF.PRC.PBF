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
        private readonly IMessageMediator _messageMediator;
        

        public MainWindowViewModel(IMessageMediator messageMediator)
        {
            Argument.IsNotNull(() => messageMediator);
            
            _messageMediator = messageMediator;
            

            Person = new Person();
        }

        public override string Title => "Test";


        #region Person model

        /// <summary>
        ///     Получает или устанавливает значение Person.
        /// </summary>
        [Model]
        public Person Person
        {
            get => GetValue<Person>(PersonProperty);
            private set => SetValue(PersonProperty, value);
        }

        /// <summary>
        ///     Person property data.
        /// </summary>
        public static readonly PropertyData PersonProperty =
            RegisterProperty<MainWindowViewModel, Person>(model => model.Person);

        #endregion

        #region Citizenship свойство

        /// <summary>
        /// Получает или устанавливает значение Citizenship.
        /// </summary>
        [ViewModelToModel]
        public Citizenship Citizenship
        {
            get => GetValue<Citizenship>(CitizenshipProperty);
            set => SetValue(CitizenshipProperty, value);
        }

        /// <summary>
        /// Citizenship property data.
        /// </summary>
        public static readonly PropertyData CitizenshipProperty = RegisterProperty<MainWindowViewModel, Citizenship>(model => model.Citizenship);

        #endregion

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            _messageMediator.Register<Citizenship>(this, citizenship =>
            {
                Citizenship = citizenship;
                
            });
        }

        protected override async Task CloseAsync()
        {
            // unsubscribe from events here

            await base.CloseAsync();
        }
    }
}
