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
    public partial class Form15 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form15()
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
                string quantity = txtquantity.Text;
                string warranty = txtwarranty.Text;

                string insert = "INSERT INTO car_part_order VALUES (@part_id, @category, @size, @price, @brand, @colour, @warranty, @quantity)";
                conn.Open();
                SqlCommand ins = new SqlCommand(insert, conn);

                ins.Parameters.AddWithValue("@part_id", part_id);
                ins.Parameters.AddWithValue("@category", category);
                ins.Parameters.AddWithValue("@size", size);
                ins.Parameters.AddWithValue("@price", price);
                ins.Parameters.AddWithValue("@brand", brand);
                ins.Parameters.AddWithValue("@colour", colour);
                ins.Parameters.AddWithValue("@quantity", quantity);
                ins.Parameters.AddWithValue("@warranty", warranty);

                // save data into the database //
                ins.ExecuteNonQuery();
                MessageBox.Show("Order Saved Successfully");
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

        private void btn_View_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM car_parts";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            carpartsdata.DataSource = dt;
            conn.Close();
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
            txtwarranty.Clear();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_part_id = searchbox.Text;
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

        private void homebutton2_Click(object sender, EventArgs e)
        {
            // button function for user menus page //
            Form6 showform6 = new Form6();
            showform6.Show();
            this.Hide();
        }
    }
}
