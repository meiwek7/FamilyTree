using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BasicLib;
using Client.AuthServiceRef;

namespace Client.Infrastructure
{
    static class ConLogic
    {
        static AuthClient proxy;
        //static  proxy;

        static ConLogic()
        {
            proxy = new AuthClient();
        }

        public static AuthClient Proxy { get { return proxy; } private set { proxy = value; } }
    }
}
