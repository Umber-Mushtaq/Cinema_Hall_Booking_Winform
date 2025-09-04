namespace CinemaHallBookingSystem
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginVerifyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.commingNextButton = new System.Windows.Forms.Label();
            this.showingNextButton = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.loginVerifyButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usernameTextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.commingNextButton);
            this.panel1.Controls.Add(this.showingNextButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(446, 515);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginVerifyButton
            // 
            this.loginVerifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginVerifyButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.loginVerifyButton.FlatAppearance.BorderSize = 2;
            this.loginVerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginVerifyButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginVerifyButton.ForeColor = System.Drawing.Color.White;
            this.loginVerifyButton.Location = new System.Drawing.Point(152, 459);
            this.loginVerifyButton.Name = "loginVerifyButton";
            this.loginVerifyButton.Size = new System.Drawing.Size(136, 44);
            this.loginVerifyButton.TabIndex = 29;
            this.loginVerifyButton.Text = "Login";
            this.loginVerifyButton.UseVisualStyleBackColor = false;
            this.loginVerifyButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.White;
            this.passwordText.Location = new System.Drawing.Point(116, 342);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(221, 31);
            this.passwordText.TabIndex = 27;
            this.passwordText.Text = "Password...";
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 44);
            this.label1.TabIndex = 26;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.White;
            this.usernameTextbox.Location = new System.Drawing.Point(116, 252);
            this.usernameTextbox.Multiline = true;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(221, 31);
            this.usernameTextbox.TabIndex = 25;
            this.usernameTextbox.Text = "User Name...";
            this.usernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Edwardian Script ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 44);
            this.label3.TabIndex = 24;
            this.label3.Text = "User Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.commingNextButton.Location = new System.Drawing.Point(1167, 1101);
            this.commingNextButton.Name = "commingNextButton";
            this.commingNextButton.Padding = new System.Windows.Forms.Padding(5);
            this.commingNextButton.Size = new System.Drawing.Size(41, 37);
            this.commingNextButton.TabIndex = 23;
            this.commingNextButton.Text = ">";
            this.commingNextButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.showingNextButton.Location = new System.Drawing.Point(1164, 672);
            this.showingNextButton.Name = "showingNextButton";
            this.showingNextButton.Padding = new System.Windows.Forms.Padding(5);
            this.showingNextButton.Size = new System.Drawing.Size(41, 37);
            this.showingNextButton.TabIndex = 19;
            this.showingNextButton.Text = ">";
            this.showingNextButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 515);
            this.Controls.Add(this.panel1);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label commingNextButton;
        private System.Windows.Forms.Label showingNextButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginVerifyButton;
    }
}