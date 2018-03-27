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
            var pas = param as PasswordBox;
            var str = pas.Password;
            var result = ConLogic.Proxy.Auth(user);
        }
        private bool CanExecuteEnterCommand(object param)
        {
          
            return true;
        }
        #endregion
        public User User { get { return user; } set { user = value; } }

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
            Register RegisterWindow = new Register();
            RegisterWindow.Show();
        }
    }
}
