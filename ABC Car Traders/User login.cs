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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            // user login function //
            string username = myusername.Text;
            string password = mypassword.Text;
            if (username == "ruchaka" && password == "123")
            // display function of admin menu after the login //
            {
                Form6 showform6 = new Form6();
                showform6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username & Password is Incorrect");
            }
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void mypassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void myusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form17 showform17 = new Form17();
            showform17.Show();
            this.Hide();
        }
    }
}
