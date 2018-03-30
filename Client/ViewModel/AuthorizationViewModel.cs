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
            AuthErrors result = ConLogic.AuthProxy.Auth(user);
            switch (result)
            {
                case AuthErrors.EverythingIsFine:
                    WindowViewLoaderService.Show(typeof(MainWindowViewModel));
                    break;
                case AuthErrors.IncorrectPass:
                    PopupPass = true;
                    break;
                case AuthErrors.NoSuchUser:
                    PopupMail = true;
                    break;
            }
        }
        private bool CanExecuteEnterCommand(object param)
        {
            if (User.Email == "" || User.Email == null || User.Email.Length > 40)
                return false;
            if (User.Password == "" || User.Password == null || User.Password.Length > 30)
                return false;
            else
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
        public bool PopupMail { get { return popupMail; }    set { popupMail = value; OnPropertyChanged("PopupMail"); } }

        private void ExecuteRegisterCommand(object obj)
        {
            WindowViewLoaderService.Show(typeof(RegisterViewModel));
        }
    }
}
