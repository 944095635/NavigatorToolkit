using System;
using System.Windows;

namespace NavigatorToolkit.Samples
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //注册页面
            Navigator.RegisterView("login", new Uri("pack://application:,,,/NavigatorToolkit.Samples;component/View/LoginView.xaml"));
            Navigator.RegisterView("home", new Uri("pack://application:,,,/NavigatorToolkit.Samples;component/View/HomeView.xaml"));
            //Navigator.RegisterView(Views.Login, typeof(LoginView));
            //Navigator.RegisterView(Views.Home, new Uri("pack://application:,,,/NavigatorSamples;component/LoginView.xaml"));
        }
    }
}
