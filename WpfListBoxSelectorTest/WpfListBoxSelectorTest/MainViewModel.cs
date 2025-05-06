using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfListBoxSelectorTest
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<string> Items
        { get; set; }

        public MainViewModel()
        {
            Items =
            [
                "11111",
                "222222222222",
                "333333",
                "44444",
                "5555555555"
            ];
        }
    }
}
