using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaHallBookingSystem
{
    public partial class Updates : Form
    {
        public Updates()
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
            this.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SeatsPricing pricing = new SeatsPricing();
            this.Close();
            pricing.Show();
        }

        private void Updates_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void updateSilverSeatsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void updateGoldenSeatsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateDoneButton_Click(object sender, EventArgs e)
        {

        }

        private void updateComming_Click(object sender, EventArgs e)
        {
            update_comming u1 = new update_comming();
            u1.Show();
        }

        private void updateShowing_Click(object sender, EventArgs e)
        {
            update_Showing u2 = new update_Showing();
            u2.Show();
        }
    }
}
