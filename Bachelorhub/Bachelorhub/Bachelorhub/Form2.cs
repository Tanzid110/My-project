using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Bachelorhub
{
    public partial class Form2 : Form
    {
        string connect = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection link = new SqlConnection(connect);
            string query = "Insert into employee_details values (@firstname,@secondname,@occupation,@nid_number,@Blood_group,@contact_number,@emergency_number,@address,@institution_name,@email,@image,@nid_image,@user_name,@pass)";
            SqlCommand cmd = new SqlCommand(query, link);
            cmd.Parameters.AddWithValue("@firstname", textBox1.Text);
            cmd.Parameters.AddWithValue("@secondname", textBox2.Text);
            cmd.Parameters.AddWithValue("@occupation", textBox6.Text);
            cmd.Parameters.AddWithValue("@nid_number", textBox8.Text);
            cmd.Parameters.AddWithValue("@Blood_group", textBox7.Text);
            cmd.Parameters.AddWithValue("@contact_number", textBox10.Text);
            cmd.Parameters.AddWithValue("@emergency_number", textBox9.Text);
            cmd.Parameters.AddWithValue("@address", textBox5.Text);
            cmd.Parameters.AddWithValue("@institution_name", textBox4.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());
            cmd.Parameters.AddWithValue("@nid_image", SavePhoto());
            cmd.Parameters.AddWithValue("@user_name", textBox11.Text);
            cmd.Parameters.AddWithValue("@pass", textBox12.Text);
            link.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data inserted Sucessfully..");
            }
            else
            {
                MessageBox.Show("Data  not inserted ..");
            }
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            return ms.GetBuffer();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "All Images Files *_*)| *_*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog abc = new OpenFileDialog();
            abc.Title = "Select Image";
            abc.Filter = "All Images Files *_*)| *_*";
            if (abc.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = new Bitmap(abc.FileName);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            HOME h = new HOME();
            h.ShowDialog();
            Close();
        }
    }
}
