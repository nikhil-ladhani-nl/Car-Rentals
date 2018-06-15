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

            carsforSaleDG.ItemsSource = ctx.Database.SqlQuery<DisplayCarsForSale>("SELECT CarModel.Model, CarModel.Manufacturer, CarModel.NumberOfSeats, CarModel.EngineSize, IndividualCar.Colour, IndividualCar.Current_Mileage, IndividualCar.Date_Imported, IndividualCar.Status, IndividualCar.Body_Type, CarFeature.Car_Feature_Description FROM CarFeature INNER JOIN FeaturesOnCars ON CarFeature.FeatureID = FeaturesOnCars.Car_Feature_ID INNER JOIN IndividualCar ON FeaturesOnCars.Car_For_Sale_ID = IndividualCar.CarID INNER JOIN CarModel ON IndividualCar.Model_ID = CarModel.ModelID WHERE IndividualCar.Status ='Available'").ToList();

        }
    }
}
