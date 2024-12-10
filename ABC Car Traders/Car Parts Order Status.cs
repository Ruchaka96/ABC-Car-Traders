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
    public partial class Form13 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form13()
        {
            InitializeComponent();
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

                string update = "UPDATE car_part_order SET part_id=@part_id,category=@category,size=@size,price=@price,brand=@brand,colour=@colour,warranty=@warranty WHERE part_id=@search_part_id";
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

        private void clearbutton_Click(object sender, EventArgs e)
        {
            // code for clear all data in textboxes //
            txtpartid.Clear();
            txtcategory.Clear();
            txtsize.Clear();
            txtprice.Clear();
            txtbrand.Clear();
            txtcolour.Clear();
            txtquantity.Clear();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_part_id = searchbox.Text;
                string search = "SELECT *FROM car_part_order WHERE part_id='" + search_part_id + "'";
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
                        txtquantity.Text = r[8].ToString();
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

        private void btn_View_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM car_part_order";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            carpartsordersdata.DataSource = dt;
            conn.Close();
        }

        private void homebutton2_Click(object sender, EventArgs e)
        {
            // button function for user menus page //
            Form2 showform2 = new Form2();
            showform2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 showform2 = new Form2();
            showform2.Show();
            this.Hide();
        }
    }
    }
}
