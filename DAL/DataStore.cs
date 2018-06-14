using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DataStore
    {
        static public Employee login = null;
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
        static public Employee getLoginDetail(String un, String pwd)
        {
            using (NBAEntities ctx = new NBAEntities())
            {
                login = ctx.Employees.Where(e => e.Username == un && e.Password == pwd).FirstOrDefault();
            }
            return login;
        }
    }
}
