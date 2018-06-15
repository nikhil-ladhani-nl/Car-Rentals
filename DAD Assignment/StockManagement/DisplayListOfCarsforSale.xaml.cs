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
    /// By Nikhil Ladhani
    /// </summary>
    public partial class DisplayListOfCarsforSale : UserControl
    {
        public DisplayListOfCarsforSale()
        {
            InitializeComponent();

            NBAEntities ctx = new NBAEntities();

            carsforSaleDG.ItemsSource = ctx.Database.SqlQuery<DisplayCarsForSale>("SELECT CarModel.Model, CarModel.Manufacturer, CarModel.NumberOfSeats, CarModel.EngineSize, CarModel.ModelID, IndividualCar.Body_Type, IndividualCar.Status, IndividualCar.Transmission, IndividualCar.Manufacture_Year,IndividualCar.Date_Imported, IndividualCar.Current_Mileage, IndividualCar.Colour, IndividualCar.CarID FROM CarModel INNER JOIN IndividualCar ON CarModel.ModelID = IndividualCar.Model_ID WHERE IndividualCar.Status = 'Available'").ToList();

        }
    }
}
