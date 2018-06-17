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

namespace DAD_Assignment.ProfileManagement
{
    /// <summary>
    /// Interaction logic for EditEmployeeLoggedIn.xaml
    /// </summary>
    public partial class EditEmployeeLoggedIn : UserControl
    {
        NBAEntities ctx = new NBAEntities();
        public EditEmployeeLoggedIn()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for myCollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;

            employeeDataGrid.ItemsSource = ctx.Employees.Where(em => em.Username == username).ToList();
            personDataGrid.ItemsSource = ctx.People.Where(p => p.Employee.Username == username).ToList();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ctx.SaveChanges();
        }
    }
}
