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
    public partial class purchase : Form
    {
        private string movieName;
        private List<string> selectedSeats = new List<string>();
        public purchase(string movieName, List<string> selectedseats)
        {
            InitializeComponent();
            this.movieName = movieName;
            this.selectedSeats = selectedseats;
            string ticket = "";
            foreach(string seat in selectedSeats)
            {
                ticket += seat + " ";
            }
            ticketLabel.Text = $"Movie Name: {movieName}\nSeats Selected: {selectedSeats.Count}\n{ticket}\nTotal Price Is: {selectedSeats.Count*50}";
        }

        private void purchase_Load(object sender, EventArgs e)
        {
           
        }
    }
}
