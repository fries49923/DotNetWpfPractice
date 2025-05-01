using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfAncestorDataBinding.Model
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
