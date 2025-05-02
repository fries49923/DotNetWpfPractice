using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.IO;
using System.Windows.Media.Imaging;

namespace WpfDropFileTest
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly HashSet<string> supportedExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".jpg", ".jpeg", ".tif", ".tiff", ".png", ".bmp"
        };

        [ObservableProperty]
        protected string _imgFileName;

        [ObservableProperty]
        protected BitmapSource? _sourceImg;

        public MainViewModel()
        {
            this._imgFileName = "";
            this._sourceImg = null;
        }

        [RelayCommand]
        protected void Load(string path)
        {
            if (File.Exists(path) is false)
            {
                return;
            }

            string ext = Path.GetExtension(path).ToLower();
            if (supportedExtensions.Contains(ext) is false)
            {
                return;
            }

            ImgFileName = path;
            SourceImg = new BitmapImage(new Uri(path));
        }
    }
}
