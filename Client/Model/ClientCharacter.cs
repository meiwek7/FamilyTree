using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLib;
using Client.Infrastructure;
using Client.ViewModel;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Client.Model
{
    class ClientCharacter : BasicLib.Character, INotifyPropertyChanged, IDisposable
    {
        Uri defaultImage = new Uri("..\\View\\Resources\\image_58a807e70acb9.jpg", UriKind.Relative);
        Uri image;
        private RelayCommand summonCharacter_Info;

        public ClientCharacter()
        {

        }

        public ClientCharacter(Character ch):base(ch)
        {

        }
        
        public RelayCommand SummonCharacter_Info
        {
            get
            {
                if (summonCharacter_Info == null)
                {
                    summonCharacter_Info = new RelayCommand(ExecuteSummonCharacter_Info);
                }
                return summonCharacter_Info;
            }
        }

        private void ExecuteSummonCharacter_Info(object param)
        {
            WindowViewLoaderService.Show(typeof(CharacterWindowViewModel));
            var tmpCharVVM = WindowViewLoaderService.getContext(typeof(CharacterWindowViewModel)) as CharacterWindowViewModel;
            var tmp = new ClientCharacter(this);
            tmpCharVVM.CurChar = (BasicLib.Character)tmp/*this*//* as Character*/;
        }

        public Uri Image
        {
            get
            {
                if (Photo == null)
                {
                    //var tmp = Path.GetFullPath(DefaultImage);
                    //return Path.GetFullPath(DefaultImage);
                    image = defaultImage;
                    return image;
                }
                image = new Uri(Photo, UriKind.Absolute);
                return image;
            }
            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose()
        {

        }
    }
}
