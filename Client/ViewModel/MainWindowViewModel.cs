using BasicLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Client.Infrastructure;
using Client.Model;

namespace Client.ViewModel
{
    class MainWindowViewModel:ViewModelBase
    {
        House house;
        List<ClientCharacter> characters;
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
    }
}