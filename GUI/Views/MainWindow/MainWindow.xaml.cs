using System;
using GUI.Views.Pages;
using System.Windows;

namespace GUI.Views.MainWindow
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LbStatistic_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void LbAdding_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            FrContainer.Content = new PageAddingI();
        }
    }
}