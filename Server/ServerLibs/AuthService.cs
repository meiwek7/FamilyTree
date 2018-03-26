using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLib;

namespace Server.ServerLibs
{
    class AuthService : IAuth
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
                    Console.WriteLine("{0} - {1} - Не смог войти в систему", user.Id, user.Password);
                    return false;
                }
                BaseUser = BaseUser1.First();
                if ( (BaseUser as Server.User).password != user.Password)
                {
                    Console.WriteLine("{0}.{1} - {2} - Не смог войти в систему", (BaseUser as Server.User).id, (BaseUser as Server.User).email, (BaseUser as Server.User).phoneNumber);
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