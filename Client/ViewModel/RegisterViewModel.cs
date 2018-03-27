using Client.Infrastructure;
using Client.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModel
{
    class RegisterViewModel : ViewModelBase
    {
        RelayCommand _closeCommand;
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
    }
}
