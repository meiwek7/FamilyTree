﻿using System;
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
        [OperationContract]
        void InsertNewCharacter(BasicLib.User curUser, BasicLib.House incHs);
        [OperationContract]
        List<string> GetAllCountries();
        [OperationContract]
        List<string> GetAllReligious();
        [OperationContract]
        List<string> GetAllPlaces();
        [OperationContract]
        List<string> GetAllNationality();
        [OperationContract]
        void ChangeChar(BasicLib.User incUser, BasicLib.Character incCharacter);
    }
}
