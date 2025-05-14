using ClassLibrary1;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using System.Windows;

namespace WpfToolKitMvvmAndDiTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //DataContext = Ioc.Default.GetService<ObservableObject>();
            DataContext = Ioc.Default.GetService<SomeClass>();
        }
    }
}