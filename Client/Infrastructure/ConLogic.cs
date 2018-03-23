using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BasicLib;

namespace Client.Infrastructure
{
    static class ConLogic
    {
        static Uri address;
        static BasicHttpBinding binding;
        static EndpointAddress endpoint;
        static ChannelFactory<IAuth> Authfactory;
        static IAuth channel;

        static ConLogic()
        {
            //Указание, где ожидать входящие сообщения.
            address = new Uri("http://localhost:4000/IContract");
            // Указание, как обмениваться сообщениями.
            binding = new BasicHttpBinding();
            // Создание Конечной Точки.
            endpoint = new EndpointAddress(address);
            // Создание фабрики каналов.
            Authfactory = new ChannelFactory<IAuth>(binding, endpoint);
            // Использование factory для создания канала (прокси).
            channel = Authfactory.CreateChannel();
            // Использование канала для отправки сообщения получателю и приема ответа.
            //bool response = channel.Auth(new User("AntoxaDerzkiyKoder@gmail.com", "pass"));
        }

        public static IAuth Channel { get => channel; set => channel = value; }
    }
}
