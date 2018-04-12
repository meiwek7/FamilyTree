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
        Uri defaultImage;
        Uri image;
        
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
                OnPropertyChanged("BirthDate");
                OnPropertyChanged("DeathDate");
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
                if (CurChar.Photo == null || CurChar.Photo == "")
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
                if (value != null)
                {
                    CurChar.Photo = value.ToString();
                    image = value;
                }
                else
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
            var MVContext = (WindowViewLoaderService.getContext(typeof(MainWindowViewModel)) as MainWindowViewModel);
            var tmpCharacter = new Character(CurChar);
            ConLogic.MainProxy.ChangeChar(tmpUser, tmpCharacter);
            //CurChar = null;
            MVContext.House = null;
            var tmp1 = MVContext.House;
            MVContext.Characters = null;
            var tmp2 = MVContext.Characters;
            WindowViewLoaderService.VMContexts.Where(x => x.Key == this).ToList().First().Value.Close();
        }
        //CleanBirthDate
        ICommand cleanBirthDate;

        public ICommand CleanBirthDate
        {
            get
            {
                if (cleanBirthDate == null)
                {
                    cleanBirthDate = new RelayCommand(ExecuteCleanBirthDate);
                }
                return cleanBirthDate;
            }
        }

        private void ExecuteCleanBirthDate(object obj)
        {
            CurChar.BirthDate = DateTime.MinValue;
            OnPropertyChanged("BirthDate");
        }

        public DateTime BirthDate {
            get
            {
                return CurChar.BirthDate;
            }
            set
            {
                CurChar.BirthDate = value;
                OnPropertyChanged("BirthDate");
            }
        }

        public DateTime DeathDate
        {
            get
            {
                return CurChar.DeathDate;
            }
            set
            {
                CurChar.DeathDate = value;
                OnPropertyChanged("DeathDate");
            }
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
            WindowViewLoaderService.Show(typeof(EnterSmallWindowViewModel));
            var tmpcntxt = WindowViewLoaderService.getContext(typeof(EnterSmallWindowViewModel)) as EnterSmallWindowViewModel;
            tmpcntxt.typeOfAdds = TypeAddValue.Photo;
            tmpcntxt.Text = CurChar.Photo;
            //MessageBox.Show(Image.ToString());
        }
    }
}