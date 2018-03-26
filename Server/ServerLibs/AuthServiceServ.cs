using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BasicLib;

namespace Server.ServerLibs
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "AuthServiceServ" в коде и файле конфигурации.
    public class AuthServiceServ : IAuth
    {
        public bool Auth(BasicLib.User user)
        {
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                object BaseUser;
                var BaseUser1 = db.User.Where(x => x.email == user.Email).ToList();
                BaseUser = null;
                if (BaseUser1.Count() == 0)
                {
                    Console.WriteLine("{0} - {1} - Не смог войти в систему. Такого пользователя нет в базе", user.Email, user.Password);
                    return false;
                }
                BaseUser = BaseUser1.First();
                if ((BaseUser as Server.User).password != user.Password)
                {
                    Console.WriteLine("{0}.{1} - {2} - Не смог войти в систему. Пароль неверный.", (BaseUser as Server.User).id, (BaseUser as Server.User).email, (BaseUser as Server.User).phoneNumber);
                    return false;
                }
                Console.WriteLine("{0}.{1} - {2} - Успешно вошел в систему", (BaseUser as Server.User).id, (BaseUser as Server.User).email, (BaseUser as Server.User).phoneNumber);
            }
            return true;
        }

        public BasicLib.User Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
