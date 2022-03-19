using GUI.Views.MainWindow;
using System.Windows;

namespace GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {

        public void AppStart(object sender, StartupEventArgs e)
        {
            //goi ưindơ ra
            MainWindow = new MainWindow();
            MainWindow.Show();
        }

    }
}