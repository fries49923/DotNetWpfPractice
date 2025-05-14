using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ClassLibrary1
{
    public partial class MainViewModel01 : ObservableObject
    {
        [ObservableProperty]
        private string? _name;

        [ObservableProperty]
        private int _number;

        public MainViewModel01()
        {
            _name = "This is ViewModel 01.";
            _number = 10;
        }

        [RelayCommand]
        private void Click()
        {
            Number += 3;
        }
    }
}
