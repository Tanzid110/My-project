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
    public partial class BARIWALA : Form
    {
        public BARIWALA()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            ADD_ROOM ad = new ADD_ROOM();
            ad.ShowDialog();
            Close();
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
