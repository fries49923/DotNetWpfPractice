using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Input;

namespace WpfDropFileTest
{
    public class FileDropBehavior : Behavior<FrameworkElement>
    {
        public static readonly DependencyProperty FilePathProperty =
            DependencyProperty.Register(
                "FilePath", typeof(string),
                typeof(FileDropBehavior), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(
                "Command", typeof(ICommand),
                typeof(FileDropBehavior), null);

        public string FilePath
        {
            get => (string)GetValue(FilePathProperty);
            set => SetValue(FilePathProperty, value);
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        protected override void OnAttached()
        {
            base.OnAttached();

            // UIElement.PreviewDragOver
            AssociatedObject.PreviewDragOver += AssociatedObject_PreviewDragOver;
            AssociatedObject.PreviewDrop += AssociatedObject_PreviewDrop;
        }

        private void AssociatedObject_PreviewDragOver(object sender, DragEventArgs e)
        {
            //e.Effects = DragDropEffects.All;
            e.Handled = true;
        }

        private void AssociatedObject_PreviewDrop(object sender, DragEventArgs e)
        {
            //Get the filename including path
            string[] fileloadup = (string[])e.Data.GetData(DataFormats.FileDrop);
            FilePath = fileloadup[0];

            Command?.Execute(fileloadup[0]);

            //This is file being dropped not copied text so we handle it
            e.Handled = true;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.PreviewDragOver -= AssociatedObject_PreviewDragOver;
            AssociatedObject.PreviewDrop -= AssociatedObject_PreviewDrop;

            base.OnDetaching();
        }
    }
}
