using System.Windows;

namespace WpfFontResourceTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //string projectRoot = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            //string fontPath = Path.Combine(projectRoot, "Fonts", "Kalam", "Kalam-Regular.ttf");

            //var pfc = new PrivateFontCollection();
            //pfc.AddFontFile(fontPath);
            //Debug.WriteLine($"字體名稱: {pfc.Families[0].Name}");
        }
    }
}