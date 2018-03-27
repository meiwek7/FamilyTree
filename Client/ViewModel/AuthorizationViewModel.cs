using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLib;
using Client.Infrastructure;
using System.Windows.Input;
using System.Windows.Controls;
using Client.View;
using Client.ViewModel.Behaviors;

namespace Client.ViewModel
{
    class AuthorizationViewModel : ViewModelBase
    {
        User user;
        RelayCommand _enterCommand;
        RelayCommand _registerCommand;

        public AuthorizationViewModel()
        {
            user = new User();
            
        }

        public User User { get { return user; } set { user = value; } }

        #region Enter
        public ICommand EnterCommand { get {
                if(_enterCommand==null)
                {
                    _enterCommand = new RelayCommand(ExecuteEnterCommand, CanExecuteEnterCommand);
                }
                return _enterCommand;
            } }
        private void ExecuteEnterCommand(object param)
        {
            var result = ConLogic.Proxy.Auth(user);
        }
        private bool CanExecuteEnterCommand(object param)
        {
            return true;
        }
        #endregion
        public ICommand RegisterCommand
        {
            get
            {
                if(_registerCommand == null)
                {
                    _registerCommand = new RelayCommand(ExecuteRegisterCommand);
                }
                return _registerCommand;
            }
        }
        private void ExecuteRegisterCommand(object obj)
        {
            WindowViewLoaderService.Show(typeof(RegisterViewModel));
        }
    }
}
