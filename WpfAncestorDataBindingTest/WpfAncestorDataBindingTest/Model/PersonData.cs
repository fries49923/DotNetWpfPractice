using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfAncestorDataBindingTest.Model
{
    public partial class PersonData : ObservableObject
    {
        [ObservableProperty]
        protected string _name = "";

        [ObservableProperty]
        protected string _phone = "";

        [ObservableProperty]
        protected string _email = "";

        [ObservableProperty]
        protected string _address = "";
    }
}
