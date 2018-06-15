using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;

namespace DAD_Assignment
{
    class Validation
    {
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
    }
}
