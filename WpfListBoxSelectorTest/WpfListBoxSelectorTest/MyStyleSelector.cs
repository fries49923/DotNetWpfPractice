using System.Windows;
using System.Windows.Controls;

namespace WpfListBoxSelectorTest
{
    // 此 StyleSelector 主要用來示範如何根據條件選擇樣式
    // 在 ListBox 中，其實可以直接使用 AlternationIndex 來處理 Odd/Even 樣式，而無需自訂 StyleSelector
    public class MyStyleSelector : StyleSelector
    {
        public Style? EvenItemStyle
        { get; set; }

        public Style? OddItemStyle
        { get; set; }

        public override Style? SelectStyle(object item, DependencyObject container)
        {
            if (item is null)
            {
                return null;
            }

            var itemsControl = ItemsControl.ItemsControlFromItemContainer(container);
            var index = itemsControl.ItemContainerGenerator.IndexFromContainer(container);
            if (index % 2 == 0)
            {
                return EvenItemStyle;
            }
            else
            {
                return OddItemStyle;
            }
        }
    }
}
