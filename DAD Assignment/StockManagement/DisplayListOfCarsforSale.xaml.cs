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
    /// Interaction logic for DisplayListOfCarsforSale.xaml
    /// </summary>
    public partial class DisplayListOfCarsforSale : UserControl
    {
        public DisplayListOfCarsforSale()
        {
            InitializeComponent();

            NBAEntities ctx = new NBAEntities();

            carsforSaleDG.ItemsSource = ctx.Database.SqlQuery<IndividualCar>("select ic.Sale_Price, ic.Customer_Id, cf.Car_feature_Description as CarForSale from Cars_Sold ic inner join FeaturesOnCars fc on ic.Car_For_Sale_Id = fc.Car_For_Sale_ID inner join CarFeature cf on cf.FeatureID = fc.Car_Feature_ID where ic.Sale_Price = 'Available'").ToList();

        }
    }
}
