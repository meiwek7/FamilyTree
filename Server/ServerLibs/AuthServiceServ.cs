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
        public AuthErrors Auth(BasicLib.User user)
        {
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                object BaseUser;
                var BaseUser1 = db.User.Where(x => x.email == user.Email).ToList();
                BaseUser = null;
                if (BaseUser1.Count() == 0)
                {
                    Console.WriteLine("{0} - {1} - Не смог войти в систему. Такого пользователя нет в базе", user.Email, user.Password);
                    return AuthErrors.NoSuchUser;
                }
                BaseUser = BaseUser1.First() as Server.User;
                if ((BaseUser as Server.User).password != user.Password)
                {
                    Console.WriteLine("{0}.{1} - {2} - Не смог войти в систему. Пароль неверный.", (BaseUser as Server.User).id, (BaseUser as Server.User).email, (BaseUser as Server.User).phoneNumber);
                    return AuthErrors.IncorrectPass;
                }
                (BaseUser as Server.User).lastLogIn = DateTime.Now;
                db.SaveChanges();
                Console.WriteLine("{0}.{1} - {2} - Успешно вошел в систему", (BaseUser as Server.User).id, (BaseUser as Server.User).email, (BaseUser as Server.User).phoneNumber);
            }
            return AuthErrors.EverythingIsFine;
        }

        public BasicLib.User Initialize(BasicLib.User incomingUser)
        {
            BasicLib.User outgoingUser = new BasicLib.User();
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                var dbUser = db.User.Where(x => x.email == incomingUser.Email).ToList().First();
                if (db.User == null)
                    throw new Exception("DB Doesn`t contain such user");
                outgoingUser = new BasicLib.User();
                outgoingUser.Email = dbUser.email;
                outgoingUser.CharacterId        = (int)dbUser.characterId;
                outgoingUser.Password           = dbUser.password        ;
                outgoingUser.PhoneNumber        = dbUser.phoneNumber     ;
                outgoingUser.LastLogIn          = dbUser.lastLogIn       ;
                outgoingUser.AccessLevelType    = dbUser.accessLevelType ;
            }
            return outgoingUser;
        }

        public RegisterResult RegisterUser(BasicLib.User user)
        {
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                Server.User NewUser = new Server.User();
                NewUser.email = user.Email;
                NewUser.password = user.Password;
                NewUser.accessLevelType = "user";
                NewUser.lastLogIn = DateTime.Now;
                db.User.Add(NewUser);
                db.SaveChanges();
                Console.WriteLine("{0} - Успешно зарегистрирован в системе Password: {1}", user.Email,user.Password);
            }
            return RegisterResult.UserRegSuccess;
            return RegisterResult.SomethingWentWrong;
        }
    }
}
