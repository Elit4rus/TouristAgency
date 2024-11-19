using System.Windows;
using TouristAgency.Model;

namespace TouristAgency
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TouristAgencyEntities context = new TouristAgencyEntities();
    }
}
