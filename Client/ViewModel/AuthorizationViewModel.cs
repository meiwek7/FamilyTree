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
using System.Windows.Controls.Primitives;

namespace Client.ViewModel
{
    class AuthorizationViewModel : ViewModelBase
    {
        User user;
        RelayCommand _enterCommand;
        RelayCommand _registerCommand;
        bool popupPass = false;
        bool popupMail = false;

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
            if (result == true)
                WindowViewLoaderService.Show(typeof(MainWindowViewModel));
            else
                PopupPass = true;
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

        public bool PopupPass { get {return popupPass;  }    set { popupPass = value; OnPropertyChanged("PopupPass"); } }
        public bool PopupMail { get { return popupMail; }    set { popupMail = value; } }

        private void ExecuteRegisterCommand(object obj)
        {
            WindowViewLoaderService.Show(typeof(RegisterViewModel));
        }
    }
}
