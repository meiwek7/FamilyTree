using BasicLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Client.ViewModel
{
    class MainWindowViewModel:ViewModelBase
    {
        ObservableCollection<Character> characters;
        public MainWindowViewModel()
        {
            characters = new ObservableCollection<Character>();
            Character NewChar1 = new Character("Vasya", "Pupkin");
            Character NewChar2 = new Character("Anton", "Chetkiy");
            NewChar1.Top = 10;
            NewChar1.Left = 10;
            NewChar2.Top = 10;
            NewChar2.Left = 200;
            characters.Add(NewChar1);
            characters.Add(NewChar2);
        }

        public ObservableCollection<Character> Characters { get{ return characters; } set { characters = value; OnPropertyChanged("Characters"); } }
    }
}
