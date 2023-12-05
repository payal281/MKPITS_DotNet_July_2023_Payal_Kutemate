using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bal = 100;
            

        private void button3_Click(object sender, EventArgs e)
        {
            int actno=Convert.ToInt32(textBox1.Text);
            int amt=Convert.ToInt32(textBox2.Text);
            if(radioButton1.Checked)
            {
                bal = bal + amt;
            }
            else if(radioButton2.Checked)
            {
                bal = bal - amt;
            }
             label1.Text = "bal is " + bal;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
