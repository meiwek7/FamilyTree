using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceModel;
using BasicLib;

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Указание, где ожидать входящие сообщения.
            Uri address = new Uri("http://localhost:4000/IContract");

            // Указание, как обмениваться сообщениями.
            BasicHttpBinding binding = new BasicHttpBinding();

            // Создание Конечной Точки.
            EndpointAddress endpoint = new EndpointAddress(address);

            // Создание фабрики каналов.
            ChannelFactory<IAuth> factory = new ChannelFactory<IAuth>(binding, endpoint);

            // Использование factory для создания канала (прокси).
            IAuth channel = factory.CreateChannel();

            // Использование канала для отправки сообщения получателю и приема ответа.
            bool response = channel.Auth(new User("AntoxaDerzkiyKoder@gmail.com", "pass"));
            // Задержка.
        }
    }
}
