using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrationfromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrationform rs= new registrationform();
            rs.MdiParent = this;
            rs.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform a= new accountform();
            a.MdiParent = this;
            a.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin"&&textBox2.Text=="admin")
            {
                MessageBox.Show("login sucessful");
                panel1.Visible = false;
                menuStrip1.Enabled = true;
            }
            else
            {
                MessageBox.Show("invalid credentials,please try again");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
