using System.Linq;
using System.Windows;
using TouristAgency.Model;

namespace TouristAgency.AppData
{
    internal class AuthHelper
    {
        public static TourAgent currentAgent;
        public static bool CheckData(string login, string password)
        {
            currentAgent = App.context.TourAgent.FirstOrDefault(d => d.Login == login && d.Password == password);
            if (currentAgent != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
                return false;
            }
        }
    }
}
