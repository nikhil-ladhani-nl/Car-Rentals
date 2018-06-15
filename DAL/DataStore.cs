﻿using System;
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
        static public string validEmptyFields(Grid data)
        {
            string message = null;
            foreach (Control ctl in data.Children)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)ctl;
                    if (tb.Text.Length == 0)
                    {
                        message = message + "Please enter value for " + tb.Uid + "\n";
                    }
                }
            }
            return message;
        }

        static public void addEmployee(Employee emp)
        {
            using (NBAEntities ctx = new NBAEntities())
            {
                //emp.EmployeeID = login.EmployeeID;
                ctx.Employees.Add(emp);
                ctx.SaveChanges();
            }
        }
    }
}
