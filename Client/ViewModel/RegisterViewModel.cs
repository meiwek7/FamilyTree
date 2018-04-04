using Client.Infrastructure;
using Client.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BasicLib;

namespace Client.ViewModel
{
    class RegisterViewModel : ViewModelBase
    {
        User futureUser;
        RelayCommand _closeCommand;
        RelayCommand _registerCommand;

        public RegisterViewModel()
        {
            futureUser = new User();
        }

        #region CloseCommand
        public ICommand CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(ExecuteCloseCommand);
                }
                return _closeCommand;
            }
        }
        private void ExecuteCloseCommand(object obj)
        {
            Register RegisterWindow = obj as Register;
            RegisterWindow.Close();
        }
        #endregion
        #region RegisterCommand
        public ICommand RegisterCommand
        {
            get
            {
                if (_registerCommand == null)
                {
                    _registerCommand = new RelayCommand(ExecuteRegisterCommand, CanExecuteRegisterCommand);
                }
                return _registerCommand;
            }
        }

        public User FutureUser { get { return futureUser; } set { futureUser = value; } }

        private void ExecuteRegisterCommand(object obj)
        {
            RegisterResult result = ConLogic.AuthProxy.RegisterUser(futureUser);
            switch (result)
            {
                case RegisterResult.UserRegSuccess:
                    // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    (obj as Register).Close();
                    break;
                case RegisterResult.SomethingWentWrong:
                    //DoSomething
                    break;
            }
        }
        private bool CanExecuteRegisterCommand(object param)
        {
            if (futureUser.Email == "" || futureUser.Email == null || futureUser.Email.Length > 40)
                return false;
            if (futureUser.Password == "" || futureUser.Password == null || futureUser.Password.Length > 30)
                return false;
            else
                return true;
        }
        #endregion

    }
}
