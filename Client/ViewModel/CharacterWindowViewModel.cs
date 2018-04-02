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
        Character curChar;
                public Character CurChar
                {
                    get
                    {
                        return curChar;
                    }

                    set
                    {
                        curChar = value;
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
             }
    #endregion
}




