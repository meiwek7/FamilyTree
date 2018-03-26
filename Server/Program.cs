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
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                Console.WriteLine("Список Юзеров");
                var users = db.User;
                foreach (User u in users)
                {
                    Console.WriteLine("{0}.{1} - {2} - {3}", u.id, u.email, u.phoneNumber,u.password);
                }
            }
            Console.WriteLine();
            ServiceHost host = new ServiceHost(typeof(AuthServiceServ));
            host.Open();
            Console.WriteLine("Приложение готово к приему сообщений.");
            Console.ReadKey();
            host.Close();
            Console.WriteLine("Host2 - stopped");
        }
    }
}