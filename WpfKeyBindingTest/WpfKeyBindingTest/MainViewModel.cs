using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace WpfKeyBindingTest
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        protected Visibility _btnVisibility;

        public MainViewModel()
        {
            _btnVisibility = Visibility.Visible;
        }

        [RelayCommand]
        protected void HotKeyTest()
        {
            BtnVisibility =
                BtnVisibility is Visibility.Collapsed
                ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
