using ClassLibrary1;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace WpfToolKitMvvmAndDiTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ConfigureServices();
        }

        private static void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<ObservableObject, MainViewModel01>();
            serviceCollection.AddSingleton<SomeClass, MainViewModel02>();

            Ioc.Default.ConfigureServices(
                serviceCollection.BuildServiceProvider());
        }
    }
}
