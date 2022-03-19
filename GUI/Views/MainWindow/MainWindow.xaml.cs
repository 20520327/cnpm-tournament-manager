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
            ResetNavItemsToDefault();
            LbAdding.Style = Resources["NavItemClickedStyle"] as Style;
            FrContainer.Content = new PageAddingI();
        }

        private void ResetNavItemsToDefault()
        {
            LbStatistic.Style = Resources["NavItemStyle"] as Style;
            LbConfirm.Style = Resources["NavItemStyle"] as Style;
            LbTour.Style = Resources["NavItemStyle"] as Style;
            LbTourGroup.Style = Resources["NavItemStyle"] as Style;
            LbAdding.Style = Resources["NavItemStyle"] as Style;
        }
    }
}