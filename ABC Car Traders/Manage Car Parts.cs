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

namespace ABC_Car_Traders
{
    public partial class Form8 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string part_id = txtpartid.Text;
                string category = txtcategory.Text;
                string size = txtsize.Text;
                decimal price = decimal.Parse(txtprice.Text);
                string brand = txtbrand.Text;
                string colour = txtcolour.Text;
                string warranty = txtwarranty.Text;

                string insert = "INSERT INTO car_parts VALUES (@part_id, @category, @size, @price, @brand, @colour, @warranty)";
                conn.Open();
                SqlCommand ins = new SqlCommand(insert, conn);

                ins.Parameters.AddWithValue("@part_id", part_id);
                ins.Parameters.AddWithValue("@category", category);
                ins.Parameters.AddWithValue("@size", size);
                ins.Parameters.AddWithValue("@price", price);
                ins.Parameters.AddWithValue("@brand", brand);
                ins.Parameters.AddWithValue("@colour", colour);
                ins.Parameters.AddWithValue("@warranty", warranty);

                // save data into the database //
                ins.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");
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
            // code for clear all data in textboxes //
            txtpartid.Clear();
            txtcategory.Clear();
            txtsize.Clear();
            txtprice.Clear();
            txtbrand.Clear();
            txtcolour.Clear();
            txtwarranty.Clear();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_part_id = searchbox.Text;
                string part_id = txtpartid.Text;
                string category = txtcategory.Text;
                string size = txtsize.Text;
                decimal price = decimal.Parse(txtprice.Text);
                string brand = txtbrand.Text;
                string colour = txtcolour.Text;
                string warranty = txtwarranty.Text;
                

                string update = "UPDATE car_parts SET part_id=@part_id,category=@category,size=@size,price=@price,brand=@brand,colour=@colour,warranty=@warranty WHERE part_id=@search_part_id";
                conn.Open();
                SqlCommand upt = new SqlCommand(update, conn);
                upt.Parameters.AddWithValue("@part_id", part_id);
                upt.Parameters.AddWithValue("@category", category);
                upt.Parameters.AddWithValue("@size", size);
                upt.Parameters.AddWithValue("@price", price);
                upt.Parameters.AddWithValue("@brand", brand);
                upt.Parameters.AddWithValue("@colour", colour);
                upt.Parameters.AddWithValue("@warranty", warranty);
                upt.Parameters.AddWithValue("@search_part_id", part_id);

                // update data into the database //
                upt.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
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

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_part_id= searchbox.Text;
                string search = "SELECT *FROM car_parts WHERE part_id='" + search_part_id + "'";
                conn.Open();
                SqlCommand src = new SqlCommand(search, conn);
                SqlDataReader r = src.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        txtpartid.Text = r[1].ToString();
                        txtcategory.Text = r[2].ToString();
                        txtsize.Text = r[3].ToString();
                        txtprice.Text = r[4].ToString();
                        txtbrand.Text = r[5].ToString();
                        txtcolour.Text = r[6].ToString();
                        txtwarranty.Text = r[7].ToString();
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

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_part_id = searchbox.Text;
                string delete = "DELETE FROM car_parts WHERE part_id=@search_part_id";
                conn.Open();
                SqlCommand del = new SqlCommand(delete, conn);
                del.Parameters.AddWithValue("@search_part_id", search_part_id);
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

        private void txtpartid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtsize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtbrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcolour_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtwarranty_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerusername_Click(object sender, EventArgs e)
        {

        }

        private void homebutton2_Click(object sender, EventArgs e)
        {
            // button function for login page //
            Form2 showform2 = new Form2();
            showform2.Show();
            this.Hide();
        }
    }
}
