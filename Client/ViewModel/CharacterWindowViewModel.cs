using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLib;
using System.Windows.Input;
using Client.Infrastructure;

namespace Client.ViewModel
{
    class CharacterWindowViewModel : ViewModelBase
    {
        RelayCommand _biographyCommand;
        RelayCommand onClosingCommand;
        Character curChar;
        public Character CurChar
        {
            get
            {
                //if(curChar==null)
                
                return curChar;
            }

            set
            {
                curChar = value;
                OnPropertyChanged("CurChar");
            }
        }
        #region Biography
        public ICommand BiographyCommand
               {
                    get
                    {
                        if (_biographyCommand == null)
                        {
                            _biographyCommand = new RelayCommand(ExecuteBiographyCommand);
                        }
                        return _biographyCommand;
                    }
                }
        void ExecuteBiographyCommand(object bio)
        {
            WindowViewLoaderService.Show(typeof(CharacterWindowViewModel));
        }
        #endregion
        public ICommand OnClosing
        {
            get
            {
                if (onClosingCommand == null)
                {
                    onClosingCommand = new RelayCommand(ExecuteOnClosing);
                }
                return onClosingCommand;
            }
        }
        void ExecuteOnClosing(object param)
        {
            WindowViewLoaderService.closeWindow(this);
        }
    }
}