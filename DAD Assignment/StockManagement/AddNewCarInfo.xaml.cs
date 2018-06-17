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
    /// Interaction logic for AddNewCarInfo.xaml
    /// By Nikhil Ladhani
    /// </summary>
    public partial class AddNewCarInfo : UserControl
    {
        public AddNewCarInfo()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string validation1 = Validation.ValidEmptyFields(carDetailsGrid);
            if (validation1 != null)
            {
                MessageBox.Show(validation1);
            }
            else
            {
                string validation2 = Validation.ValidEmptyFields(carModelGrid);
                if (validation2 != null)
                {
                    MessageBox.Show(validation2);
                }
                else
                {
                    string validation3 = Validation.ValidEmptyFields(carModelGrid);
                    if (validation3 != null)
                    {
                        MessageBox.Show(validation3);
                    }
                    else
                    {
                        CarModel cm = new CarModel();
                        cm.EngineSize = double.Parse(engineSizeTextBox.Text);
                        cm.Manufacturer = manufacturerTextBox.Text;
                        cm.Model = modelTextBox.Text;
                        cm.NumberOfSeats = int.Parse(numberOfSeatsTextBox.Text);

                        IndividualCar ic = new IndividualCar();
                        ic.Body_Type = body_TypeTextBox.Text;
                        ic.Colour = colourTextBox.Text;
                        ic.Current_Mileage = current_MileageTextBox.Text;
                        ic.Date_Imported = date_ImportedTextBox.Text;
                        ic.Manufacture_Year = int.Parse(manufacture_YearTextBox.Text);
                        ic.Status = statusTextBox.Text;
                        ic.Transmission = transmissionTextBox.Text;

                        CarFeature cf = new CarFeature();
                        cf.Car_Feature_Description = car_Feature_DescriptionTextBox.Text;
                        DataStore.addNewCarDetails(cf, cm, ic);
                        MessageBox.Show("Car added successfully");
                    }
                }
            }                     
            body_TypeTextBox.Clear(); colourTextBox.Clear();
            current_MileageTextBox.Clear(); date_ImportedTextBox.Clear();
            manufacturerTextBox.Clear(); manufacture_YearTextBox.Clear();
            statusTextBox.Clear(); transmissionTextBox.Clear();
            engineSizeTextBox.Clear(); modelTextBox.Clear();
            numberOfSeatsTextBox.Clear();

        }
    }
}
