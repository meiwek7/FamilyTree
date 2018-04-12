using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Infrastructure;
using System.Windows.Input;

namespace Client.ViewModel
{
    class EnterSmallWindowViewModel : ViewModelBase
    {
        public EnterSmallWindowViewModel()
        {
            typeOfAdds = TypeAddValue.Default;
        }
        public TypeAddValue typeOfAdds;
        String text;
        public String Text {
            get
            {
                return text;
            }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }
        //OK_Com
        ICommand oK_Com;

        public ICommand OK_Com
        {
            get
            {
                if (oK_Com == null)
                {
                    oK_Com = new RelayCommand(ExecuteOK_Com);
                }
                return oK_Com;
            }
        }

        private void ExecuteOK_Com(object obj)
        {
            switch (typeOfAdds)
            {
                case TypeAddValue.Country:
                    
                    break;
                case TypeAddValue.Place:
                  
                    break;
                case TypeAddValue.Nationality:
                   
                    break;
                case TypeAddValue.Religious:

                    break;
                case TypeAddValue.Photo:
                    var tmpCntxt = (WindowViewLoaderService.getContext(typeof(CharacterWindowViewModel))as CharacterWindowViewModel);
                    tmpCntxt.Image = new Uri(text);
                    WindowViewLoaderService.VMContexts.Where(x => x.Key == this).ToList().First().Value.Close();
                    break;
            }
        }
        //ClosingCommand
        ICommand closingCommand;

        public ICommand ClosingCommand
        {
            get
            {
                if (closingCommand == null)
                {
                    closingCommand = new RelayCommand(ExecuteClosingCommand);
                }
                return closingCommand;
            }
        }
        private void ExecuteClosingCommand(object obj)
        {
            WindowViewLoaderService.VMContexts.Remove(this);
        }
    }

    public enum TypeAddValue
    {
        Default =0,
        Country = 1,
        Place = 2,
        Nationality = 3,
        Religious = 4,
        Photo = 5
    }
}
