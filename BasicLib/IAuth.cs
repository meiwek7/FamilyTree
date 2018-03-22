using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace BasicLib
{
    [ServiceContract]
    public interface IAuth
    {
        [OperationContract]
        bool Auth(User user);
        [OperationContract]
        User Initialize();
    }
}