using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfListBoxAlternationIndexTest
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<string> Items
        { get; set; }

        public MainViewModel()
        {
            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5",
                "Item 6",
                "Item 7",
                "Item 8",
                "Item 9",
                "Item 10",
            };
        }
    }
}
