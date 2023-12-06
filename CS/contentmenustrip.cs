using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp52
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

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            registerform r=new registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            accountform a=new accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
