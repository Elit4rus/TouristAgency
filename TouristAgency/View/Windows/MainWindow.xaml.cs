using System.Windows;
using TouristAgency.AppData;

namespace TouristAgency
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameHelper.mainFrame = MainFrame;
        }
    }
}
