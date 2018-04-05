using BasicLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Client.Infrastructure;
using Client.Model;
using System.Windows.Input;
using System.Windows;

namespace Client.ViewModel
{
    class MainWindowViewModel:ViewModelBase
    {
        House house;
        User futureUser;
        List<ClientCharacter> characters;

        RelayCommand addCommand;
        RelayCommand logCommand;

        public MainWindowViewModel()
        {
            //characters = new ObservableCollection<Character>();
            //Character NewChar1 = new Character("Vasya", "Pupkin");
            //Character NewChar2 = new Character("Anton", "Chetkiy");
            //NewChar1.Top = 10;
            //NewChar1.Left = 10;
            //NewChar2.Top = 10;
            //NewChar2.Left = 200;
            //characters.Add(NewChar1);
            //characters.Add(NewChar2);
        }

        public User FutureUser { get { return futureUser; } set { futureUser = value; } }

        private House InitializeCharacters()
        {
            var AuthCntxttmp = (WindowViewLoaderService.getContext(typeof(AuthorizationViewModel)) as AuthorizationViewModel);
            var tmpUser = AuthCntxttmp.User;
            var house = ConLogic.MainProxy.getHouse(tmpUser);
            return house;
        }

        public List<ClientCharacter> Characters {
            get
            {
                if(characters == null)
                {
                    List<ClientCharacter> tmp = new List<ClientCharacter>();
                    foreach (var item in House.HouseMembers)
                    {
                        tmp.Add(new ClientCharacter(item));
                    }
                    characters = tmp;
                }
                //return House.HouseMembers;
                return characters;
            }
            set
            {
                //House.HouseMembers = value;
                characters = value;
                OnPropertyChanged("Characters");
            }
        }

        public House House {
            get {
                if (house == null)
                    {
                    house = InitializeCharacters();
                }
                return house;
            }
            set {
                house = value;
                OnPropertyChanged("House");
            }
        }

        #region _addCommand

        public ICommand _addCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(ExecuteAddCommand);
                }
                return addCommand;
            }
        }

        private void ExecuteAddCommand(object obj)
        {
            //WindowViewLoaderService.Show(typeof(CharacterWindowViewModel));
            //var tmp = WindowViewLoaderService.getContext(typeof(CharacterWindowViewModel)) as CharacterWindowViewModel;
            //var CC = tmp.CurChar;
            var AuthCntxttmp = (WindowViewLoaderService.getContext(typeof(AuthorizationViewModel)) as AuthorizationViewModel);
            var tmpUser = AuthCntxttmp.User;
            /*house = */ConLogic.MainProxy.InsertNewCharacter(tmpUser, house);
            House = null;
            Characters = null; 
        }
        #endregion


        #region _logCommand

        public ICommand _logCommand
        {
            get
            {
                if (logCommand == null)
                {
                    logCommand = new RelayCommand(ExecuteLogCommand);
                }
                return logCommand;
            }
        }

        private void ExecuteLogCommand(object obj)
        {
            MessageBox.Show("Скоро!");
        }
        #endregion
    }
}