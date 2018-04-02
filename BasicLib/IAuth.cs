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
        User Initialize(User incomingUser);
        [OperationContract]
        RegisterResult RegisterUser(User user);
    }
    public enum AuthErrors
    {
        EverythingIsFine = 0,
        NoSuchUser = 1,
        IncorrectPass = 2
    }
    public enum RegisterResult
    {
        UserRegSuccess = 0,
        SomethingWentWrong = 1
    }
}