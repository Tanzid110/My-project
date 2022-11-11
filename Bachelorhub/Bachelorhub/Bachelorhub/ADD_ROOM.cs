using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Bachelorhub;

namespace Add_Room
{
    public partial class ADD_ROOM : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public ADD_ROOM()
        {
            InitializeComponent();
            DataGridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && comboBox1.Text!="" && comboBox2.Text!="" & textBox2.Text!="")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into ROOM values (@roomNo,@roomType,@bed,@price )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roomNo", textBox1.Text);
                cmd.Parameters.AddWithValue("@roomType", comboBox1.Text);
                cmd.Parameters.AddWithValue("@bed", comboBox2.Text);
                cmd.Parameters.AddWithValue("@price", textBox2.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if(a>0)
                {
                    MessageBox.Show("Data inserted sucessfully");
                    DataGridview();
                    clearALL();
                }
                else
                {
                    MessageBox.Show("Data  not inserted");
                }
                

            }
            else
            {
                MessageBox.Show("Please fill the field first!");
            }
            
         
        }

        void DataGridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Room";
            SqlDataAdapter sda= new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
             sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void clearALL()
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox2.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Find f = new Find();
            f.ShowDialog();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Hide();
            BACHELOR_Info bi = new BACHELOR_Info();
            bi.ShowDialog();
            Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Hide();
            BARIWALA b = new BARIWALA();
            b.ShowDialog();
            Close();
        }
    }
}
