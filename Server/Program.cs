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
                    Console.WriteLine("{0}.{1} - {2}", u.id, u.email, u.phoneNumber);
                }
            }
            Console.WriteLine();
            //Указание адреса, где ожидать входящие сообщения.
           Uri address = new Uri("http://localhost:4000/IContract"); // ADDRESS.   (A)

            //Указание привязки, как обмениваться сообщениями.
            BasicHttpBinding binding = new BasicHttpBinding();        // BINDING.   (B)

            //Указание контракта.
            Type contract = typeof(IAuth);                            // CONTRACT.  (C) 

            //Создание провайдера Хостинга с указанием Сервиса.
            ServiceHost host = new ServiceHost(typeof(AuthService));

            //Добавление "Конечной Точки".
           host.AddServiceEndpoint(contract, binding, address);

            //Начало ожидания прихода сообщений.
             host.Open();

            // = ============
            //  DemoService1
            // = ============
            //ServiceHost host2 = new ServiceHost(typeof(DemoService1));
            //host2.Open();
            Console.WriteLine("Приложение готово к приему сообщений.");
            //Console.ReadKey();

            //host2.Close();
            //Console.WriteLine("Host2 - stopped");
            // Завершение ожидания прихода сообщений.
            host.Close();
        }
    }
}