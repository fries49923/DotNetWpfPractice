using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using OpenCvSharp;
using OpenCvSharp.WpfExtensions;
using System.Windows.Media.Imaging;

namespace WpfOpenCvImprocTest
{
    public partial class MainViewModel : ObservableObject
    {
        private Mat? cvImg;

        [ObservableProperty]
        private BitmapSource? _image;

        public MainViewModel()
        {
            cvImg = null;
        }

        [RelayCommand]
        public void RunTest01()
        {
            // Color2Gray

            if (GetImgFilePath(out var filePath) is false)
            {
                return;
            }

            cvImg = Cv2.ImRead(filePath, ImreadModes.Grayscale);
            Image = cvImg.ToBitmapSource();
        }

        [RelayCommand]
        public void RunTest02()
        {
            // Sobel

            if (GetImgFilePath(out var filePath) is false)
            {
                return;
            }

            var grayImg = Cv2.ImRead(filePath, ImreadModes.Grayscale);
            cvImg = grayImg.Sobel(MatType.CV_8U, 1, 1);

            Image = cvImg.ToBitmapSource();
        }

        [RelayCommand]
        public void RunTest03()
        {
            // Labeling

            if (GetImgFilePath(out var filePath) is false)
            {
                return;
            }

            var grayImg = Cv2.ImRead(filePath, ImreadModes.Grayscale);
            var binImg = grayImg.Threshold(0, 255, ThresholdTypes.Otsu);

            // find object
            var labels = new Mat();
            var stats = new Mat();
            var centroids = new Mat();
            int numLabels = Cv2.ConnectedComponentsWithStats(binImg, labels, stats, centroids);

            // draw color
            var colored = new Mat(grayImg.Size(), MatType.CV_8UC3);
            var rand = new Random();
            var colors = new List<Vec3b> { new(0, 0, 0) };

            for (int i = 1; i < numLabels; i++)
            {
                colors.Add(new Vec3b((byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256)));
            }

            for (int y = 0; y < labels.Rows; y++)
            {
                for (int x = 0; x < labels.Cols; x++)
                {
                    int label = labels.At<int>(y, x);
                    colored.Set(y, x, colors[label]);
                }
            }

            cvImg = colored;
            Image = cvImg.ToBitmapSource();
        }

        [RelayCommand]
        public void RunTest04()
        {
            // Contours

            if (GetImgFilePath(out var filePath) is false)
            {
                return;
            }

            var grayImg = Cv2.ImRead(filePath, ImreadModes.Grayscale);
            var binImg = grayImg.Threshold(0, 255, ThresholdTypes.Otsu);

            Cv2.FindContours(
                binImg,
                out Point[][] contours,
                out HierarchyIndex[] hierarchy,
                RetrievalModes.External,
                ContourApproximationModes.ApproxSimple);

            var result = new Mat(grayImg.Size(), MatType.CV_8UC3, Scalar.Black);
            Cv2.DrawContours(result, contours, -1, Scalar.White, 2);

            cvImg = result;
            Image = cvImg.ToBitmapSource();
        }

        [RelayCommand]
        public void RunTest05()
        {
            // Capture

            using var capture = new VideoCapture(0);
            var frame = new Mat();

            if (capture.IsOpened() is false)
            {
                return;
            }

            // Capture one frame
            capture.Read(frame);
            if (frame.Empty() is true)
            {
                return;
            }

            Image = frame.ToBitmapSource();
        }

        private static bool GetImgFilePath(out string filePath)
        {
            filePath = "";

            var dlg = new OpenFileDialog
            {
                Filter = "JPEG Image|*.jpg;*.jpeg|BMP Image|*.bmp|TIF Image|*.tif;*.tiff|PNG Image|*.png|All files|*.*",
                FilterIndex = 1
            };

            var result = dlg.ShowDialog();
            if (result is true)
            {
                filePath = dlg.FileName;
            }

            return result ?? false;
        }
    }
}
