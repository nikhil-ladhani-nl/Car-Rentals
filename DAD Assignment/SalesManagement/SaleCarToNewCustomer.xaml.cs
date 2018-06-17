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

namespace DAD_Assignment.Sales_Management
{
    /// <summary>
    /// Interaction logic for SaleCarToCustomer.xaml
    /// </summary>
    public partial class SaleCarToCustomer : UserControl
    {
        public SaleCarToCustomer()
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
            System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for myCollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void btnSell_Click(object sender, RoutedEventArgs e)
        {
            NBAEntities ctx = new NBAEntities();
            Customer cust = new Customer();
            cust.Age = int.Parse(ageTextBox.Text);
            cust.Licence_Number = licence_NumberTextBox.Text;
            ctx.Customers.Add(cust);

            Person psn = new Person();
            psn.Address = addressTextBox.Text;
            psn.Name = nameTextBox.Text;
            psn.Telephone = telephoneTextBox.Text;
            DataStore.addCustomer(cust, psn);

            int Car_for_sale_ID = int.Parse(car_For_Sale_IdTextBox.Text);
            Cars_Sold cs = ctx.Cars_Sold.Where(sc => sc.Car_For_Sale_Id == Car_for_sale_ID).FirstOrDefault();

            Cars_Sold sale = new Cars_Sold();
            sale.Car_For_Sale_Id = Car_for_sale_ID;
            sale.Customer = cust;
            sale.Date_Sold = DateTime.Now;


            ctx.Cars_Sold.Add(sale);
            ctx.SaveChanges();
            MessageBox.Show("Car has been sold to new customer");


        }
    }
}
