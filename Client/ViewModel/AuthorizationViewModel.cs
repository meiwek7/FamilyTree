using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLib;
using Client.Infrastructure;
using System.Windows.Input;

namespace Client.ViewModel
{
    class AuthorizationViewModel : ViewModelBase
    {
        User user;
        RelayCommand _enterCommand;

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
            var result = ConLogic.Proxy.Auth(user);
        }
        private bool CanExecuteEnterCommand(object param)
        {
            return true;
        }
        #endregion
        public User User { get { return user; } set { user = value; } }
    }
}
