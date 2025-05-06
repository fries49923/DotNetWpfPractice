using System.Windows;
using System.Windows.Controls;

namespace WpfListBoxSelectorTest
{
    public class MyTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? LongItemTemplate
        { get; set; }

        public DataTemplate? ShortItemTemplate
        { get; set; }

        public override DataTemplate? SelectTemplate(object item, DependencyObject container)
        {
            if (item is null
                || container is null)
            {
                return null;
            }

            if (item is not string str)
            {
                return null;
            }

            if (str.Length > 5)
            {
                return LongItemTemplate;
            }
            else
            {
                return ShortItemTemplate;
            }
        }
    }
}
