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
        }

        private void LbTour_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrAddingContainer.Content = new PageAddingTour();
        }

        private void LbDestination_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrAddingContainer.Content = new PageAddingDestination();
        }

        private void LbHotel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrAddingContainer.Content = new PageAddingHotel();
        }

        private void LbTourGroup_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrAddingContainer.Content = new PageAddingTourGroup();
        }
    }
}
