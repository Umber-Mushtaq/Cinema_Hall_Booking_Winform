using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaHallBookingSystem
{
    public partial class update_comming : Form
    {
        private string previousname = null;
        private string commingmoviename = null;
        private string commingmoviedate = null;
        private byte[] commingimagedata = null;
        public update_comming()
        {
            InitializeComponent();
            //SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False");
            // Set the form's size to a fixed width and height  608, 471
            this.Width = 608;
            this.Height = 471;

            // Set the minimum and maximum size to the same fixed width and height
            this.MinimumSize = new Size(608, 471);
            this.MaximumSize = new Size(608, 471);

            // Disable the maximize and minimize buttons
            this.MaximizeBox = false;
        }
        // update name function
        private void updateNameBtn_Click(object sender, EventArgs e)
        {
            if (PreMovieName.Text == "")
            {
                MessageBox.Show("Please give the previous name of the movie", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                previousname = PreMovieName.Text;
                if (newMovieName.Text == "")
                {
                    MessageBox.Show("Please give the updated movie name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    commingmoviename = newMovieName.Text;
                    using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
                    {
                        con.Open();
                        string query = "UPDATE CommingMovieDetail SET commingMovieNamedb = @newName WHERE commingMovieNamedb LIKE @previousName";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Create parameter for the new name
                            SqlParameter newNameParameter = new SqlParameter("@newName", SqlDbType.Text);
                            newNameParameter.Value = commingmoviename;
                            cmd.Parameters.Add(newNameParameter);

                            // Create parameter for the previous name
                            SqlParameter previousNameParameter = new SqlParameter("@previousName", SqlDbType.Text);
                            previousNameParameter.Value = previousname;
                            cmd.Parameters.Add(previousNameParameter);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // The update was successful
                                MessageBox.Show("Record updated successfully.");
                            }
                            else
                            {
                                // No matching record found
                                MessageBox.Show("No matching record found.");
                            }
                        }
                        con.Close();
                    }

                }
            }
        }
        // update date function
        private void doneButton_Click(object sender, EventArgs e)
        {
            if (PreMovieName.Text == "")
            {
                MessageBox.Show("Please give the previous name of the movie", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                previousname = PreMovieName.Text;
                if (newMovieDatePicker.Text == "")
                {
                    MessageBox.Show("Please give the updated movie Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    commingmoviedate = newMovieDatePicker.Text;
                    using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
                    {
                        con.Open();
                        string query = "UPDATE CommingMovieDetail SET commingMovieDatedb = @newDame WHERE commingMovieNamedb LIKE @previousName";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Create parameter for the new name
                            SqlParameter newDateParameter = new SqlParameter("@newDame", SqlDbType.Text);
                            newDateParameter.Value = commingmoviedate;
                            cmd.Parameters.Add(newDateParameter);

                            // Create parameter for the previous name
                            SqlParameter previousNameParameter = new SqlParameter("@previousName", SqlDbType.Text);
                            previousNameParameter.Value = previousname;
                            cmd.Parameters.Add(previousNameParameter);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // The update was successful
                                MessageBox.Show("Record updated successfully.");
                            }
                            else
                            {
                                // No matching record found
                                MessageBox.Show("No matching record found.");
                            }
                        }
                        con.Close();
                    }

                }
            }
            /*getData();
            updateData();
            MessageBox.Show("The data updated successfully", "Comfirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
        }
        // update image function
        private void updateImageButton_Click(object sender, EventArgs e)
        {
            selectImage();
           
                previousname = PreMovieName.Text;
                if (commingimagedata == null)
                {
                    MessageBox.Show("You have not selected the image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False"))
                    {
                        con.Open();
                        string query = "UPDATE CommingMovieDetail SET commingMovieImagedb = @newImage WHERE commingMovieNamedb LIKE @previousName";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Create parameter for the new name
                            SqlParameter newImageParameter = new SqlParameter("@newImage", SqlDbType.VarBinary);
                            newImageParameter.Value = commingimagedata;
                            cmd.Parameters.Add(newImageParameter);

                            // Create parameter for the previous name
                            SqlParameter previousNameParameter = new SqlParameter("@previousName", SqlDbType.Text);
                            previousNameParameter.Value = previousname;
                            cmd.Parameters.Add(previousNameParameter);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // The update was successful
                                MessageBox.Show("Record updated successfully.");
                            }
                            else
                            {
                                // No matching record found
                                MessageBox.Show("No matching record found.");
                            }
                        }
                        con.Close();
                    }
            }

        }
        private void selectImage()
        {
            if (PreMovieName.Text == "")
            {
                MessageBox.Show("Please give the previous name of the movie", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
                    }
                }
            }
            
        }

        //=====================================================================================

        private void update_comming_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
