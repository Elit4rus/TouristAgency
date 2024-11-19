using System.Windows;
using TouristAgency.AppData;

namespace TouristAgency.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthHelper.CheckData(LoginTb.Text, PasswordTb.Text) == true)
            {
                FrameHelper.mainFrame.Navigate(new View.Pages.MainPage());
                Close();
            }
        }

        private void LoginWithoutAuthHl_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
            FrameHelper.mainFrame.Navigate(new View.Pages.MainWithoutAuthPage());
        }
    }
}
