using System.Windows;
using System.Windows.Media;

namespace WpfAttachedPropAndCtTest
{
    public static class AttachedProp
    {
        public static readonly DependencyProperty IconFillProperty =
            DependencyProperty.RegisterAttached(
                "IconFill",
                typeof(Brush),
                typeof(AttachedProp),
                new FrameworkPropertyMetadata(Brushes.Black, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetIconFill(UIElement element, Brush value)
        {
            element.SetValue(IconFillProperty, value);
        }

        public static Brush GetIconFill(UIElement element)
        {
            return (Brush)element.GetValue(IconFillProperty);
        }
    }
}
