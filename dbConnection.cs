using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace bfmsproject
{
    public static class dbConnection
    {
        public static void setconstring()
        {
            bool flg = false;
            
            SqlConnection con;

            

            
                
                
                
                try
                {
                    con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Raghu\Documents\Visual Studio 2010\Projects\bfmsproject\Resources\bfmbd.mdf;Integrated Security=True;User Instance=True");
                    con.Open();

                    Properties.Settings.Default.currentconnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Raghu\Documents\Visual Studio 2010\Projects\bfmsproject\Resources\bfmbd.mdf;Integrated Security=True;User Instance=True";
                    Properties.Settings.Default.Save();
                    MessageBox.Show("The current connection String:\n"+Properties.Settings.Default.currentconnection);
                  
                    flg = true;

                }
                catch
                {
                    try
                    {
                        con = new SqlConnection(@"Data Source=10.10.10.3;Initial Catalog=bfmsbd;Persist Security Info=True;User ID=mca2010;Password=sql123");
                        con.Open();

                        Properties.Settings.Default.currentconnection = @"Data Source=10.10.10.3;Initial Catalog=bfmsbd;Persist Security Info=True;User ID=mca2010;Password=sql123";
                        Properties.Settings.Default.Save();
                        MessageBox.Show("The current connection String:\n" + Properties.Settings.Default.currentconnection);

                        flg = true;
                    }
                    catch
                    {
                        MessageBox.Show("Failed To Connect to Database");
                    }
                }
            
            
           
            
        }
       
        public static void exenonquery(string abc)
        {

            try
            {
                string constr = @Properties.Settings.Default.currentconnection;
               
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection(constr);
                con.Close();
                con.Open();
                cmd = new SqlCommand(abc, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Execution of query failed.\n Error Code:" + e.Message);
                setconstring();
            }
        }
        public static SqlDataReader query(string abc)
        {
            try
            {

               
                string constr = @Properties.Settings.Default.currentconnection;
               
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection(constr);
                con.Close();
                con.Open();
               
                
                
                SqlDataReader dr;
                cmd = new SqlCommand(abc, con);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception e)
            {
                MessageBox.Show("Execution of query failed.\n Error Code:" + e.Message);
                setconstring();
                return null;
            }


        }
        public static string executescalar(string str)
        {
            try
            {
                string constr = @Properties.Settings.Default.currentconnection;
                
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection(constr);
                con.Close();
                con.Open();

                cmd = new SqlCommand(str, con);
                string res = cmd.ExecuteScalar().ToString();
                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                setconstring();
                return "scalar function error";

            }
        }

    }
}
