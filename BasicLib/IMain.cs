using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BasicLib
{
    [ServiceContract]
    public interface IMain
    {
        [OperationContract]
        House getHouse(User incomingUser);
        [OperationContract]
        void getLogs();

    }
}
