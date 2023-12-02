using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = 7;
            day=Convert.ToInt32(textBox1.Text);
            switch(day)
            {
                case 1:
                    label2.Text=("Monday");
                    break;
                case 2:
                    label2.Text = ("Tuesday");
                    break;
                case 3:
                    label2.Text = ("Wednesday");
                    break;
                case 4:
                   label2.Text = ("Thursday");
                    break;
                case 5:
                    label2.Text = ("Friday");
                    break;
                case 6:
                    label2.Text = ("Saturday");
                    break;
                case 7:
                    label2.Text = ("Sunday");
                    break;
                default:
                    label2.Text = ("incorrect");
                       break;
            }
        }
    }
}
