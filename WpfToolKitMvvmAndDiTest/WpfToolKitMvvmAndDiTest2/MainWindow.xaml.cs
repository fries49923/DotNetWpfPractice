using ClassLibrary1;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace WpfToolKitMvvmAndDiTest2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(ObservableObject vm)
        {
            InitializeComponent();

            DataContext = vm;
        }

        //public MainWindow(SomeClass vm)
        //{
        //    InitializeComponent();

        //    DataContext = vm;
        //}
    }
}