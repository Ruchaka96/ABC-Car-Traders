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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            // admin login function //
            string username = adminusername.Text;
            string password = adminpassword.Text;
            if (username == "admin" && password == "admin@123")
            // display function of admin menu after the login //
            {
                Form2 showform2 = new Form2();
                showform2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username & Password is Incorrect");
            }
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
    }
}
