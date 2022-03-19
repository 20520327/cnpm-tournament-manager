using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

using GUI.Views.Pages;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI.Views.Pages
{
    /// <summary>
    /// Interaction logic for PageAddingI.xaml
    /// </summary>
    public partial class PageAddingI : Page
    {
        public PageAddingI()
        {
            InitializeComponent();
            LbTour.Style = Resources["NavItemClickedStyle"] as Style;
            FrAddingContainer.Content = new PageAddingTour();
        }

        private void LbTour_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ResetNavItemsToDefault();
            LbTour.Style = Resources["NavItemClickedStyle"] as Style;
            FrAddingContainer.Content = new PageAddingTour();
        }

        private void LbDestination_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ResetNavItemsToDefault();
            LbDestination.Style = Application.Current.Resources["NavItemClickedStyle"] as Style;
            FrAddingContainer.Content = new PageAddingDestination();
        }

        private void LbHotel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ResetNavItemsToDefault();
            LbHotel.Style = Application.Current.Resources["NavItemClickedStyle"] as Style;
            FrAddingContainer.Content = new PageAddingHotel();
        }

        private void LbTourGroup_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ResetNavItemsToDefault();
            LbTourGroup.Style = Application.Current.Resources["NavItemClickedStyle"] as Style;
            FrAddingContainer.Content = new PageAddingTourGroup();
        }

        private void ResetNavItemsToDefault()
        {
            LbDestination.Style = Resources["NavItemStyle"] as Style;
            LbTour.Style = Resources["NavItemStyle"] as Style;
            LbTourGroup.Style = Resources["NavItemStyle"] as Style;
            LbHotel.Style = Resources["NavItemStyle"] as Style;
        }
    }
}
