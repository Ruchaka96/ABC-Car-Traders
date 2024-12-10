using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ABC_Car_Traders
{
    public partial class Form17 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form17()
        {
            InitializeComponent();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string user_id = txtuserid.Text;
                string first_name = txtfirstname.Text;
                string last_name = txtlastname.Text;
                string email = txtemail.Text;
                string contact = txtcontact.Text;
                string username = txtusername.Text;
                string password = txtpassword.Text;
                string user_type = usertypebox.Text;
                string insert = "INSERT INTO users VALUES (@user_id, @first_name, @last_name, @email, @contact,@username,@password,@user_type)";
                conn.Open();
                SqlCommand ins = new SqlCommand(insert, conn);

                ins.Parameters.AddWithValue("@user_id", user_id);
                ins.Parameters.AddWithValue("@first_name", first_name);
                ins.Parameters.AddWithValue("@last_name", last_name);
                ins.Parameters.AddWithValue("@email", email);
                ins.Parameters.AddWithValue("@contact", contact);
                ins.Parameters.AddWithValue("@username", username);
                ins.Parameters.AddWithValue("@password", password);
                ins.Parameters.AddWithValue("@user_type", user_type);

                // mobile number validation part //
                Regex c = new Regex(@"^[0-9]{10}$");
                if (c.IsMatch(contact))
                {
                    // save data into the database //
                    ins.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully");
                }
                else
                {
                    MessageBox.Show("invalid contact number");
                }
                // mobile number validation part //
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            // code for clear all data in boxes //
            txtuserid.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txtcontact.Clear();
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void homebutton2_Click(object sender, EventArgs e)
        {
            // button function for welcome page //
            Form6 showform6 = new Form6();
            showform6.Show();
            this.Hide();
        }
    }
}
