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
            WindowViewLoaderService.Register(typeof(Character_UserControl1), typeof(Character_UserControlViewModel));
            WindowViewLoaderService.Register(typeof(Character_Info), typeof(CharacterWindowViewModel));
            WindowViewLoaderService.Register(typeof(EnterSmallWindow), typeof(EnterSmallWindowViewModel));
            //Authorization mainWindow = new Authorization();
            WindowViewLoaderService.Show(typeof(AuthorizationViewModel));
            //mainWindow.Show();
        }
    }
}
