using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaHallBookingSystem
{
    public partial class SeatsPricing : Form
    {
        public SeatsPricing()
        {
            InitializeComponent();
            // Set the form's size to a fixed width and height  887, 489
            this.Width = 887;
            this.Height = 489;

            // Set the minimum and maximum size to the same fixed width and height
            this.MinimumSize = new Size(887, 489);
            this.MaximumSize = new Size(887, 489);

            // Disable the maximize and minimize buttons
            this.MaximizeBox = false;
            showStatus();
        }
        private void showStatus()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                string query2 = "SELECT selected, unselected FROM seatsDetail";
                SqlCommand com = new SqlCommand(query2, connection);
                SqlDataReader reader1 = com.ExecuteReader();
                while (reader1.Read())
                {
                    // Retrieve and print the selected and unselected values
                    string selected = reader1["selected"].ToString();
                    string unselected = reader1["unselected"].ToString();
                    booked.Text = selected;
                    unbooked.Text = unselected;
                }
                reader1.Close();

                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdminManagement add = new AdminManagement();
            this.Close();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveMovie remove = new RemoveMovie();
            this.Close();
            remove.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Updates update = new Updates();
            this.Close();
            update.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void SeatsPricing_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Seats s = new Seats();
            s.Show();
        }
    }
}
