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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 showform1 = new Form1();
            showform1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // welcome screen function //
            Form8 showform8 = new Form8();
            showform8.Show();
            this.Hide();
        }

        private void managecardetails_Click(object sender, EventArgs e)
        {
            // manage car details page screen function //
            Form4 showform4 = new Form4();
            showform4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // admin menu form function //
            Form3 showform3 = new Form3();
            showform3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 showform11 = new Form11();
            showform11.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form16 showform16 = new Form16();
            showform16.Show();
            this.Hide();
        }

        private void carorderstatusbutton_Click(object sender, EventArgs e)
        {
            // car order status screen function //
            Form14 showform14 = new Form14();
            showform14.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 showform13 = new Form13();
            showform13.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // car order status screen function //
            Form14 showform14 = new Form14();
            showform14.Show();
            this.Hide();
        }
    }
}
