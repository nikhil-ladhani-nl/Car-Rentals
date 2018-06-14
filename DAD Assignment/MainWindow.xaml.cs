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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAD_Assignment.Profile_Management;
using DAD_Assignment.Stock_Management;
using DAL;

namespace DAD_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string role = DataStore.login.Role;
            switch (role)
            {
                case "Staff": mainMenu.Items.Remove();
            }
        }

        private void ACDetails_Click(object sender, RoutedEventArgs e)
        {
            carsalesPanel.Children.Clear();
            carsalesPanel.Children.Add(new AddNewCarInfo());
        }

        private void CFSDetails_Click(object sender, RoutedEventArgs e)
        {
            carsalesPanel.Children.Clear();
            carsalesPanel.Children.Add(new DisplayListOfCarsforSale());
        }

        private void SUPCDetails_Click(object sender, RoutedEventArgs e)
        {
            carsalesPanel.Children.Clear();
            carsalesPanel.Children.Add(new SearchAndUpdateCarDetails());
        }

        private void SACDetails_Click(object sender, RoutedEventArgs e)
        {
            carsalesPanel.Children.Clear();
            carsalesPanel.Children.Add(new DisplayCarDetails());
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }
    }
}
