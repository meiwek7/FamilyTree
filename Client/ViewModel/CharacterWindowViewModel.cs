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
        String dateBirth;
        String dateDeath;
        Character curChar;
        public CharacterWindowViewModel()
        {
            curChar = new Character();
        }
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

        public string DateBirth { get { return dateBirth; } set { dateBirth = value; } }
        public string DateDeath {
            get {
                if (curChar.DeathDate == DateTime.MinValue || curChar.DeathDate == null)
                    return "StillAlive";
                else
                    dateDeath = CurChar.DeathDate.ToShortDateString();
                return "StillAlive";
            }
            set {
                dateDeath = value;
                OnPropertyChanged("DateDeath");
            }
        }

        void ExecuteOnClosing(object param)
        {
            WindowViewLoaderService.closeWindow(this);
        }
    }
}