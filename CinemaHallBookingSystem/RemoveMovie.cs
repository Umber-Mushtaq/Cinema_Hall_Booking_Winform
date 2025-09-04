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
using System.Xml.Linq;

namespace CinemaHallBookingSystem
{
    public partial class RemoveMovie : Form
    {
        public RemoveMovie()
        {
            InitializeComponent();
            // Set the form's size to a fixed width and height  975, 489
            this.Width = 975;
            this.Height = 489;

            // Set the minimum and maximum size to the same fixed width and height
            this.MinimumSize = new Size(975, 489);
            this.MaximumSize = new Size(975, 489);

            // Disable the maximize and minimize buttons
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminManagement add = new AdminManagement();
            this.Close();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Updates update = new Updates();
            this.Close();
            update.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SeatsPricing pricing = new SeatsPricing();
            this.Close();
            pricing.Show();
        }

        private void RemoveMovie_Load(object sender, EventArgs e)
        {

        }

        private void removeMovieDoneButton_Click(object sender, EventArgs e)
        {
            if(removeShowingMovieNameText.Text == "")
            {
                MessageBox.Show("Provide The Movie Name Please");
            }
            else
            {
                string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False";
                string commandString = "DELETE FROM ShowingMovieDetail WHERE CAST(showingMovieNamedb AS varchar(max)) = @name";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand(commandString, con);
                com.Parameters.AddWithValue("@name", removeShowingMovieNameText.Text);
                con.Open();
                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // The update was successful
                    MessageBox.Show("Movie Removed Successfully.");
                }
                else
                {
                    // No matching record found
                    MessageBox.Show("No matching record found.");
                }
                con.Close();
            }
        }

        private void removeCommingDoneButton_Click(object sender, EventArgs e)
        {
            if (removeCommingMovieNameText.Text == "")
            {
                MessageBox.Show("Provide The Movie Name Please");
            }
            else
            {
                string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False";
                string commandString = "DELETE FROM CommingMovieDetail WHERE CAST(commingMovieNamedb AS varchar(max)) = @name";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand(commandString, con);
                com.Parameters.AddWithValue("@name", removeCommingMovieNameText.Text);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Movie Removed Successfully");
            }
        }
    }
}
