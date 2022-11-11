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
    public partial class Find : Form
    {
        function fn = new function();
        String query;
        string fs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Find()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i <sdr.FieldCount;i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(fs);
            string query = "insert into findHome values (@FIRST_NAME,@SECOND_NAME,@NID_NUMBER,@Mobile_NUMBER,@ADDRES,@Check_in,@RoomNo) ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FIRST_NAME", textBox1.Text);
            cmd.Parameters.AddWithValue("@SECOND_NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@NID_NUMBER", textBox4.Text);
            cmd.Parameters.AddWithValue("@Mobile_NUMBER", textBox3.Text);
            cmd.Parameters.AddWithValue("@ADDRES", textBox5.Text);
            cmd.Parameters.AddWithValue("@Check_in", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@RoomNo",comboBox3.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data inserted Sucessfully..");
            }
            else
            {
                MessageBox.Show("Data  not inserted ..");
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(fs);
            query = "select roomno from room where bed= '" + comboBox2.Text + "' and roomtype= '" + comboBox1.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            setComboBox(query, comboBox3);
            comboBox1.Items.Clear();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            query="select price,roomno from room where roomno='"+comboBox3.Text+ "'";
            DataSet ds = fn.getData(query);
            textBox7.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Hide();
            BACHELOR_Info bi = new BACHELOR_Info();
            bi.ShowDialog();
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Hide();
            //ADD_ROOM ad = new ADD_ROOM();
            //ad.ShowDialog();
            //Close();
        }
    }
}
