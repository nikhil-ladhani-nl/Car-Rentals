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

namespace DAD_Assignment.ProfileManagement
{
    /// <summary>
    /// Interaction logic for ViewPersonByID.xaml
    /// </summary>
    public partial class ViewPersonByID : UserControl
    {
        NBAEntities ctx = new NBAEntities();
        public ViewPersonByID()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string output = Validation.ValidEmptyFields(grid1);
            if (output != null)
            {
                MessageBox.Show(output);
            }
            else
            {
                int personID;
                if (int.TryParse(personIDTextBox.Text, out personID))
                {

                }
                else
                {
                    MessageBox.Show("Please enter ID as number not as text");
                }
            }
            try
            {
                int id = int.Parse(personIDTextBox.Text);

                personDataGrid.ItemsSource = ctx.People.Where(p => p.PersonID == id).ToList();
            }
            catch
            {
                MessageBox.Show("Please Try Again");
            }
        }
    }
}
