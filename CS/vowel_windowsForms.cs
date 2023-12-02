using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
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

            char ch;
            ch = Convert.ToChar(textBox1.Text);

            switch(char.ToLower(ch))
            {
                case 'a':
                    label2.Text = "vowel";
                    break;
                case 'e':
                    label2.Text = "vowel";
                    break;
                case 'i':
                    label2.Text = "vowel";
                    break;
                case 'o':
                    label2.Text = "vowel";
                    break;
                case 'u':
                    label2.Text = "vowel";
                    break;
                    
                      default:
                    label2.Text = " not a vowel";
                       break;
          
            }        
                    
        }
    }
}
