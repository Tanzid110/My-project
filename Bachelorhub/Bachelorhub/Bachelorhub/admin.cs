using Add_Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bachelorhub
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            ADD_ROOM ad1 = new ADD_ROOM();
            ad1.ShowDialog();
            Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Find fh = new Find();
            fh.ShowDialog();
            Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Hide();
            BACHELOR_Info bi = new BACHELOR_Info();
            bi.ShowDialog();
            Close();
        }
    }
}
