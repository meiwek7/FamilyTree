using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLib;
using System.Windows.Input;
using Client.Infrastructure;
using System.Windows;
using System.IO;

namespace Client.ViewModel
{
    class CharacterWindowViewModel : ViewModelBase
    {
        List<String> countries;
        List<String> places;
        List<String> religious;
        List<String> nationality;
        string dateDeath;
        string dateBirth;
        Uri defaultImage;
        Uri image;

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
        
        Character curChar;
        public CharacterWindowViewModel()
        {
            curChar = new Character();
            defaultImage = new Uri("..\\View\\Resources\\image_58a807e70acb9.jpg", UriKind.Relative);
            //https://i.imgur.com/obfHFdg.png
        }

        public Character CurChar
        {
            get
            {
                return curChar;
            }

            set
            {
                curChar = value;
                Image = null;
                OnPropertyChanged("CurChar");
            }
        }

        //RelayCommand _biographyCommand;
        //public ICommand BiographyCommand
        //{
        //     get
        //     {
        //         if (_biographyCommand == null)
        //         {
        //             _biographyCommand = new RelayCommand(ExecuteBiographyCommand);
        //         }
        //         return _biographyCommand;
        //     }
        // }
        //void ExecuteBiographyCommand(object bio)
        //{
        //    MessageBox.Show("Следующий спринт!");
        //    // НАПИСАТЬ ФУНКЦИОНАЛ
        //}


        public List<string> Countries {
            get
            {
                if(countries == null)
                {
                    countries = new List<string>();
                    var tmp = ConLogic.MainProxy.GetAllCountries();
                    foreach (var item in tmp)
                    {
                        countries.Add(item);
                    }
                }
                return countries;
            }
            set
            {
                OnPropertyChanged("Countries");
                countries = value;
            }
        }

        public List<string> Places {
            get
            {
                if(places==null)
                {
                    places = new List<string>();
                    var tmp = ConLogic.MainProxy.GetAllPlaces();
                    foreach (var item in tmp)
                    {
                        places.Add(item);
                    }
                }
                return places;
            }
            set
            {
                OnPropertyChanged("Places");
                places = value;
            }
        }
        public List<string> Religious
        {
            get
            {
                if(religious == null)
                {
                    religious = new List<string>();
                    var tmp = ConLogic.MainProxy.GetAllReligious();
                    foreach (var item in tmp)
                    {
                        religious.Add(item);
                    }
                }
                return religious;
            }
            set
            {
                OnPropertyChanged("Religious");
                religious = value;
            }
        }

        public List<string> Nationality
        {
            get
            {
                if(nationality==null)
                {
                    nationality = new List<string>();
                    var tmp = ConLogic.MainProxy.GetAllNationality();
                    foreach (var item in tmp)
                    {
                        nationality.Add(item);
                    }
                }
                return nationality;
            }
            set
            {
                OnPropertyChanged("Nationality");
                nationality = value;
            }
        }

        public Uri Image
        {
            get
            {
                if (CurChar.Photo == null)
                {
                    //var tmp = Path.GetFullPath(DefaultImage);
                    //return Path.GetFullPath(DefaultImage);
                    image = defaultImage;
                    return image;
                }
                image = new Uri(CurChar.Photo, UriKind.Absolute);
                return image;
            }
            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }
        
        ICommand closing_Info;

        public ICommand Closing_Info
        {
            get
            {
                if (closing_Info == null)
                {
                    closing_Info = new RelayCommand(ExecuteClosing_Info);
                }
                return closing_Info;
            }
        }

        private void ExecuteClosing_Info(object obj)
        {
            WindowViewLoaderService.VMContexts.Remove(this);
        }

        ICommand saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    saveCommand = new RelayCommand(ExecuteSaveCommand);
                }
                return saveCommand;
            }
        }

        private void ExecuteSaveCommand(object obj)
        {
            var tmpUser = (WindowViewLoaderService.getContext(typeof(AuthorizationViewModel)) as AuthorizationViewModel).User;
            var tmpHouse = (WindowViewLoaderService.getContext(typeof(MainWindowViewModel)) as MainWindowViewModel).House;
            var tmpCharacter = new Character(CurChar);
            ConLogic.MainProxy.ChangeChar(tmpUser, tmpCharacter);
            //CurChar = null;
            tmpHouse = null;
        }

        ICommand changeURLPicture;

        public ICommand ChangeURLPicture
        {
            get
            {
                if (changeURLPicture == null)
                {
                    changeURLPicture = new RelayCommand(ExecuteChangeURLPicture);
                }
                return changeURLPicture;
            }
        }

        private void ExecuteChangeURLPicture(object obj)
        {
            MessageBox.Show(Image.ToString());
        }
    }
}