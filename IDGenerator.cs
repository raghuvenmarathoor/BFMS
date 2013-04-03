using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bfmsproject
{
    public static class IDGenerator
    {
       
        public static string generatenext(string lastval)
        {
            try
            {
                               
                var pattern = new Regex(@"[a-z]|[A-Z]");
                int countofalphabet = pattern.Matches(lastval).Count;
                Int64 lastnum = Convert.ToInt64(lastval.Substring(countofalphabet));
                lastnum++;
                string ret = lastval.Substring(0, countofalphabet);
                string nextval = ret + lastnum.ToString();
                return nextval;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to generate new ID because of the error:\n " + e.Message.ToString());
                return null;
               
                }

            
        }
    }
}
