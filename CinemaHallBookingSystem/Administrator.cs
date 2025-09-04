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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CinemaHallBookingSystem
{
    public partial class Administrator : Form
    {
        private string username;
        private string password;
        public Administrator()
        {
            InitializeComponent();
            // Set the form's size to a fixed width and height  462, 554
            this.Width = 462;
            this.Height = 554;

            // Set the minimum and maximum size to the same fixed width and height
            this.MinimumSize = new Size(462, 554);
            this.MaximumSize = new Size(462, 554);

            // Disable the maximize and minimize buttons
            this.MaximizeBox = false;

        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            getUsernamePasswordFromDatabase();
            verifyUsernamePassword();
        }
        private void Administrator_Load(object sender, EventArgs e)
        {
            
        }
        private void getUsernamePasswordFromDatabase()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=CinemaHall;Integrated Security=True;Pooling=False");
            string query = "SELECT Username, Password FROM LoginTable";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    username = reader.GetString(0);
                    password = reader.GetString(1);
                }
            }
            con.Close();
        }
        private void verifyUsernamePassword()
        {
            if(usernameTextbox.Text == username && passwordText.Text == password)
            {
                MessageBox.Show("Login Successfull");
                giveAccess();
            }
            else if(usernameTextbox.Text == username && passwordText.Text != password)
            {
                MessageBox.Show("Invalid Password");
                this.Refresh();
            }
            else if(usernameTextbox.Text != username && passwordText.Text == password) 
            { 
                MessageBox.Show("Invalid Username");
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
                this.Refresh();
            }
        }
        private void giveAccess()
        {
            AdminManagement manage = new AdminManagement();
            this.Close();
            manage.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

      

        
    }
}
