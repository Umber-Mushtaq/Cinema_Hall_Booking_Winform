namespace CinemaHallBookingSystem
{
    partial class BrowseMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseMovies));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commingMovieDate = new System.Windows.Forms.Label();
            this.commingMovieName = new System.Windows.Forms.Label();
            this.showingMovieName = new System.Windows.Forms.Label();
            this.showingMovieDate = new System.Windows.Forms.Label();
            this.movieName = new System.Windows.Forms.Label();
            this.commingPreviousButton = new System.Windows.Forms.Label();
            this.commingNextButton = new System.Windows.Forms.Label();
            this.commingSlider = new System.Windows.Forms.PictureBox();
            this.showingPreviousButton = new System.Windows.Forms.Label();
            this.showingNextButton = new System.Windows.Forms.Label();
            this.showingSlider = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commingSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showingSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(10, 80);
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.commingMovieDate);
            this.panel1.Controls.Add(this.commingMovieName);
            this.panel1.Controls.Add(this.showingMovieName);
            this.panel1.Controls.Add(this.showingMovieDate);
            this.panel1.Controls.Add(this.movieName);
            this.panel1.Controls.Add(this.commingPreviousButton);
            this.panel1.Controls.Add(this.commingNextButton);
            this.panel1.Controls.Add(this.commingSlider);
            this.panel1.Controls.Add(this.showingPreviousButton);
            this.panel1.Controls.Add(this.showingNextButton);
            this.panel1.Controls.Add(this.showingSlider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1035, 619);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 113);
            this.label2.TabIndex = 46;
            this.label2.Text = "Upcomming";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 113);
            this.label1.TabIndex = 45;
            this.label1.Text = "NowShowing ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commingMovieDate
            // 
            this.commingMovieDate.AutoSize = true;
            this.commingMovieDate.BackColor = System.Drawing.Color.Transparent;
            this.commingMovieDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commingMovieDate.ForeColor = System.Drawing.Color.White;
            this.commingMovieDate.Location = new System.Drawing.Point(592, 1114);
            this.commingMovieDate.Name = "commingMovieDate";
            this.commingMovieDate.Size = new System.Drawing.Size(49, 24);
            this.commingMovieDate.TabIndex = 44;
            this.commingMovieDate.Text = "date";
            // 
            // commingMovieName
            // 
            this.commingMovieName.AutoSize = true;
            this.commingMovieName.BackColor = System.Drawing.Color.Transparent;
            this.commingMovieName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commingMovieName.ForeColor = System.Drawing.Color.White;
            this.commingMovieName.Location = new System.Drawing.Point(320, 1114);
            this.commingMovieName.Name = "commingMovieName";
            this.commingMovieName.Size = new System.Drawing.Size(59, 24);
            this.commingMovieName.TabIndex = 43;
            this.commingMovieName.Text = "name";
            // 
            // showingMovieName
            // 
            this.showingMovieName.AutoSize = true;
            this.showingMovieName.BackColor = System.Drawing.Color.Transparent;
            this.showingMovieName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showingMovieName.ForeColor = System.Drawing.Color.White;
            this.showingMovieName.Location = new System.Drawing.Point(337, 560);
            this.showingMovieName.Name = "showingMovieName";
            this.showingMovieName.Size = new System.Drawing.Size(59, 24);
            this.showingMovieName.TabIndex = 42;
            this.showingMovieName.Text = "name";
            // 
            // showingMovieDate
            // 
            this.showingMovieDate.AutoSize = true;
            this.showingMovieDate.BackColor = System.Drawing.Color.Transparent;
            this.showingMovieDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showingMovieDate.ForeColor = System.Drawing.Color.White;
            this.showingMovieDate.Location = new System.Drawing.Point(606, 560);
            this.showingMovieDate.Name = "showingMovieDate";
            this.showingMovieDate.Size = new System.Drawing.Size(49, 24);
            this.showingMovieDate.TabIndex = 41;
            this.showingMovieDate.Text = "date";
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.BackColor = System.Drawing.Color.Transparent;
            this.movieName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieName.ForeColor = System.Drawing.Color.White;
            this.movieName.Location = new System.Drawing.Point(496, 1024);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(0, 24);
            this.movieName.TabIndex = 39;
            // 
            // commingPreviousButton
            // 
            this.commingPreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commingPreviousButton.AutoSize = true;
            this.commingPreviousButton.BackColor = System.Drawing.Color.Transparent;
            this.commingPreviousButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commingPreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commingPreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commingPreviousButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commingPreviousButton.ForeColor = System.Drawing.Color.White;
            this.commingPreviousButton.Location = new System.Drawing.Point(37, 924);
            this.commingPreviousButton.Name = "commingPreviousButton";
            this.commingPreviousButton.Padding = new System.Windows.Forms.Padding(5);
            this.commingPreviousButton.Size = new System.Drawing.Size(41, 37);
            this.commingPreviousButton.TabIndex = 24;
            this.commingPreviousButton.Text = "<";
            this.commingPreviousButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.commingPreviousButton.Click += new System.EventHandler(this.commingPreviousButton_Click);
            // 
            // commingNextButton
            // 
            this.commingNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commingNextButton.AutoSize = true;
            this.commingNextButton.BackColor = System.Drawing.Color.Transparent;
            this.commingNextButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commingNextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commingNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commingNextButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commingNextButton.ForeColor = System.Drawing.Color.White;
            this.commingNextButton.Location = new System.Drawing.Point(948, 924);
            this.commingNextButton.Name = "commingNextButton";
            this.commingNextButton.Padding = new System.Windows.Forms.Padding(5);
            this.commingNextButton.Size = new System.Drawing.Size(41, 37);
            this.commingNextButton.TabIndex = 23;
            this.commingNextButton.Text = ">";
            this.commingNextButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.commingNextButton.Click += new System.EventHandler(this.commingNextButton_Click_1);
            // 
            // commingSlider
            // 
            this.commingSlider.BackColor = System.Drawing.Color.Transparent;
            this.commingSlider.Location = new System.Drawing.Point(100, 780);
            this.commingSlider.Name = "commingSlider";
            this.commingSlider.Size = new System.Drawing.Size(830, 311);
            this.commingSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commingSlider.TabIndex = 22;
            this.commingSlider.TabStop = false;
            this.commingSlider.Click += new System.EventHandler(this.commingSlider_Click);
            // 
            // showingPreviousButton
            // 
            this.showingPreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showingPreviousButton.AutoSize = true;
            this.showingPreviousButton.BackColor = System.Drawing.Color.Transparent;
            this.showingPreviousButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showingPreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showingPreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showingPreviousButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showingPreviousButton.ForeColor = System.Drawing.Color.White;
            this.showingPreviousButton.Location = new System.Drawing.Point(33, 385);
            this.showingPreviousButton.Name = "showingPreviousButton";
            this.showingPreviousButton.Padding = new System.Windows.Forms.Padding(5);
            this.showingPreviousButton.Size = new System.Drawing.Size(41, 37);
            this.showingPreviousButton.TabIndex = 20;
            this.showingPreviousButton.Text = "<";
            this.showingPreviousButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.showingPreviousButton.Click += new System.EventHandler(this.showingPreviousButton_Click_1);
            // 
            // showingNextButton
            // 
            this.showingNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showingNextButton.AutoSize = true;
            this.showingNextButton.BackColor = System.Drawing.Color.Transparent;
            this.showingNextButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showingNextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showingNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showingNextButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showingNextButton.ForeColor = System.Drawing.Color.White;
            this.showingNextButton.Location = new System.Drawing.Point(944, 385);
            this.showingNextButton.Name = "showingNextButton";
            this.showingNextButton.Padding = new System.Windows.Forms.Padding(5);
            this.showingNextButton.Size = new System.Drawing.Size(41, 37);
            this.showingNextButton.TabIndex = 19;
            this.showingNextButton.Text = ">";
            this.showingNextButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.showingNextButton.Click += new System.EventHandler(this.showingNextButton_Click_1);
            // 
            // showingSlider
            // 
            this.showingSlider.BackColor = System.Drawing.Color.Transparent;
            this.showingSlider.Location = new System.Drawing.Point(100, 240);
            this.showingSlider.Name = "showingSlider";
            this.showingSlider.Size = new System.Drawing.Size(818, 301);
            this.showingSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showingSlider.TabIndex = 18;
            this.showingSlider.TabStop = false;
            this.showingSlider.Click += new System.EventHandler(this.showingSlider_Click_1);
            // 
            // BrowseMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 619);
            this.Controls.Add(this.panel1);
            this.Name = "BrowseMovies";
            this.Text = "BrowseMovies";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commingSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showingSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox showingSlider;
        private System.Windows.Forms.Label showingPreviousButton;
        private System.Windows.Forms.Label showingNextButton;
        private System.Windows.Forms.PictureBox commingSlider;
        private System.Windows.Forms.Label commingPreviousButton;
        private System.Windows.Forms.Label commingNextButton;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.Label showingMovieDate;
        private System.Windows.Forms.Label showingMovieName;
        private System.Windows.Forms.Label commingMovieName;
        private System.Windows.Forms.Label commingMovieDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}