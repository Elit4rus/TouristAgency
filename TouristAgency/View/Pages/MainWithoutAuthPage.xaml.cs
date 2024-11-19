using System.Windows.Controls;
using TouristAgency.AppData;
using TouristAgency.View.Windows;

namespace TouristAgency.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainWithoutAuthPage.xaml
    /// </summary>
    public partial class MainWithoutAuthPage : Page
    {
        public MainWithoutAuthPage()
        {
            InitializeComponent();
            FrameHelper.secondFrame = SecondFrame;
            SecondFrame.Navigate(new View.Pages.TravelPackagePage());
        }

        private void LoginBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
        }
    }
}
