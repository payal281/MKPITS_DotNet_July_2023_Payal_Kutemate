﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class album : Form
    {
        public album()
        {
            InitializeComponent();
        }
        Hashtable ht=new Hashtable();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ht.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection key = ht.Keys;
            foreach (string str in key) 
            { 
                sb.Append("album name: "  + str +"singer name:" + ht[str]+ "\n" );

            }
            label3.Text = sb.ToString();

        }
    }
}
