using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using TouristAgency.Model;

namespace TouristAgency.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TravelPackagePage.xaml
    /// </summary>
    public partial class TravelPackagePage : Page
    {
        List<TravelPackage> travelPackages = App.context.TravelPackage.ToList();
        public TravelPackagePage()
        {
            InitializeComponent();
            TravelPackageLv.ItemsSource = travelPackages;
        }

        private void HotCb_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            if (HotCb.IsChecked == true)
            {
                TravelPackageLv.ItemsSource = travelPackages.Where(tp => tp.Hot == true).ToList();
                TrueChoise();
            }
        }
        private void HotCb_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            if (HotCb.IsChecked == false)
            {
                TravelPackageLv.ItemsSource = travelPackages;
            }
        }

        private void ExcursionCb_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            if (ExcursionCb.IsChecked == true)
            {
                TravelPackageLv.ItemsSource = travelPackages.Where(tp => tp.Excursion == true).ToList();
                TrueChoise();
            }
        }

        private void ExcursionCb_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            if (ExcursionCb.IsChecked == false)
            {
                TravelPackageLv.ItemsSource = travelPackages;
            }
        }

        private void TrueChoise()
        {
            if (ExcursionCb.IsChecked == HotCb.IsChecked)
            {
                TravelPackageLv.ItemsSource = travelPackages.Where(tp => tp.Hot == true && tp.Excursion == true).ToList();
            }
        }
    }
}
