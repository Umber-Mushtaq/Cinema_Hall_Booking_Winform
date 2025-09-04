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
    public partial class PageMain : Form
    {
        public PageMain()
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
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
        }

        private void btnBrowseMovies_Click(object sender, EventArgs e)
        {
            BrowseMovies b = new BrowseMovies();
            b.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Seats s = new Seats();
            s.Show();
        }
    }
}
