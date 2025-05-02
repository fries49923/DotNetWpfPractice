using Microsoft.Xaml.Behaviors;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfDropFileTest
{
    public class ImageFileDropBehavior : Behavior<FrameworkElement>
    {
        private static readonly HashSet<string> supportedExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".jpg", ".jpeg", ".tif", ".tiff", ".png", ".bmp"
        };

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register(
                "ImageSource", typeof(BitmapSource),
                typeof(ImageFileDropBehavior), new PropertyMetadata(default(BitmapSource)));

        public BitmapSource ImageSource
        {
            get => (BitmapSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
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
            try
            {
                //Get the filename including path
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files is null
                    || files.Length == 0)
                {
                    return;
                }

                string fileName = files[0];

                if (File.Exists(fileName) is false)
                {
                    return;
                }

                string ext = Path.GetExtension(fileName).ToLower();
                if (supportedExtensions.Contains(ext) is false)
                {
                    return;
                }

                ImageSource = new BitmapImage(new Uri(fileName));
            }
            catch (Exception)
            { }
            finally
            {
                //This is file being dropped not copied text so we handle it
                e.Handled = true;
            }
        }

        protected override void OnDetaching()
        {
            AssociatedObject.PreviewDragOver -= AssociatedObject_PreviewDragOver;
            AssociatedObject.PreviewDrop -= AssociatedObject_PreviewDrop;

            base.OnDetaching();
        }
    }
}
