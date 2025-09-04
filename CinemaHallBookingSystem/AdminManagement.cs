using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaHallBookingSystem
{
    public partial class AdminManagement : Form
    {
        // showing movie cridentials
        private string showingmoviename = null;
        private string showingmoviedate = null;
        private byte[] showingimagedata = null ;
        // upcoming movie cridentials
        private string commingmoviename = null;
        private string commingmoviedate = null;
        private byte[] commingimagedata = null;
        public AdminManagement()
        {
            InitializeComponent();
            // Set the form's size to a fixed width and height  888, 511
            this.Width = 888;
            this.Height = 511;

            // Set the minimum and maximum size to the same fixed width and height
            this.MinimumSize = new Size(888, 511);
            this.MaximumSize = new Size(888, 511);

            // Disable the maximize and minimize buttons
            this.MaximizeBox = false;
        }
        private void selectedButtonDone_Click(object sender, EventArgs e)
        {
            getShowingMovieDetails();
            storeInShowingTable();
        }
        private void movieAddDoneButton_Click(object sender, EventArgs e)
        {
            getCommingMovieDetails();
            storeInCommingTable();
        }
        private void getShowingMovieDetails()
        {
            // get movie name
            showingmoviename = showingMovieNameText.Text;
            // get movie date
            showingmoviedate = showingDateTimePicker.Text;
        }
        private void getCommingMovieDetails()
        {
            // get movie name
            commingmoviename = commingMovieNameText.Text;
            // get movie date
            commingmoviedate = commingDateTimePicker.Text;
        }
        private void storeInShowingTable()
        {
            if (showingmoviename == null || showingmoviedate == null || showingimagedata == null)
            {
                MessageBox.Show("You Are Missing Some Data To Enter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
                {
                    con.Open();
                    string query = "INSERT INTO ShowingMovieDetail " +
                                    "(showingMovieNamedb, showingMovieDatedb, showingMovieImagedb) " +
                                    "VALUES" +
                                    " (@name, @date, @image)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // create parameter for name
                        SqlParameter parameter2 = new SqlParameter("@name", SqlDbType.Text);
                        parameter2.Value = showingmoviename;
                        cmd.Parameters.Add(parameter2);
                        // create parameter for date
                        SqlParameter parameter3 = new SqlParameter("@date", SqlDbType.Text);
                        parameter3.Value = showingmoviedate;
                        cmd.Parameters.Add(parameter3);
                        // Create parameter for imagedate
                        SqlParameter parameter1 = new SqlParameter("@image", SqlDbType.Image);
                        parameter1.Value = showingimagedata;
                        cmd.Parameters.Add(parameter1);
                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                MessageBox.Show("Data Inserted Successfully");
            }

        }
        private void storeInCommingTable()
        {
            if (commingmoviename == null || commingmoviedate == null || commingimagedata == null)
            {
                MessageBox.Show("You Are Missing Some Data To Enter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
                {

                    con.Open();
                    string query = "INSERT INTO CommingMovieDetail " +
                                    "(commingMovieNamedb, commingMovieDatedb, commingMovieImagedb) " +
                                    "VALUES" +
                                    " (@name, @date, @image)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // create parameter for name
                        SqlParameter parameter2 = new SqlParameter("@name", SqlDbType.Text);
                        parameter2.Value = commingmoviename;
                        cmd.Parameters.Add(parameter2);
                        // create parameter for date
                        SqlParameter parameter3 = new SqlParameter("@date", SqlDbType.Text);
                        parameter3.Value = commingmoviedate;
                        cmd.Parameters.Add(parameter3);
                        // Create parameter for imagedate
                        SqlParameter parameter1 = new SqlParameter("@image", SqlDbType.Image);
                        parameter1.Value = commingimagedata;
                        cmd.Parameters.Add(parameter1);
                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                MessageBox.Show("Data Inserted Successfully");
            }

        }
        private void showingSelectImageButton_Click(object sender, EventArgs e)
        {
           /* if (showingmoviename == null || showingmoviedate == null)
            {
                MessageBox.Show("You Are Missing Some Data To Enter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {*/
                // select movie image (open dialog and get image)
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                    openFileDialog.Title = "Select an image file";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Load the selected image into a byte array
                        using (var stream = new MemoryStream())
                        {
                            Image image = Image.FromFile(openFileDialog.FileName);
                            image.Save(stream, image.RawFormat);
                            showingimagedata = stream.ToArray();
                        }

                        // Set the selected image variable
                        //showingimage = Image.FromFile(openFileDialog.FileName);
                    }
                //}
            }
                
        }
        private void commingSelectImageButton_Click(object sender, EventArgs e)
        {
            /*if (commingmoviename == null || commingmoviedate == null)
            {
                MessageBox.Show("You Are Missing Some Data To Enter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {*/
                // get movie image (open dialog box and get image)
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                    openFileDialog.Title = "Select an image file";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Load the selected image into a byte array
                        using (var stream = new MemoryStream())
                        {
                            Image image = Image.FromFile(openFileDialog.FileName);
                            image.Save(stream, image.RawFormat);
                            commingimagedata = stream.ToArray();
                        }

                        // Set the selected image variable
                        //commingimage = Image.FromFile(openFileDialog.FileName);
                    }
                }
            //}
               
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
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
            SeatsPricing pricing = new SeatsPricing();
            this.Close();
            pricing.Show();
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
