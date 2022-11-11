using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bachelorhub
{
    class function
    {
        protected SqlConnection getConnection ()
        {
            //string connect = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
           // con.ConnectionString = "data source = DESKTOP-7M2VR5J\\SQLEXPRESS;database=BACHELOR_LOGIN_DB;integrated security = True";
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //public void setData (String query, String message)
        //{
        //    SqlConnection con = getConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    con.Open();
        //    cmd.CommandText = query;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    MessageBox.Show("" + message + "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();

            return sdr;
        }
    }
}
