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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void managecardetails_Click(object sender, EventArgs e)
        {
            Form10 showform10 = new Form10();
            showform10.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // order car screen function //
            Form9 showform9 = new Form9();
            showform9.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // car order status screen function //
            Form14 showform14 = new Form14();
            showform14.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //car parts order screen function//
            Form15 showform15 = new Form15();
            showform15.Show();
            this.Hide();
        }

        private void exitbutton2_Click(object sender, EventArgs e)
        {
            // Display a message box with "Yes" and "No" buttons
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // If "Yes" is clicked, close the application //
                Application.Exit();
            }
            // If "No" is clicked, do nothing and return to the application
        }

        private void homebutton1_Click(object sender, EventArgs e)
        {
            // welcome screen function //
            Form8 showform8 = new Form8();
            showform8.Show();
            this.Hide();
        }

        private void carpartsorderstatusbutton_Click(object sender, EventArgs e)
        {
            // car parts order status screen function //
            Form13 showform13 = new Form13();
            showform13.Show();
            this.Hide();
        }

        private void carpartsorderstatusbutton_Click_1(object sender, EventArgs e)
        {
            // car parts order status screen function //
            Form13 showform13 = new Form13();
            showform13.Show();
            this.Hide();
        }
    }
}
