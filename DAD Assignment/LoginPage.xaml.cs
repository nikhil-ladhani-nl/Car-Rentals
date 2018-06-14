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
using System.Windows.Shapes;
using DAL;

namespace DAD_Assignment
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string un = usernameTextBox.Text;
            string pwd = passwordTextBox.Password;

            Employee data = DataStore.getLoginDetail(un, pwd);
            if (data == null)
            {
                MessageBox.Show("Please enter correct login details");
            }
            else
            {
                MainWindow form = new MainWindow();
                form.Show();
                this.Hide();
            }
        }
    }
}
