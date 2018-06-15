﻿using System;
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
    /// Interaction logic for DisplayCarDetails.xaml
    /// By Nikhil Ladhani
    /// </summary>
    public partial class DisplayCarDetails : UserControl
    {
        public DisplayCarDetails()
        {
            InitializeComponent();

            //displaySelectedModelGrid.ItemsSource = ctx.Database.SqlQuery<DisplaySelectedCarModel>("SELECT CarModel.Model, IndividualCar.Colour, IndividualCar.Current_Mileage, IndividualCar.Status, IndividualCar.Body_Type, CarFeature.Car_Feature_Description FROM CarFeature INNER JOIN FeaturesOnCars ON CarFeature.FeatureID = FeaturesOnCars.Car_Feature_ID INNER JOIN IndividualCar ON FeaturesOnCars.Car_For_Sale_ID = IndividualCar.CarID INNER JOIN CarModel ON IndividualCar.Model_ID = CarModel.ModelID WHERE CarModel.Model = 'CarModel.Model'").ToList();
        }

        NBAEntities ctx = new NBAEntities();
        CarModel modell = null;
        System.Windows.Data.CollectionViewSource myCollectionViewSource;
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

        private void modelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string model = modelComboBox.Text;
            modell = ctx.CarModels.Where(cm => cm.Model == model).FirstOrDefault();
            if (modell == null)
            {
                MessageBox.Show("Please Select Model");
            }
            else
            {
                MessageBox.Show(model + "Selected");
            }

        }
    }
}
