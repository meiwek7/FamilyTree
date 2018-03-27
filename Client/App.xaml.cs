using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Client.ViewModel;
using Client.View;

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            WindowViewLoaderService.Register(typeof(MainWindow), typeof(MainWindowViewModel) );
            WindowViewLoaderService.Register(typeof(Register), typeof(RegisterViewModel) );
            WindowViewLoaderService.Register(typeof(Authorization), typeof(AuthorizationViewModel) );
            Authorization mainWindow = new Authorization();
            mainWindow.Show();
        }
    }
}
