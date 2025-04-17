using System.Windows;
using System.Windows.Media;

namespace WpfAttachedPropAndCtTest
{
    public static class IconAssist
    {
        // IconFill
        public static readonly DependencyProperty IconFillProperty =
            DependencyProperty.RegisterAttached(
                "IconFill",
                typeof(Brush),
                typeof(IconAssist),
                new FrameworkPropertyMetadata(Brushes.Black, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetIconFill(UIElement element, Brush value)
        {
            element.SetValue(IconFillProperty, value);
        }

        public static Brush GetIconFill(UIElement element)
        {
            return (Brush)element.GetValue(IconFillProperty);
        }

        // ShowIcon
        public static readonly DependencyProperty ShowIconProperty =
            DependencyProperty.RegisterAttached(
                "ShowIcon",
                typeof(bool),
                typeof(IconAssist),
                new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetShowIcon(DependencyObject element, bool value)
        {
            element.SetValue(ShowIconProperty, value);
        }

        public static bool GetShowIcon(DependencyObject element)
        {
            return (bool)element.GetValue(ShowIconProperty);
        }
    }
}
