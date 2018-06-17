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
    /// Interaction logic for SearchCustomerByID.xaml
    /// </summary>
    public partial class SearchCustomerByID : UserControl
    {
        NBAEntities ctx = new NBAEntities();
        public SearchCustomerByID()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["myCollectionViewSource"];
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtCID.Text);

            customerDataGrid.ItemsSource = ctx.Customers.Where(c => c.CustomerID == id).ToList();
            personDataGrid.ItemsSource = ctx.People.Where(p => p.Customer.CustomerID == id).ToList();
           
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ctx.SaveChanges();
        }
    }
}
