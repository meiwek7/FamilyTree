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
        ObservableCollection<Character> characters;
        public MainWindowViewModel()
        {
            characters = new ObservableCollection<Character>();
            house = InitializeCharacters();
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
            var tmp = ConLogic.MainProxy.getHouse(new User());
            return tmp;
        }

        public ObservableCollection<Character> Characters { get{ return characters; } set { characters = value; OnPropertyChanged("Characters"); } }
        public House House { get { return house; } set { house = value; OnPropertyChanged("House"); } }
    }
}
