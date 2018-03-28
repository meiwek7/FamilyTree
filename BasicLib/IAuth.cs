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
        AuthErrors Auth(User user);
        [OperationContract]
        User Initialize();
        [OperationContract]
        bool RegisterUser();
    }
    public enum AuthErrors
    {
        EverythingIsFine = 0,
        NoSuchUser = 1,
        IncorrectPass = 2
    }
}