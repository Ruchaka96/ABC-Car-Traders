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
    public partial class Form9 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
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

        private void btn_View_Click(object sender, EventArgs e)
        {
            // code of loading the data to datagridview //
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

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string search_car_serial_number = searchbox.Text;
                string search = "SELECT *FROM manage_cars WHERE car_serial_number='" + search_car_serial_number + "'";
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

        private void registerbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // data entities with variable types//
                string car_serial_number = carserialnumberbox.Text;
                string car_name = carnamebox.Text;
                string car_model = carmodelbox.Text;
                int manufacture_year = int.Parse(manufactureyearbox.Text);
                string colour = carcolourbox.Text;
                decimal price = decimal.Parse(carpricebox.Text);
                string status = statusbox.Text;
                string quantity = txtquantity.Text;

                //data insert query//
                string insert = "INSERT INTO car_order VALUES (@car_serial_number, @car_name, @car_model, @manufacture_year, @colour, @price, @status, @quantity)";
                conn.Open();
                SqlCommand ins = new SqlCommand(insert, conn);
                //data insert parameters//
                ins.Parameters.AddWithValue("@car_serial_number", car_serial_number);
                ins.Parameters.AddWithValue("@car_name", car_name);
                ins.Parameters.AddWithValue("@car_model", car_model);
                ins.Parameters.AddWithValue("@manufacture_year", manufacture_year);
                ins.Parameters.AddWithValue("@colour", colour);
                ins.Parameters.AddWithValue("@price", price);
                ins.Parameters.AddWithValue("@status", status);
                ins.Parameters.AddWithValue("@quantity", quantity);

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

        private void homebutton2_Click(object sender, EventArgs e)
        {
            // button function for welcome page //
            Form6 showform6 = new Form6();
            showform6.Show();
            this.Hide();
        }
    }
}
