using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bfmsproject
{
    public static class FieldValidation
    {
        public static bool integervalidation(string checkint)
        {
            
            
            //Regex reg = new Regex(@"[^0-9]*.[0-9]{1,2}$|[^0-9]*$");
            Regex reg = new Regex(@"^[0-9]+$");

            if (false == reg.IsMatch(checkint))
            {
                MessageBox.Show("validation error "+ checkint);
                return true;
            }
            else
                return false;
           
        }
        public static bool integerorfloat(string checkfloatorint)
        {
            Regex reg = new Regex(@"^[0-9]+$|^[0-9]+.[0-9]{1,2}$");

            if (false == reg.IsMatch(checkfloatorint))
            {
                MessageBox.Show("validation error " + checkfloatorint);
                return true;
            }
            else
                return false;
            
        }
    }
}
