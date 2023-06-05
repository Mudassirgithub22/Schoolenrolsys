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
    public partial class Form2 : Form
    {
        dataconnection d = new dataconnection();
        string query;
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            query = "select * from student_info";
            DataSet ds = d.getdata(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
