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
    public partial class Seats : Form
    {
        List<string> selectedSeats = new List<string>();
        int disableSeatsCounter = 0;
        public Seats()
        {
            InitializeComponent();
            // Set the form's size to a fixed width and height  957, 552
            this.Width = 957;
            this.Height = 650;

            // Set the minimum and maximum size to the same fixed width and height
            this.MinimumSize = new Size(957, 650);
            this.MaximumSize = new Size(957, 650);

            // Disable the maximize and minimize buttons
            this.MaximizeBox = false;
            currentSeatsStatus();
            populateComboBox();
        }
        private void populateComboBox()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                string query = "SELECT showingMovieNamedb FROM ShowingMovieDetail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string moviename = reader.GetString(0); // Assuming showingMovieNamedb is of type string

                        // Add the movie name to the ComboBox
                        movieName.Items.Add(moviename);
                    }

                    reader.Close();
                }

                connection.Close();
            }

        }
        private void currentSeatsStatus()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                string query = "SELECT id, status FROM SeatsStatus";
                
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    int status = Convert.ToInt32(reader["status"]);

                    // Find the corresponding label by id
                    Label label = Controls.Find("label" + id, true).FirstOrDefault() as Label;

                    if (label != null && status == 0)
                    {
                        label.Enabled = false;
                        label.BackColor = Color.LightGray;
                        disableSeatsCounter++;
                    }
                }
                reader.Close();

                string query2 = "SELECT selected, unselected FROM seatsDetail";
                SqlCommand com = new SqlCommand(query2, connection);
                SqlDataReader reader1 = com.ExecuteReader();
                while (reader1.Read())
                {
                    // Retrieve and print the selected and unselected values
                    string selected = reader1["selected"].ToString();
                    string unselected = reader1["unselected"].ToString();
                    selectedSeatsBtn.Text = selected;
                    btnUnselectedSeats.Text = unselected;
                }
                reader1.Close();

                connection.Close();
            }
        }
        // seat click function
        private void Seat_Click(object sender, EventArgs e)
        {
            if (movieName.Text == "")
            {
                MessageBox.Show("Select Movie Name First");
            }
            else
            {
                Label label = (Label)sender;
                if (label.Enabled == false)
                {
                    MessageBox.Show("The seat is already selected please select another one");
                }
                else
                {
                    if (label.ForeColor == Color.White)
                    {
                        label.ForeColor = Color.LightPink;
                        selectedSeats.Add(label.Name);

                    }
                    else if (label.ForeColor == Color.LightPink)
                    {
                        label.ForeColor = Color.White;
                        selectedSeats.Remove(label.Name);
                    }
                }
            }
        }
        // select button function
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(movieName.Text == "")
            {
                MessageBox.Show("Select Movie Name First");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to select these seats. once selected cannot be modified?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (string labelName in selectedSeats)
                    {
                        // find the corresponding label 
                        Control control = Controls.Find(labelName, true).FirstOrDefault();

                        if (control is Label label && label.ForeColor == Color.LightPink)
                        {
                            label.Enabled = false;
                            //label.ForeColor = Color.LightGray;
                            // Get the label's corresponding id
                            int id = Convert.ToInt32(label.Name.Substring(5));
                            // Update the status of the seat in the database
                            using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
                            {
                                connection.Open();

                                string query = "UPDATE SeatsStatus SET status = 0 WHERE id = @id";
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@id", id);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Reselect the seats");
                }
            }
            
        }
        // view button function
        private void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{selectedSeats.Count} : Seats Selected\n{selectedSeats.Count * 50} : is the total price.", "Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                string query = "UPDATE seatsDetail SET selected = @sel, unselected = @unsel WHERE id = 1";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sel", disableSeatsCounter);
                    command.Parameters.AddWithValue("@unsel", (35-disableSeatsCounter));
                    command.ExecuteNonQuery();
                }
            }
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (movieName.Text == "")
            {
                MessageBox.Show("Select Movie Name First");
            }
            else
            {
                string name = movieName.Text;
                if (name == null)
                {
                    MessageBox.Show("Choose a movie first");
                }
                purchase p = new purchase(name, selectedSeats);
                p.Show();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Seats_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
