using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfMvvmEventTriggerTest
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        protected string _name;

        public MainViewModel()
        {
            _name = "";
        }

        [RelayCommand]
        protected void MouseEnterFun()
        {
            Name = "Mouse Enter";
        }

        [RelayCommand]
        protected void MouseLeaveFun()
        {
            Name = "Mouse Leave";
        }
    }
}
