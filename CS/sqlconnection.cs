using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1- create a connection string 
            string str = "server=PAYAL\\SQLEXPRESS;integrated security=true;database=mksample";
            SqlConnection con = null;
            //2 - use sqlconnection class to connect to sqlserver database
            try
            {
                con = new SqlConnection(str);
                con.Open();//in connected env. you have to explicitly open the connection using open method
                MessageBox.Show("connected successfully");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
        }

    }
}

