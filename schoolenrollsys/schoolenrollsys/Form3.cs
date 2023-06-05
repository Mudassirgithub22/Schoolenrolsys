using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolenrollsys
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtname.Text;
            pass = txtpass.Text;
            if (user == "mudassir" && pass == "123")
            {
                
                Form1 f = new Form1();
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("not login");
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
