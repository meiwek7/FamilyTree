using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BasicLib;
using Server.ServerLibs;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";
            //new MainServiceServ().getHouse(new BasicLib.User());
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                Console.WriteLine("Список Юзеров:");
                var users = db.User;
                foreach (User u in users)
                {
                    Console.WriteLine("BaseId: {0} || E-mail:{1}  || PhoneNumber:{2} || Password:{3} || LastLogIn:{4}", u.id, u.email, u.phoneNumber, u.password, u.lastLogIn);
                }
            }
            Console.WriteLine();
            ServiceHost host = new ServiceHost(typeof(AuthServiceServ));
            ServiceHost host2 = new ServiceHost(typeof(MainServiceServ));
            host.Open();
            host2.Open();
            Console.WriteLine("Приложение готово к приему сообщений.");
            Console.ReadKey();
            host.Close();
            host2.Close();
        }
    }
}