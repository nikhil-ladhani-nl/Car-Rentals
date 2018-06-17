using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DAL
{
   public class DataStore
    {
        static public Employee login = null;

        //add new car info by Nikhil Ladhani
        static public void addNewCarDetails(CarFeature cf, CarModel cm, IndividualCar ic)
        {
            using (NBAEntities ctx = new NBAEntities())
            {
                ctx.CarFeatures.Add(cf);
                ctx.CarModels.Add(cm);
                ctx.IndividualCars.Add(ic);
                ctx.SaveChanges();
            }
        }
        //login coded by Nikhil Ladhani
        static public Employee getLoginDetail(String un, String pwd)
        {
            using (NBAEntities ctx = new NBAEntities())
            {
                login = ctx.Employees.Where(e => e.Username == un && e.Password == pwd).FirstOrDefault();
            }
            return login;
        }

        //add new car info by Brodie Allen
        static public void addEmployee(Employee emp, Person psn)
        {
            using (NBAEntities ctx = new NBAEntities())
            {
                //emp.EmployeeID = login.EmployeeID;
                ctx.Employees.Add(emp);
                ctx.People.Add(psn);
                ctx.SaveChanges();
            }
        }
        static public void addCustomer(Customer cust, Person psn)
        {
            using (NBAEntities ctx = new NBAEntities())
            {
                emp.EmployeeID = login.EmployeeID;
                ctx.Customers.Add(cust);
                ctx.People.Add(psn);
                ctx.SaveChanges();
            }
        }
    }
}
