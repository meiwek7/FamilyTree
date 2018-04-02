using BasicLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Client.Infrastructure;

namespace Client.ViewModel
{
    class MainWindowViewModel:ViewModelBase
    {
        House house;

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
            var tmp = (WindowViewLoaderService.getContext(typeof(AuthorizationViewModel)) as AuthorizationViewModel).User;
            var house = ConLogic.MainProxy.getHouse((WindowViewLoaderService.getContext(typeof(AuthorizationViewModel))as AuthorizationViewModel).User);
            return house;
        }

        public List<Character> Characters {
            get
            {
                return House.HouseMembers;
            }
            set
            {
                House.HouseMembers = value;
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