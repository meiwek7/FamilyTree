using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    static class SuperViewModel
    {
        private static MainWindowViewModel          mainWindowVM;
        private static RegisterViewModel            registerVM;
        private static AuthorizationViewModel       authorizationVM;
        private static CharacterWindowViewModel     character_InfoVM;

        internal static MainWindowViewModel MainWindowVM
        {
            get
            {
                return mainWindowVM;
            }

            set
            {
                mainWindowVM = value;
            }
        }

        internal static RegisterViewModel RegisterVM
        {
            get
            {
                return registerVM;
            }

            set
            {
                registerVM = value;
            }
        }

        internal static AuthorizationViewModel AuthorizationVM
        {
            get
            {
                return authorizationVM;
            }

            set
            {
                authorizationVM = value;
            }
        }

        internal static CharacterWindowViewModel Character_InfoVM
        {
            get
            {
                return character_InfoVM;
            }

            set
            {
                character_InfoVM = value;
            }
        }
    }
}