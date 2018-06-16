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

namespace DAD_Assignment
{
    /// <summary>
    /// Interaction logic for DisplayCarModel.xaml
    /// </summary>
    public partial class DisplayCarModel : UserControl
    {
        public DisplayCarModel()
        {
            InitializeComponent();
            bindCombo();

        }
        public List<CarModel> Model { get; set; }
        private void bindCombo()
        {
            //throw new NotImplementedException();
            NBAEntities ctx = new NBAEntities();
            var model = ctx.CarModels.ToList();
            Model = model;
            DataContext = Model;
        }
        NBAEntities ctx = new NBAEntities();
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            carModelGrid.ItemsSource = carModelCombo.SelectedItem.ToString();
        }
    }
}
