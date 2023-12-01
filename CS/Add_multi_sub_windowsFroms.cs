using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int P1=Convert.ToInt32(textBox1.Text);
            int P2=Convert.ToInt32(textBox2.Text);
            int res=P1+ P2;
            label3.Text = "addition:" + res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int P1 = Convert.ToInt32(textBox1.Text);
            int P2=Convert.ToInt32(textBox2.Text) ;
            int res=P1*P2;
            label3.Text = "multiply:" + res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                int P1 = Convert.ToInt32(textBox1.Text);
                int P2 = Convert.ToInt32(textBox2.Text);
                int res = P1 - P2;
                label3.Text = "substraction:" + res;

            }
        }
    }
}
