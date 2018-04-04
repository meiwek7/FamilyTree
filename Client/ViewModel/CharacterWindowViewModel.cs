using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLib;
using System.Windows.Input;
using Client.Infrastructure;
using System.Windows;

namespace Client.ViewModel
{
    class CharacterWindowViewModel : ViewModelBase
    {
        RelayCommand _biographyCommand;
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
            MessageBox.Show("Следующий спринт!");
                    // НАПИСАТЬ ФУНКЦИОНАЛ
                }
             }
    #endregion
}




