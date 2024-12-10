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
    public partial class Form10 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form10()
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

        private void btn_View_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM users";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            usersdata.DataSource = dt;
            conn.Close();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_user_id = searchbox.Text;
                string user_id = txtuserid.Text;
                string first_name = txtfirstname.Text;
                string last_name = txtlastname.Text;
                string email = txtemail.Text;
                string contact_number = txtcontact.Text;
                string username = txtusername.Text;
                string password = txtpassword.Text;
                string user_type = usertypebox.Text;

                string update = "UPDATE users SET user_id=@user_id,first_name=@first_name,last_name=@last_name,email=@email,contact_number=@contact_number,username=@username,password=@password,user_type=@user_type WHERE user_id=@search_user_id";
                conn.Open();
                SqlCommand upt = new SqlCommand(update, conn);
                upt.Parameters.AddWithValue("@user_id", user_id);
                upt.Parameters.AddWithValue("@first_name", first_name);
                upt.Parameters.AddWithValue("@last_name", last_name);
                upt.Parameters.AddWithValue("@email", email);
                upt.Parameters.AddWithValue("@contact_number", contact_number);
                upt.Parameters.AddWithValue("@username", username);
                upt.Parameters.AddWithValue("@password", password);
                upt.Parameters.AddWithValue("@user_type", user_type);
                upt.Parameters.AddWithValue("@search_user_id", user_id);

                // mobile number validation part //
                Regex c = new Regex(@"^[0-9]{10}$");
                if (c.IsMatch(contact_number))
                {
                    // update data into the database //
                    upt.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("invalid contact number");
                }
                // mobile number validation part //
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error On Updating" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_user_id = searchbox.Text;
                string delete = "DELETE FROM users WHERE user_id=@search_user_id";
                conn.Open();
                SqlCommand del = new SqlCommand(delete, conn);
                del.Parameters.AddWithValue("@search_user_id", search_user_id);
                del.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error On Deleting" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_user_id = searchbox.Text;
                string search = "SELECT *FROM users WHERE user_id='" + search_user_id + "'";
                conn.Open();
                SqlCommand src = new SqlCommand(search, conn);
                SqlDataReader r = src.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        txtuserid.Text = r[1].ToString();
                        txtfirstname.Text = r[2].ToString();
                        txtlastname.Text = r[3].ToString();
                        txtemail.Text = r[4].ToString();
                        txtcontact.Text = r[5].ToString();
                        txtusername.Text = r[6].ToString();
                        txtpassword.Text = r[7].ToString();
                        usertypebox.Text = r[8].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Customer Number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error on search" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void homebutton2_Click(object sender, EventArgs e)
        {
            // button function for login page //
            Form6 showform6 = new Form6();
            showform6.Show();
            this.Hide();
        }
    }
}
