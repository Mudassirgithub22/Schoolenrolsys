using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace schoolenrollsys
{
    public partial class Form1 : Form
    {

        dataconnection D = new dataconnection();
        string query;
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtname.Text == ""|| txtclass.Text ==""||txtdistrict.Text== "")
            {
                MessageBox.Show(" پحلے فارم کو پر کریں");
            }
            else
            {
                string gende = null; 
                if (txtgender.Checked)
                {
                    gende = "male";

                }
                if (radioButton2.Checked)
                {
                    gende = "female";
                }

                query = "insert into  student_info values(N'" + txtname.Text + "" + txtclass.Text + "" + txtfathername.Text + "" + gende + "','" + txtfcnic.Text + "', '" + txtyear.Text + "," + txtschoolname.Text + "','" + txtdob.Text + "', '" + txtfphone.Text + "," + txtaddress.Text + "," + txtdistrict.Text + "," + path + "')";
                bool re = D.setData(query);
                {
                    if (re == true)
                    {
                        MessageBox.Show("data inseted");
                    }
                    else
                    {
                        MessageBox.Show("not inserted");
                    }
                    clear();
                }

            }
        }

        public void clear()
        {
            txtname.Text = "";
            txtclass.Text = "";
            txtfathername.Text = "";
            txtfcnic.Text = "";
            txtgender.Text = "";
            txtfphone.Text = "";
            txtschoolname.Text = "";
            txtyear.Text = "";
            txtdob.Text = "";
            txtdistrict.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "choose Image(*. jpg; *.png*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
                path = opf.FileName;

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();

            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataconnection ds = new dataconnection();
            String query;
            query = "delete from student_info where fcnic='" + txtfcnic.Text + "'";
           bool result= ds.setData(query);
            
            if (result == true)
            {
                MessageBox.Show("deleted");
            }
            else
            {
                MessageBox.Show(" not deleted");
            }

        }

        
    }
}
