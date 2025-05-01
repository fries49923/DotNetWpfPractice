using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WpfUserControlAnimationTest
{
    /// <summary>
    /// AnimeUserControl.xaml 的互動邏輯
    /// </summary>
    public partial class AnimeUserControl : UserControl
    {
        public static readonly DependencyProperty PlayFlagProperty =
            DependencyProperty.Register("PlayFlag", typeof(bool),
                typeof(AnimeUserControl), new PropertyMetadata(false, OnPlayFlagChanged));

        public bool PlayFlag
        {
            get => (bool)GetValue(PlayFlagProperty);
            set => SetValue(PlayFlagProperty, value);
        }

        public AnimeUserControl()
        {
            InitializeComponent();
        }

        private static void OnPlayFlagChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                (d as AnimeUserControl)?.UpdateAnimationState();
            }
            catch (Exception)
            { }
        }

        private void UpdateAnimationState()
        {
            try
            {
                var storyboard = Resources["Storyboard1"] as Storyboard;

                if (PlayFlag)
                {
                    storyboard?.Begin(this, true);
                }
                else
                {
                    storyboard?.Stop(this);
                }
            }
            catch (Exception)
            { }

        }
    }
}
