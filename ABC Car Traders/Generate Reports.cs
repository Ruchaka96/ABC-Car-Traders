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
    public partial class Form16 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ABC Car Traders\ABC Car Traders\Database1.mdf;Integrated Security=True");
        public Form16()
        {
            InitializeComponent();
        }

        private void viewbutton_Click(object sender, EventArgs e)
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
            dataview.DataSource = dt;
            conn.Close();
        }

        private void printbutton_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void printDocument1_BeginPrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
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
