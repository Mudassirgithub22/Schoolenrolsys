using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace schoolenrollsys
{
    class dataconnection
    {

        public SqlConnection getConnection()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=laptop-10;Initial Catalog=schoolenroll;Integrated Security=True");

            return con;
        }

        public DataSet getdata(String Query)

        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = Query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        public bool setData(String Query)
        {
            SqlConnection con = getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = Query;
            int row;
            row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void getdatafromdatabse()
        {


            SqlConnection con = new SqlConnection("Data Source=Laptop-10;Initial Catalog=schoolenroll;Integrated Security=True");
            con.Open();
            try
            {
                String query = "select * from student_info";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

    }
}
    

