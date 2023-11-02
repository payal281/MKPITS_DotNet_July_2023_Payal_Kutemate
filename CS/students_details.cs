using student_details;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strudent_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("student Details are :" + "\n");
            for(int i=0;i<9;i++)
            {
                sb.Append("--------------------------[-\n");
                sb.Append("rollno:"+ stud[i].rollno + "\n");
                sb.Append("name:" + stud[i].name + "\n");
                sb.Append("fees:" + stud[i].fees + "\n");
                sb.Append("date:" + stud[i].date + "\n");
                sb.Append("---------------------------\n");
                richTextBox1.Text = sb.ToString();
                //code to find highest fees paid
                int high = stud[0].fees;
                int foundat = 0;
                for(int count=0;count<9;count++)
                {
                    if (high < stud[count].fees)
                    {
                        high = stud[count].fees;
                        foundat= count;
                    }

                }
                StringBuilder sb1 = new StringBuilder();
                sb1.Append("student with highest fees:\n");
                sb1.Append(" rollno:" + stud[foundat].rollno+"\n");
                sb1.Append(" name:" + stud[foundat].name + "\n");
                sb1.Append(" fees:" + stud[foundat].fees + "\n");
                sb1.Append(" date:" + stud[foundat].date + "\n");
                label5.Text = sb1.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<9)
            {
                stud[cnt].rollno=Convert.ToInt32(textBox1.Text);
                stud[cnt].name = textBox2.Text;
                stud[cnt].fees = Convert.ToInt32(textBox3.Text);
                stud[cnt].date = textBox4.Text;
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                if(cnt==9)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("details of 10 student accepted");

                }
            }
        }
        Student[]stud=new Student[10];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0]=new Student();
            stud[1] = new Student();
            stud[2] = new Student();
            stud[3] = new Student();
            stud[4] = new Student();
            stud[5] = new Student();
            stud[6] = new Student();
            stud[7] = new Student();
            stud[8] = new Student();
            stud[9] = new Student();


        }
    }
}
