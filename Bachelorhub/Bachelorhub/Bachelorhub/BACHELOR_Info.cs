using Add_Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bachelorhub
{
    public partial class BACHELOR_Info : Form
    {
        function fn = new function();
        String query;
        string fs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public BACHELOR_Info()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(fs);
            cone.Open();
            SqlDataAdapter sqlDat = new SqlDataAdapter("select * from findHome", cone);
            DataTable dtble = new DataTable();
            sqlDat.Fill(dtble);
            dataGridView1.DataSource = dtble;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cone.Close();
            //query = "select EMPLOYEE_DETAILS.firstname,EMPLOYEE_DETAILS.secondname,EMPLOYEE_DETAILS.occupation,EMPLOYEE_DETAILS.nid_number,EMPLOYEE_DETAILS.Blood_group,EMPLOYEE_DETAILS.contact_number,EMPLOYEE_DETAILS.emergency_number,EMPLOYEE_DETAILS.address,EMPLOYEE_DETAILS.institution_name,EMPLOYEE_DETAILS.email,EMPLOYEE_DETAILS.image,EMPLOYEE_DETAILS.nid_image,EMPLOYEE_DETAILS.user_name,EMPLOYEE_DETAILS.pass";
            //DataSet ds = fn.getData(query);
            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Hide();
            //ADD_ROOM ad = new ADD_ROOM();
            //ad.ShowDialog();
            //Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Find fh = new Find();
            fh.ShowDialog();
            Close();
        }
    }
}
