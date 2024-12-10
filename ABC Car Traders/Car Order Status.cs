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
    public partial class Form14 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form14()
        {
            InitializeComponent();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_car_serial_number = searchbox.Text;
                string car_serial_number = carserialnumberbox.Text;
                string car_name = carnamebox.Text;
                string car_model = carmodelbox.Text;
                int manufacture_year = int.Parse(manufactureyearbox.Text);
                string colour = carcolourbox.Text;
                decimal price = decimal.Parse(carpricebox.Text);
                string status = statusbox.Text;
                string quantity = txtquantity.Text;

                string update = "UPDATE car_order SET car_serial_number=@car_serial_number,car_name=@car_name,car_model=@car_model,manufacture_year=@manufacture_year,colour=@colour,price=@price,status=@status,quantity=@quantity WHERE car_serial_number=@search_car_serial_number";
                conn.Open();
                SqlCommand upt = new SqlCommand(update, conn);
                upt.Parameters.AddWithValue("@car_serial_number", car_serial_number);
                upt.Parameters.AddWithValue("@car_name", car_name);
                upt.Parameters.AddWithValue("@car_model", car_model);
                upt.Parameters.AddWithValue("@manufacture_year", manufacture_year);
                upt.Parameters.AddWithValue("@colour", colour);
                upt.Parameters.AddWithValue("@price", price);
                upt.Parameters.AddWithValue("@status", status);
                upt.Parameters.AddWithValue("@quantity", quantity);
                upt.Parameters.AddWithValue("@search_car_serial_number", car_serial_number);

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
            carserialnumberbox.Clear();
            carnamebox.Clear();
            carmodelbox.Clear();
            manufactureyearbox.Clear();
            carcolourbox.Clear();
            carpricebox.Clear();
            txtquantity.Clear();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_car_serial_number = searchbox.Text;
                string search = "SELECT *FROM car_order WHERE car_serial_number='" + search_car_serial_number + "'";
                conn.Open();
                SqlCommand src = new SqlCommand(search, conn);
                SqlDataReader r = src.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        carserialnumberbox.Text = r[1].ToString();
                        carnamebox.Text = r[2].ToString();
                        carmodelbox.Text = r[3].ToString();
                        manufactureyearbox.Text = r[4].ToString();
                        carcolourbox.Text = r[5].ToString();
                        carpricebox.Text = r[6].ToString();
                        statusbox.Text = r[7].ToString();
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
            cmd.CommandText = "SELECT * FROM car_order";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            carordersdata.DataSource = dt;
            conn.Close();
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
