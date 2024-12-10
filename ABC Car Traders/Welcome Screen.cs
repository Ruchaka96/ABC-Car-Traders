using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 showform5 = new Form5();
            showform5.Show();
            this.Hide();
        }

        private void managecardetails_Click(object sender, EventArgs e)
        {
            Form7 showform7 = new Form7();
            showform7.Show();
            this.Hide();
        }
    }
}
