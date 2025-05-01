using System.Windows;
using System.Windows.Controls;

namespace WpfListBoxDataTemplateDataTypeTest
{
    public class AirplaneControl : Control
    {
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(AirplaneControl));

        public static readonly DependencyProperty ThrustProperty =
            DependencyProperty.Register("Thrust", typeof(string), typeof(AirplaneControl));

        public static readonly DependencyProperty WingspantProperty =
            DependencyProperty.Register("Wingspant", typeof(string), typeof(AirplaneControl));

        public static readonly DependencyProperty EngineCountProperty =
            DependencyProperty.Register("EngineCount", typeof(string), typeof(AirplaneControl));

        static AirplaneControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(AirplaneControl), new FrameworkPropertyMetadata(typeof(AirplaneControl)));
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public string Thrust
        {
            get => (string)GetValue(ThrustProperty);
            set => SetValue(ThrustProperty, value);
        }

        public string Wingspant
        {
            get => (string)GetValue(WingspantProperty);
            set => SetValue(WingspantProperty, value);
        }

        public string EngineCount
        {
            get => (string)GetValue(EngineCountProperty);
            set => SetValue(EngineCountProperty, value);
        }
    }
}
