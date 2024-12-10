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
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void signuplabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void colourbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string car_serial_number = carserialnumberbox.Text;
                string car_name = carnamebox.Text;
                string car_model = carmodelbox.Text;
                int manufacture_year = int.Parse(manufactureyearbox.Text);
                string colour = carcolourbox.Text;
                decimal price = decimal.Parse(carpricebox.Text);
                string status = statusbox.Text;

                string insert = "INSERT INTO manage_cars VALUES (@car_serial_number, @car_name, @car_model, @manufacture_year, @colour, @price, @status)";
                conn.Open();
                SqlCommand ins = new SqlCommand(insert, conn);

                ins.Parameters.AddWithValue("@car_serial_number", car_serial_number);
                ins.Parameters.AddWithValue("@car_name", car_name);
                ins.Parameters.AddWithValue("@car_model", car_model);
                ins.Parameters.AddWithValue("@manufacture_year", manufacture_year);
                ins.Parameters.AddWithValue("@colour", colour);
                ins.Parameters.AddWithValue("@price", price);
                ins.Parameters.AddWithValue("@status", status);

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

        private void label7_Click(object sender, EventArgs e)
        {

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

                string update = "UPDATE manage_cars SET car_serial_number=@car_serial_number,car_name=@car_name,car_model=@car_model,manufacture_year=@manufacture_year,colour=@colour,price=@price,status=@status WHERE car_serial_number=@search_car_serial_number";
                conn.Open();
                SqlCommand upt = new SqlCommand(update, conn);
                upt.Parameters.AddWithValue("@car_serial_number", car_serial_number);
                upt.Parameters.AddWithValue("@car_name", car_name);
                upt.Parameters.AddWithValue("@car_model", car_model);
                upt.Parameters.AddWithValue("@manufacture_year", manufacture_year);
                upt.Parameters.AddWithValue("@colour", colour);
                upt.Parameters.AddWithValue("@price", price);
                upt.Parameters.AddWithValue("@status", status);
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

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_car_serial_number = searchbox.Text;
                string delete = "DELETE FROM manage_cars WHERE car_serial_number=@search_car_serial_number";
                conn.Open();
                SqlCommand del = new SqlCommand(delete, conn);
                del.Parameters.AddWithValue("@search_car_serial_number", search_car_serial_number);
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
                string search_car_serial_number = searchbox.Text;
                string search = "SELECT *FROM manage_cars WHERE car_serial_number='" +search_car_serial_number+ "'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM manage_cars";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cardata.DataSource = dt;
            conn.Close();
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
