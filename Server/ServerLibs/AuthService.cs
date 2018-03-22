﻿using System;
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
                BaseUser = db.User.Where(x => x.email == user.Email).ToList().First();
                if (BaseUser == null)
                {
                    return false;
                }
                if ( (BaseUser as Server.User).password != user.Password)
                {
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