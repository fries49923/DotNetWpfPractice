using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace WpfFilterListBoxTest
{
    public partial class MainViewModel : ObservableObject
    {
        private CollectionView view;

        [ObservableProperty]
        private string _filterText;

        public ObservableCollection<string> TestStrings
        { get; private set; }

        public MainViewModel()
        {
            _filterText = "";

            TestStrings = new()
            {
                "Pizza",
                "Sushi",
                "Burger",
                "Pasta",
                "Fried Rice",
                "Ramen",
                "Tacos",
                "Salad",
                "Steak",
                "Dumplings"
            };

            view = (CollectionView)CollectionViewSource.GetDefaultView(TestStrings);
            view.Filter = CustomFilter;
        }

        private bool CustomFilter(object obj)
        {
            if (string.IsNullOrWhiteSpace(FilterText) is true)
                return true;

            if (obj is string item)
                return item.Contains(FilterText, StringComparison.OrdinalIgnoreCase);

            return false;
        }

        [RelayCommand]
        private void SearchText()
        {
            CollectionViewSource.GetDefaultView(TestStrings).Refresh();
        }
    }
}
