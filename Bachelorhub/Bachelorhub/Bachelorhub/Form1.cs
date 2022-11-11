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


namespace Bachelorhub
{
    public partial class Form1 : Form
    {
        string connect = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection link = new SqlConnection(connect);
                string query = "select * from login_tble where username=@user and pass=@pass";
                SqlCommand cmd = new SqlCommand(query, link);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                link.Open();
                SqlDataReader cr = cmd.ExecuteReader();
                if (cr.HasRows == true)
                {
                   MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    admin a = new admin();
                    a.ShowDialog();
                    Close();
                    
                }
                link.Close();

            }
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection link = new SqlConnection(connect);
                string query = "select * from HOME_tble where username=@user and pass=@pass";
                SqlCommand cmd = new SqlCommand(query, link);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                link.Open();
                SqlDataReader cr = cmd.ExecuteReader();
                if (cr.HasRows == true)
                {
                    MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    BARIWALA b = new BARIWALA();
                    b.ShowDialog();
                    Close();

                }
                link.Close();

            }
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection gn = new SqlConnection(connect);
                string info = "select * from EMPLOYEE_DETAILS where username=@user and pass=@pass";
                SqlCommand cmd = new SqlCommand(info, gn);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                gn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    Find f3 = new Find();
                    f3.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("Login Failed. Please enter correct user name and password .", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                gn.Close();
            }

            else
            {
                MessageBox.Show("Please field all the fiels.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Please fill the USER NAME first");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Please fill the PASSWORD then login");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            HOME h = new HOME();
            h.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
