using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp65
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append("College Name:" + comboBox1.Text + "\n");
            sb.Append("University Rollno:" + textBox1.Text+"\n");
            sb.Append("Name:" + textBox2.Text+"\n");
            sb.Append("Date of birth:" + maskedTextBox1.Text + "\n");
            label8.Text = sb.ToString();

        }
    }
}

            

           

            
