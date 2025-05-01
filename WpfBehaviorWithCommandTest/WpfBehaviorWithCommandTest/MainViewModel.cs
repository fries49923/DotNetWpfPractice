using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace WpfBehaviorWithCommandTest
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {

        }

        [RelayCommand]
        private void MouseHit(string str)
        {
            if (string.IsNullOrEmpty(str) is true)
            {
                return;
            }

            MessageBox.Show(str);
        }
    }
}
