namespace CinemaHallBookingSystem
{
    partial class purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ticketLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 519);
            this.panel1.TabIndex = 0;
            // 
            // ticketLabel
            // 
            this.ticketLabel.BackColor = System.Drawing.Color.Transparent;
            this.ticketLabel.Font = new System.Drawing.Font("Edwardian Script ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.ForeColor = System.Drawing.Color.Black;
            this.ticketLabel.Location = new System.Drawing.Point(51, 238);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(279, 206);
            this.ticketLabel.TabIndex = 31;
            this.ticketLabel.Text = "...";
            this.ticketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 519);
            this.Controls.Add(this.panel1);
            this.Name = "purchase";
            this.Text = "purchase";
            this.Load += new System.EventHandler(this.purchase_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ticketLabel;
    }
}