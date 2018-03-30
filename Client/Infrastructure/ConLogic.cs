using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BasicLib;
using Client.AuthServiceRef;
using Client.MainServiceRef;

namespace Client.Infrastructure
{
    static class ConLogic
    {
        static AuthClient authproxy;
        static MainClient mainproxy;

        static ConLogic()
        {
            authproxy = new AuthClient();
            mainproxy = new MainClient();
        }

        public static AuthClient AuthProxy { get { return authproxy; } private set { authproxy = value; } }
        public static MainClient MainProxy { get { return mainproxy; } private set { mainproxy = value; } }
    }
}
