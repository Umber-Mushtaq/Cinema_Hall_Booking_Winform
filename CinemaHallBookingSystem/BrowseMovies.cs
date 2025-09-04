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
    public partial class BrowseMovies : Form
    {
        // showing cridentials
        private List<System.Drawing.Image> showingSliderImages;
        List<string> showingMovieNames = new List<string>();
        List<string> showingMovieDates = new List<string>();
        private int showingSliderIndex = 0;
        // comming crientials
        private List<System.Drawing.Image> upcommingSliderImages;
        List<string> commingMovieNames = new List<string>();
        List<string> commingMovieDates = new List<string>();
        private int upcommingSliderIndex = 0;
        public BrowseMovies()
        {
            InitializeComponent();
            // Set the form's size to a fixed width and height  1051, 658
            this.Width = 1051;
            this.Height = 658;

            // Set the minimum and maximum size to the same fixed width and height
            this.MinimumSize = new Size(1051, 658);
            this.MaximumSize = new Size(1051, 658);

            // Disable the maximize and minimize buttons
            this.MaximizeBox = false;
           
            ShowingSliderModule();
            UpcommingSliderModule();
        }
        private void ShowingSliderModule()
        {
            showingSliderImages = new List<System.Drawing.Image>();
            showingSliderIndex = 0;
            loadShowingImagesFromDatabase();
            if (showingSliderImages.Count > 0)
            {
                currentImageInShowingSlider();
            }
            else
            {
                showingSlider.Image = System.Drawing.Image.FromFile("D:\\umber 6th semester\\visual programming\\Umber Mushtaq, Tooba Ali, Mubarrah Rashid (20, 47, 40)\\pics\\ih.jpg");
            }
        }
        private void UpcommingSliderModule()
        {
            upcommingSliderImages = new List<System.Drawing.Image>();
            upcommingSliderIndex = 0;
            loadUpcommingImagesFromDatabase();
            if (upcommingSliderImages.Count > 0)
            {
                currentImageInUpcommingSlider();
            }
            else
            {
                commingSlider.Image = System.Drawing.Image.FromFile("D:\\umber 6th semester\\visual programming\\Umber Mushtaq, Tooba Ali, Mubarrah Rashid (20, 47, 40)\\pics\\ih.jpg");

            }
        }
        private void loadShowingImagesFromDatabase()
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False");
            SqlCommand command = new SqlCommand("SELECT showingMovieImagedb, showingMovieNamedb, showingMovieDatedb FROM ShowingMovieDetail", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                byte[] imageData = (byte[])reader["showingMovieImagedb"];
                MemoryStream stream = new MemoryStream(imageData);
                System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                showingSliderImages.Add(image);
                showingMovieNames.Add(reader["showingMovieNamedb"].ToString());
                showingMovieDates.Add(reader["showingMovieDatedb"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void loadUpcommingImagesFromDatabase()
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False");
            SqlCommand command = new SqlCommand("SELECT commingMovieImagedb, commingMovieNamedb, commingMovieDatedb FROM commingMovieDetail", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                byte[] imageData = (byte[])reader["commingMovieImagedb"];
                MemoryStream stream = new MemoryStream(imageData);
                System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                upcommingSliderImages.Add(image);
                commingMovieNames.Add(reader["commingMovieNamedb"].ToString());
                commingMovieDates.Add(reader["commingMovieDatedb"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void currentImageInShowingSlider()
        {
                showingSlider.Image = showingSliderImages[showingSliderIndex];
                showingMovieName.Text = showingMovieNames[showingSliderIndex];
                showingMovieDate.Text = showingMovieDates[showingSliderIndex];
        }
        private void currentImageInUpcommingSlider()
        {
                commingSlider.Image = upcommingSliderImages[upcommingSliderIndex];
                commingMovieName.Text = commingMovieNames[upcommingSliderIndex];
                commingMovieDate.Text = commingMovieDates[upcommingSliderIndex];
            
        }
        private void showingNextButton_Click_1(object sender, EventArgs e)
        {
            if(showingSliderImages.Count != 0)
            {
                showingSliderIndex++;
                if (showingSliderIndex >= showingSliderImages.Count)
                {
                   // MessageBox.Show($"hi {showingSliderIndex}, {showingSliderImages.Count}");
                    showingSliderIndex = 0;
                }
                currentImageInShowingSlider();
            }
        }
        private void showingPreviousButton_Click_1(object sender, EventArgs e)
        {
            // Decrement the current index and wrap around if necessary
            if(showingSliderImages.Count != 0)
            {
                showingSliderIndex--;
                if (showingSliderIndex < 0)
                {
                    showingSliderIndex = showingSliderImages.Count - 1;
                }

                // Display the new current image
                currentImageInShowingSlider();
            }
        }
        private void showingSlider_Click_1(object sender, EventArgs e)
        {
            if (showingSliderImages.Count > 0)
            {
                Seats s = new Seats();
                s.Show();
            }
        }
        private void commingPreviousButton_Click(object sender, EventArgs e)
        {
            // Decrement the current index and wrap around if necessary
            if(upcommingSliderImages.Count != 0)
            {
                upcommingSliderIndex--;
                if (upcommingSliderIndex < 0)
                {
                    upcommingSliderIndex = upcommingSliderImages.Count - 1;
                }

                // Display the new current image
                currentImageInUpcommingSlider();
            }
            
        }
        private void commingNextButton_Click_1(object sender, EventArgs e)
        {
            if(upcommingSliderImages.Count != 0)
            {
                upcommingSliderIndex++;
                if (upcommingSliderIndex >= upcommingSliderImages.Count)
                {
                    upcommingSliderIndex = 0;
                }
                currentImageInUpcommingSlider();
            }
        }
        private void commingSlider_Click(object sender, EventArgs e)
        {
            /*if (upcommingSliderImages.Count > 0)
            {
                Seats s = new Seats();
                s.Show();
            }*/
        }




        /*private void showingSlider_Click(object sender, EventArgs e)
       {

           // get the current image from the PictureBox
           System.Drawing.Image currentImage = showingSlider.Image;

           // do whatever you need to do with the current image
           // for example, display the image in a new form
           Form imageForm = new Form();
           PictureBox pb = new PictureBox();
           pb.Dock = DockStyle.Fill;
           pb.SizeMode = PictureBoxSizeMode.StretchImage;
           pb.Image = currentImage;
           imageForm.Controls.Add(pb);
           imageForm.ShowDialog();
       }*/
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
        private void menu4_Click(object sender, EventArgs e)
        {
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
