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
using DAL;

namespace DAD_Assignment.Stock_Management
{
    /// <summary>
    /// Interaction logic for AddDetailsofNewEmployee.xaml
    /// </summary>
    public partial class AddDetailsofNewEmployee : UserControl
    {
        public AddDetailsofNewEmployee()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee();
            emp.Office_Address = office_AddressTextBox.Text;
            emp.Password = passwordTextBox.Text;
            emp.Phone_Extension_Number = phone_Extension_NumberTextBox.Text;
            emp.Role = roleTextBox.Text;
            emp.Username = usernameTextBox.Text;
            DataStore.addEmployee(emp);
            MessageBox.Show("Employee added successfully");
        }
    }
}
