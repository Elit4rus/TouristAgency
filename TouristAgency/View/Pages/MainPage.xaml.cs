using System.Windows;
using System.Windows.Controls;
using TouristAgency.AppData;
using TouristAgency.View.Windows;

namespace TouristAgency.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            FrameHelper.secondFrame = SecondFrame;
            FullnameTbl.Text = AuthHelper.currentAgent.Surname + " " + AuthHelper.currentAgent.Name + " " + AuthHelper.currentAgent.Patronymic;
        }

        private void TravelPackageBtn_Click(object sender, RoutedEventArgs e)
        {
            SecondFrame.Navigate(new View.Pages.TravelPackagePage());
        }

        private void ClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            SecondFrame.Navigate(new View.Pages.ClientsPage());
        }

        private void OutBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
        }
    }
}
