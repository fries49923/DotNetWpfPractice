using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Input;

namespace WpfBehaviorWithCommandTest
{
    public class MouseEventBehavior : Behavior<FrameworkElement>
    {
        public static readonly DependencyProperty MouseAxisStrProperty =
            DependencyProperty.Register(
                "MouseAxisStr", typeof(string),
                typeof(MouseEventBehavior), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty MouseDownCommandProperty =
            DependencyProperty.Register(
                "MouseDownCommand", typeof(ICommand),
                typeof(MouseEventBehavior), null);

        public static readonly DependencyProperty MouseDownCommandParamProperty =
            DependencyProperty.Register(
                "MouseDownCommandParam", typeof(object),
                typeof(MouseEventBehavior), null);

        public string MouseAxisStr
        {
            get => (string)GetValue(MouseAxisStrProperty);
            set => SetValue(MouseAxisStrProperty, value);
        }

        public ICommand MouseDownCommand
        {
            get => (ICommand)GetValue(MouseDownCommandProperty);
            set => SetValue(MouseDownCommandProperty, value);
        }

        public object MouseDownCommandParam
        {
            get => GetValue(MouseDownCommandParamProperty);
            set => SetValue(MouseDownCommandParamProperty, value);
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseMove += AssociatedObject_MouseMove;
            AssociatedObject.MouseDown += AssociatedObject_MouseDown;
        }

        // MouseMove
        private void AssociatedObject_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.GetPosition(AssociatedObject);

            MouseAxisStr = $"x:{pos.X}, y:{pos.Y}";
        }

        // MouseDown
        private void AssociatedObject_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MouseDownCommand?.Execute(MouseDownCommandParam);
        }

        protected override void OnDetaching()
        {
            AssociatedObject.MouseDown -= AssociatedObject_MouseDown;
            AssociatedObject.MouseMove -= AssociatedObject_MouseMove;
            base.OnDetaching();
        }
    }
}
