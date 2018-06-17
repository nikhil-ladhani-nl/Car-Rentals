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
using System.Windows.Shapes;
using DAL;

namespace DAD_Assignment
{
    /// <summary>
    /// Interaction logic for DisplaySelectedCarModel.xaml
    /// </summary>
    public partial class DisplaySelectedCarModel : Window
    {
        public DisplaySelectedCarModel()
        {
            InitializeComponent();
            bindComboBox();
        }
        public List<CarModel> carModel { get; set; }
        private void bindComboBox()
        {
            //throw new NotImplementedException();
            NBAEntities ctx = new NBAEntities();
            var carModels = ctx.CarModels.ToList();
            carModel = carModels;
            DataContext = carModel;
        }
        NBAEntities ctx = new NBAEntities();

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string model = modelComboBox.Text;
            var carModels = modelComboBox.SelectedItem as CarModel;
            carModelListView.ItemsSource = ctx.CarModels.Where(cm => cm.Model == model).ToList();
            individualCarListView.ItemsSource = ctx.CarModels.Where(cm => cm.Model == model).ToList();
            carFeatureListView.ItemsSource = ctx.CarModels.Where(cm => cm.Model == model).ToList();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource carFeatureViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carFeatureViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // carFeatureViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource carModelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carModelViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // carModelViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource individualCarViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("individualCarViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // individualCarViewSource.Source = [generic data source]
        }
    }
}
