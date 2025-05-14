using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ClassLibrary1
{
    [ObservableObject]
    public partial class MainViewModel02 : SomeClass
    {
        [ObservableProperty]
        private string? _name;

        [ObservableProperty]
        private int _number;

        public MainViewModel02()
        {
            _name = "This is ViewModel 02.";
            _number = 20;
        }

        [RelayCommand]
        private void Click()
        {
            Number += 5;
        }
    }
}
