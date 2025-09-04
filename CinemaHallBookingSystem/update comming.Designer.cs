namespace CinemaHallBookingSystem
{
    partial class update_comming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_comming));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.updateNameBtn = new System.Windows.Forms.Button();
            this.updateDateBtn = new System.Windows.Forms.Button();
            this.newMovieDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newMovieName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PreMovieName = new System.Windows.Forms.TextBox();
            this.updateImageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.commingNextButton = new System.Windows.Forms.Label();
            this.showingNextButton = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.updateNameBtn);
            this.panel1.Controls.Add(this.updateDateBtn);
            this.panel1.Controls.Add(this.newMovieDatePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.newMovieName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PreMovieName);
            this.panel1.Controls.Add(this.updateImageButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.commingNextButton);
            this.panel1.Controls.Add(this.showingNextButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(572, 456);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 65;
            this.label4.Text = "Updated Movie Image";
            // 
            // updateNameBtn
            // 
            this.updateNameBtn.AccessibleName = "";
            this.updateNameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateNameBtn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.updateNameBtn.FlatAppearance.BorderSize = 2;
            this.updateNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateNameBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNameBtn.ForeColor = System.Drawing.Color.White;
            this.updateNameBtn.Location = new System.Drawing.Point(274, 218);
            this.updateNameBtn.Name = "updateNameBtn";
            this.updateNameBtn.Size = new System.Drawing.Size(261, 31);
            this.updateNameBtn.TabIndex = 64;
            this.updateNameBtn.Text = "Update Name";
            this.updateNameBtn.UseVisualStyleBackColor = false;
            this.updateNameBtn.Click += new System.EventHandler(this.updateNameBtn_Click);
            // 
            // updateDateBtn
            // 
            this.updateDateBtn.AccessibleName = "";
            this.updateDateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateDateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.updateDateBtn.FlatAppearance.BorderSize = 2;
            this.updateDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateDateBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDateBtn.ForeColor = System.Drawing.Color.White;
            this.updateDateBtn.Location = new System.Drawing.Point(274, 324);
            this.updateDateBtn.Name = "updateDateBtn";
            this.updateDateBtn.Size = new System.Drawing.Size(261, 31);
            this.updateDateBtn.TabIndex = 63;
            this.updateDateBtn.Text = "Update Date";
            this.updateDateBtn.UseVisualStyleBackColor = false;
            this.updateDateBtn.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // newMovieDatePicker
            // 
            this.newMovieDatePicker.AccessibleName = "";
            this.newMovieDatePicker.CustomFormat = "yyyy MMMM dddd hh:mm:ss";
            this.newMovieDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newMovieDatePicker.Location = new System.Drawing.Point(274, 278);
            this.newMovieDatePicker.Name = "newMovieDatePicker";
            this.newMovieDatePicker.Size = new System.Drawing.Size(261, 20);
            this.newMovieDatePicker.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Updated Movie Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "Updated Movie Name";
            // 
            // newMovieName
            // 
            this.newMovieName.AccessibleName = "";
            this.newMovieName.Location = new System.Drawing.Point(274, 179);
            this.newMovieName.Name = "newMovieName";
            this.newMovieName.Size = new System.Drawing.Size(261, 20);
            this.newMovieName.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "Movie Name To Update";
            // 
            // PreMovieName
            // 
            this.PreMovieName.AccessibleName = "";
            this.PreMovieName.Location = new System.Drawing.Point(274, 123);
            this.PreMovieName.Name = "PreMovieName";
            this.PreMovieName.Size = new System.Drawing.Size(261, 20);
            this.PreMovieName.TabIndex = 56;
            // 
            // updateImageButton
            // 
            this.updateImageButton.AccessibleName = "";
            this.updateImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateImageButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.updateImageButton.FlatAppearance.BorderSize = 2;
            this.updateImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateImageButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateImageButton.ForeColor = System.Drawing.Color.White;
            this.updateImageButton.Location = new System.Drawing.Point(274, 382);
            this.updateImageButton.Name = "updateImageButton";
            this.updateImageButton.Size = new System.Drawing.Size(261, 31);
            this.updateImageButton.TabIndex = 55;
            this.updateImageButton.Text = "Update Image";
            this.updateImageButton.UseVisualStyleBackColor = false;
            this.updateImageButton.Click += new System.EventHandler(this.updateImageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 76);
            this.label1.TabIndex = 24;
            this.label1.Text = "Update Comming Movie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.commingNextButton.Location = new System.Drawing.Point(1172, 1106);
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
            this.showingNextButton.Location = new System.Drawing.Point(1169, 677);
            this.showingNextButton.Name = "showingNextButton";
            this.showingNextButton.Padding = new System.Windows.Forms.Padding(5);
            this.showingNextButton.Size = new System.Drawing.Size(41, 37);
            this.showingNextButton.TabIndex = 19;
            this.showingNextButton.Text = ">";
            this.showingNextButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // update_comming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 456);
            this.Controls.Add(this.panel1);
            this.Name = "update_comming";
            this.Text = "update_comming";
            this.Load += new System.EventHandler(this.update_comming_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateDateBtn;
        private System.Windows.Forms.DateTimePicker newMovieDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newMovieName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PreMovieName;
        private System.Windows.Forms.Button updateImageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label commingNextButton;
        private System.Windows.Forms.Label showingNextButton;
        private System.Windows.Forms.Button updateNameBtn;
        private System.Windows.Forms.Label label4;
    }
}