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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string customer_number = textbox1.Text;
                string first_name = textbox2.Text;
                string last_name = textbox3.Text;
                string email = textbox4.Text;
                string contact = textbox5.Text;
                string insert = "INSERT INTO manage_customers VALUES (@customer_number, @first_name, @last_name, @email, @contact)";
                conn.Open();
                SqlCommand ins = new SqlCommand(insert, conn);

                ins.Parameters.AddWithValue("@customer_number", customer_number);
                ins.Parameters.AddWithValue("@first_name", first_name);
                ins.Parameters.AddWithValue("@last_name", last_name);
                ins.Parameters.AddWithValue("@email", email);
                ins.Parameters.AddWithValue("@contact", contact);

                // mobile number validation part //
                Regex c = new Regex(@"^[0-9]{10}$");
                if (c.IsMatch(contact))
                {
                    // save data into the database //
                    ins.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successfully");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // button function for login page //
            Form2 showform2 = new Form2();
            showform2.Show();
            this.Hide();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            // code for clear all data in textboxes //
            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
            textbox4.Clear();
            textbox5.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // data entities with data variable types //
                string search_customer_number = textbox6.Text; // The value to search by
                string customer_number = textbox1.Text;
                string first_name = textbox2.Text;
                string last_name = textbox3.Text;
                string email = textbox4.Text;
                string contact = textbox5.Text;

                // data update query //
                string update = "UPDATE manage_customers SET customer_number=@customer_number, first_name=@first_name, last_name=@last_name, email=@email, contact=@contact WHERE customer_number=@search_customer_number";
                conn.Open();
                SqlCommand upt = new SqlCommand(update, conn);

                // data update parameters //
                upt.Parameters.AddWithValue("@customer_number", customer_number);
                upt.Parameters.AddWithValue("@first_name", first_name);
                upt.Parameters.AddWithValue("@last_name", last_name);
                upt.Parameters.AddWithValue("@email", email);
                upt.Parameters.AddWithValue("@contact", contact);
                upt.Parameters.AddWithValue("@search_customer_number", search_customer_number); // Use the search value here

                // mobile number validation part //
                Regex c = new Regex(@"^[0-9]{10}$");
                if (c.IsMatch(contact))
                {
                    // update data into the database //
                    upt.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Invalid contact number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error On Updating: " + ex.Message);
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
                // data entities with data variable types //
                string search_customer_number = textbox6.Text;
                // data delete query //
                string delete = "DELETE FROM manage_customers WHERE customer_number=@search_customer_number";
                conn.Open();
                SqlCommand del = new SqlCommand(delete, conn);
                // data delete parameterts //
                del.Parameters.AddWithValue("@search_customer_number", search_customer_number);
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
                // data search function //
                string search_customer_number = textbox6.Text;
                string search = "SELECT *FROM manage_customers WHERE customer_number='"+search_customer_number+"'";
                conn.Open();
                SqlCommand src = new SqlCommand(search, conn);
                SqlDataReader r = src.ExecuteReader();
                //textbox data loading array //
                if(r.HasRows)
                {
                    while(r.Read())
                    {
                        textbox1.Text = r[1].ToString();
                        textbox2.Text = r[2].ToString();
                        textbox3.Text = r[3].ToString();
                        textbox4.Text = r[4].ToString();
                        textbox5.Text = r[5].ToString();
                        textbox6.Text = r[6].ToString();
                    }
                }
                else
                {
                    MessageBox.Show ("Invalid Customer Number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show ("error on search" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textbox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_Click(object sender, EventArgs e)
        {

        }

        private void textbox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
