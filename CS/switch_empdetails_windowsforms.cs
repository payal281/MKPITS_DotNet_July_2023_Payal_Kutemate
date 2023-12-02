using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name=textBox1.Text;
            int basicsalary=Convert.ToInt32(textBox2.Text);
           string designation=textBox3.Text;
            float hour = 0;
            float bonus = 0;
            float totalsalary = 0;
            switch (designation)
            {
                case "manager":
                    hour = basicsalary * 0.35f;
                    bonus = basicsalary * 0.5f;
                    break;
                case "clerk":
                    hour = basicsalary * 0.25f;
                    bonus = basicsalary * 0.3f;
                    break;
                case "peon ":
                    hour = basicsalary * 0.15f;
                    bonus = basicsalary * 0.2f;
                    break;

            }
            label4.Text = "hour " + hour;
            label5.Text = "bonus " + bonus;
            totalsalary = hour + bonus + basicsalary;
            label6.Text = "total sal " + totalsalary;

        }

    }
    
}
