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

        public static MainWindowViewModel       MainWindowVM { get => mainWindowVM; set => mainWindowVM = value; }
        public static RegisterViewModel         RegisterVM { get => registerVM; set => registerVM = value; }
        public static AuthorizationViewModel    AuthorizationVM { get => authorizationVM; set => authorizationVM = value; }
        public static CharacterWindowViewModel  Character_InfoVM { get => character_InfoVM; set => character_InfoVM = value; }
    }
}