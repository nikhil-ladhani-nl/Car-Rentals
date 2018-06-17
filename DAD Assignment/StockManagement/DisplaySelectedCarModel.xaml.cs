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
        }

        NBAEntities ctx = new NBAEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource carModelViewSource = ((CollectionViewSource)(this.FindResource("carModelViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            carModelViewSource.Source = ctx.CarModels.ToList();
        }
    }
}
