using System.Diagnostics;
using System.Windows;

namespace WpfCommandLineTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var arg = "";

            // e.Args 是 string[]，命令列參數
            if (e.Args.Length > 0)
            {
                Debug.WriteLine("e.Args.Length > 0");
                arg = e.Args[0];
            }

            Window window = arg switch
            {
                "view1" => new Window1(),
                "view2" => new Window2(),
                _ => new MainWindow(),
            };

            window.Show();
        }
    }
}
