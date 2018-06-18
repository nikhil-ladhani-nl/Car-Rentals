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

namespace DAD_Assignment.Stock_Management
{
    /// <summary>
    /// Interaction logic for SearchEmployeeByID.xaml
    /// </summary>
    public partial class SearchEmployeeByID : UserControl
    {
        NBAEntities ctx = new NBAEntities();

        public SearchEmployeeByID()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {


            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["myCollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ctx.SaveChanges();

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string output = Validation.ValidEmptyFields(grid2);
            if (output != null)
            {
                MessageBox.Show(output);
            }
            else
            {
                int employeeID;
                if (int.TryParse(employeeIDTextBox.Text, out employeeID))
                {

                }
                else
                {
                    MessageBox.Show("Please enter ID as number not as text");
                }
            }
            try {
                int id = int.Parse(employeeIDTextBox.Text);

                employeeDataGrid.ItemsSource = ctx.Employees.Where(em => em.EmployeeID == id).ToList();
                personDataGrid.ItemsSource = ctx.People.Where(p => p.Employee.EmployeeID == id).ToList();
            }
            catch
            {
                MessageBox.Show("Please Try Again");
            }





        }
    }
}
