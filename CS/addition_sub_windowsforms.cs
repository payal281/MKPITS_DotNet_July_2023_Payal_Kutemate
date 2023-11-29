using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     calculate c=new calculate();
             
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = c.addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            label3.Text = "addition: " + result;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = c.substraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            label3.Text = "substraction: " + result;

        }
    }
}
