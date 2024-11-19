using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TouristAgency.Model;

namespace TouristAgency.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        List<Client> clients = App.context.Client.ToList();
        public ClientsPage()
        {
            InitializeComponent();
            ClientLv.ItemsSource = clients;
        }

        private void AddBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                Client newClient = new Client()
                {
                    Surname = SurnameTb.Text,
                    Name = NameTb.Text,
                    Patronymic = PatronymicTb.Text,
                    Phone = PhoneTb.Text,
                    Passport = PassportTb.Text,
                    RegDate = DateTime.Now.Date
                };
                App.context.Client.Add(newClient);
                App.context.SaveChanges();
                MessageBox.Show("Пользователь успешно добавлен!");
                clients = App.context.Client.ToList();
                ClientLv.ItemsSource = clients;
                SurnameTb.Text = "";
                NameTb.Text = "";
                PatronymicTb.Text = "";
                PhoneTb.Text = "";
                PassportTb.Text = "";
            }
            catch
            {
                MessageBox.Show("Данные введены неверно!");
            }
        }
    }
}
