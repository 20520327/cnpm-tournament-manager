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
            //Call Mainwindow
            MainWindow = new MainWindow();
            MainWindow.Show();
        }

    }
}