﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BasicLib;

namespace Server.ServerLibs
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "MainServiceServ" в коде и файле конфигурации.
    public class MainServiceServ : IMain
    {
        public BasicLib.House getHouse(BasicLib.User incomingUser)
        {

            throw new NotImplementedException();
        }

        public void getLogs()
        {

            throw new NotImplementedException();
        }
    }
}
