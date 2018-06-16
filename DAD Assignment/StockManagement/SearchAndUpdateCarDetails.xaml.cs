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

namespace DAD_Assignment.Profile_Management
{
    /// <summary>
    /// Interaction logic for SearchAndUpdateCarDetails.xaml
    /// By Nikhil Ladhani
    /// </summary>
    public partial class SearchAndUpdateCarDetails : UserControl
    {
        public SearchAndUpdateCarDetails()
        {
            InitializeComponent();

        }

        System.Windows.Data.CollectionViewSource myCollectionViewSource;
        NBAEntities ctx = new NBAEntities();
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
           myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string model = modelTextBox.Text;
            if (modelTextBox == null)
            {
                MessageBox.Show("Please enter correct Model Name");
            }
            else
            {
                modelDataGrid.ItemsSource = ctx.CarModels.Where(m => m.Model == model).ToList();
            }

        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Car Details Updated Successfully");
            ctx.SaveChanges();
        }
    }
}
