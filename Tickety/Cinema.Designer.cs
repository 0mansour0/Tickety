namespace Tickety
{
    partial class Cinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cinema));
            this.tm3 = new System.Windows.Forms.RadioButton();
            this.tm2 = new System.Windows.Forms.RadioButton();
            this.tm4 = new System.Windows.Forms.RadioButton();
            this.tm1 = new System.Windows.Forms.RadioButton();
            this.time = new System.Windows.Forms.GroupBox();
            this.set = new System.Windows.Forms.GroupBox();
            this.normalTicketsBox = new System.Windows.Forms.ComboBox();
            this.vipTicketsBox = new System.Windows.Forms.ComboBox();
            this.normalPriceLable = new System.Windows.Forms.Label();
            this.vip = new System.Windows.Forms.CheckBox();
            this.vipPriceLable = new System.Windows.Forms.Label();
            this.normal = new System.Windows.Forms.CheckBox();
            this.ticketLable = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.topmovieLable = new System.Windows.Forms.Label();
            this.movie1Button = new System.Windows.Forms.RadioButton();
            this.movieGroup = new System.Windows.Forms.GroupBox();
            this.movie3Button = new System.Windows.Forms.RadioButton();
            this.movie2Button = new System.Windows.Forms.RadioButton();
            this.movie1Photo = new System.Windows.Forms.PictureBox();
            this.movie2Photo = new System.Windows.Forms.PictureBox();
            this.movie3Photo = new System.Windows.Forms.PictureBox();
            this.pcinema = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.time.SuspendLayout();
            this.set.SuspendLayout();
            this.movieGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie1Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie2Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie3Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcinema)).BeginInit();
            this.SuspendLayout();
            // 
            // tm3
            // 
            this.tm3.AutoSize = true;
            this.tm3.Location = new System.Drawing.Point(15, 116);
            this.tm3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tm3.Name = "tm3";
            this.tm3.Size = new System.Drawing.Size(114, 29);
            this.tm3.TabIndex = 0;
            this.tm3.Text = "4 : 7 PM";
            this.tm3.UseVisualStyleBackColor = true;
            // 
            // tm2
            // 
            this.tm2.AutoSize = true;
            this.tm2.Location = new System.Drawing.Point(15, 80);
            this.tm2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tm2.Name = "tm2";
            this.tm2.Size = new System.Drawing.Size(120, 29);
            this.tm2.TabIndex = 3;
            this.tm2.Text = "1 : 3  PM";
            this.tm2.UseVisualStyleBackColor = true;
            // 
            // tm4
            // 
            this.tm4.AutoSize = true;
            this.tm4.Location = new System.Drawing.Point(15, 151);
            this.tm4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tm4.Name = "tm4";
            this.tm4.Size = new System.Drawing.Size(126, 29);
            this.tm4.TabIndex = 1;
            this.tm4.Text = "7 : 10 PM";
            this.tm4.UseVisualStyleBackColor = true;
            // 
            // tm1
            // 
            this.tm1.AutoSize = true;
            this.tm1.Checked = true;
            this.tm1.Location = new System.Drawing.Point(15, 44);
            this.tm1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tm1.Name = "tm1";
            this.tm1.Size = new System.Drawing.Size(127, 29);
            this.tm1.TabIndex = 2;
            this.tm1.TabStop = true;
            this.tm1.Text = "10 : 1 AM";
            this.tm1.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.time.Controls.Add(this.tm3);
            this.time.Controls.Add(this.tm2);
            this.time.Controls.Add(this.tm4);
            this.time.Controls.Add(this.tm1);
            this.time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.time.ForeColor = System.Drawing.Color.DarkOrange;
            this.time.Location = new System.Drawing.Point(16, 382);
            this.time.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.time.Name = "time";
            this.time.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.time.Size = new System.Drawing.Size(167, 186);
            this.time.TabIndex = 8;
            this.time.TabStop = false;
            this.time.Text = "Time";
            // 
            // set
            // 
            this.set.BackColor = System.Drawing.Color.Transparent;
            this.set.Controls.Add(this.normalTicketsBox);
            this.set.Controls.Add(this.vipTicketsBox);
            this.set.Controls.Add(this.normalPriceLable);
            this.set.Controls.Add(this.vip);
            this.set.Controls.Add(this.vipPriceLable);
            this.set.Controls.Add(this.normal);
            this.set.Controls.Add(this.ticketLable);
            this.set.ForeColor = System.Drawing.Color.DarkOrange;
            this.set.Location = new System.Drawing.Point(229, 425);
            this.set.Margin = new System.Windows.Forms.Padding(5);
            this.set.Name = "set";
            this.set.Padding = new System.Windows.Forms.Padding(5);
            this.set.Size = new System.Drawing.Size(277, 137);
            this.set.TabIndex = 9;
            this.set.TabStop = false;
            this.set.Text = "Choose Sets";
            // 
            // normalTicketsBox
            // 
            this.normalTicketsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalTicketsBox.FormattingEnabled = true;
            this.normalTicketsBox.Items.AddRange(new object[] {
            "0 ",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.normalTicketsBox.Location = new System.Drawing.Point(198, 97);
            this.normalTicketsBox.Name = "normalTicketsBox";
            this.normalTicketsBox.Size = new System.Drawing.Size(54, 28);
            this.normalTicketsBox.TabIndex = 19;
            this.normalTicketsBox.Text = "0 ";
            // 
            // vipTicketsBox
            // 
            this.vipTicketsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vipTicketsBox.FormattingEnabled = true;
            this.vipTicketsBox.Items.AddRange(new object[] {
            "0 ",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.vipTicketsBox.Location = new System.Drawing.Point(198, 58);
            this.vipTicketsBox.Name = "vipTicketsBox";
            this.vipTicketsBox.Size = new System.Drawing.Size(54, 28);
            this.vipTicketsBox.TabIndex = 18;
            this.vipTicketsBox.Text = "1";
            // 
            // normalPriceLable
            // 
            this.normalPriceLable.AutoSize = true;
            this.normalPriceLable.Location = new System.Drawing.Point(134, 98);
            this.normalPriceLable.Name = "normalPriceLable";
            this.normalPriceLable.Size = new System.Drawing.Size(36, 25);
            this.normalPriceLable.TabIndex = 17;
            this.normalPriceLable.Text = "65";
            // 
            // vip
            // 
            this.vip.AutoSize = true;
            this.vip.Checked = true;
            this.vip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vip.Location = new System.Drawing.Point(10, 61);
            this.vip.Margin = new System.Windows.Forms.Padding(5);
            this.vip.Name = "vip";
            this.vip.Size = new System.Drawing.Size(69, 29);
            this.vip.TabIndex = 7;
            this.vip.Text = "VIP";
            this.vip.UseVisualStyleBackColor = true;
            // 
            // vipPriceLable
            // 
            this.vipPriceLable.AutoSize = true;
            this.vipPriceLable.Location = new System.Drawing.Point(124, 61);
            this.vipPriceLable.Name = "vipPriceLable";
            this.vipPriceLable.Size = new System.Drawing.Size(48, 25);
            this.vipPriceLable.TabIndex = 16;
            this.vipPriceLable.Text = "100";
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(10, 101);
            this.normal.Margin = new System.Windows.Forms.Padding(5);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(125, 29);
            this.normal.TabIndex = 8;
            this.normal.Text = "NORMAL";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // ticketLable
            // 
            this.ticketLable.AutoSize = true;
            this.ticketLable.BackColor = System.Drawing.Color.Transparent;
            this.ticketLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLable.ForeColor = System.Drawing.Color.DarkOrange;
            this.ticketLable.Location = new System.Drawing.Point(177, 28);
            this.ticketLable.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ticketLable.Name = "ticketLable";
            this.ticketLable.Size = new System.Drawing.Size(88, 20);
            this.ticketLable.TabIndex = 10;
            this.ticketLable.Text = "Tickets : ";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.DarkSlateGray;
            this.result.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.ForeColor = System.Drawing.Color.DarkOrange;
            this.result.Location = new System.Drawing.Point(562, 508);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(117, 54);
            this.result.TabIndex = 14;
            this.result.Text = "Finish";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // topmovieLable
            // 
            this.topmovieLable.AutoSize = true;
            this.topmovieLable.BackColor = System.Drawing.Color.Transparent;
            this.topmovieLable.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topmovieLable.ForeColor = System.Drawing.Color.DarkOrange;
            this.topmovieLable.Location = new System.Drawing.Point(258, 28);
            this.topmovieLable.Name = "topmovieLable";
            this.topmovieLable.Size = new System.Drawing.Size(248, 58);
            this.topmovieLable.TabIndex = 15;
            this.topmovieLable.Text = "Top Movies\r\n";
            // 
            // movie1Button
            // 
            this.movie1Button.AutoSize = true;
            this.movie1Button.BackColor = System.Drawing.Color.Transparent;
            this.movie1Button.Checked = true;
            this.movie1Button.Location = new System.Drawing.Point(124, 21);
            this.movie1Button.Name = "movie1Button";
            this.movie1Button.Size = new System.Drawing.Size(17, 16);
            this.movie1Button.TabIndex = 16;
            this.movie1Button.TabStop = true;
            this.movie1Button.UseVisualStyleBackColor = false;
            // 
            // movieGroup
            // 
            this.movieGroup.BackColor = System.Drawing.Color.Transparent;
            this.movieGroup.Controls.Add(this.movie3Button);
            this.movieGroup.Controls.Add(this.movie2Button);
            this.movieGroup.Controls.Add(this.movie1Button);
            this.movieGroup.ForeColor = System.Drawing.Color.DarkOrange;
            this.movieGroup.Location = new System.Drawing.Point(16, 331);
            this.movieGroup.Name = "movieGroup";
            this.movieGroup.Size = new System.Drawing.Size(653, 43);
            this.movieGroup.TabIndex = 17;
            this.movieGroup.TabStop = false;
            this.movieGroup.Text = "Choose";
            // 
            // movie3Button
            // 
            this.movie3Button.AutoSize = true;
            this.movie3Button.BackColor = System.Drawing.Color.Transparent;
            this.movie3Button.Location = new System.Drawing.Point(559, 21);
            this.movie3Button.Name = "movie3Button";
            this.movie3Button.Size = new System.Drawing.Size(17, 16);
            this.movie3Button.TabIndex = 18;
            this.movie3Button.UseVisualStyleBackColor = false;
            // 
            // movie2Button
            // 
            this.movie2Button.AutoSize = true;
            this.movie2Button.BackColor = System.Drawing.Color.Transparent;
            this.movie2Button.Location = new System.Drawing.Point(352, 21);
            this.movie2Button.Name = "movie2Button";
            this.movie2Button.Size = new System.Drawing.Size(17, 16);
            this.movie2Button.TabIndex = 17;
            this.movie2Button.UseVisualStyleBackColor = false;
            // 
            // movie1Photo
            // 
            this.movie1Photo.Image = ((System.Drawing.Image)(resources.GetObject("movie1Photo.Image")));
            this.movie1Photo.Location = new System.Drawing.Point(78, 114);
            this.movie1Photo.Name = "movie1Photo";
            this.movie1Photo.Size = new System.Drawing.Size(159, 211);
            this.movie1Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie1Photo.TabIndex = 18;
            this.movie1Photo.TabStop = false;
            this.movie1Photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // movie2Photo
            // 
            this.movie2Photo.Image = ((System.Drawing.Image)(resources.GetObject("movie2Photo.Image")));
            this.movie2Photo.Location = new System.Drawing.Point(299, 114);
            this.movie2Photo.Name = "movie2Photo";
            this.movie2Photo.Size = new System.Drawing.Size(159, 211);
            this.movie2Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie2Photo.TabIndex = 19;
            this.movie2Photo.TabStop = false;
            this.movie2Photo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // movie3Photo
            // 
            this.movie3Photo.Image = ((System.Drawing.Image)(resources.GetObject("movie3Photo.Image")));
            this.movie3Photo.Location = new System.Drawing.Point(510, 114);
            this.movie3Photo.Name = "movie3Photo";
            this.movie3Photo.Size = new System.Drawing.Size(159, 211);
            this.movie3Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie3Photo.TabIndex = 20;
            this.movie3Photo.TabStop = false;
            this.movie3Photo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pcinema
            // 
            this.pcinema.Image = ((System.Drawing.Image)(resources.GetObject("pcinema.Image")));
            this.pcinema.Location = new System.Drawing.Point(31, 11);
            this.pcinema.Margin = new System.Windows.Forms.Padding(2);
            this.pcinema.Name = "pcinema";
            this.pcinema.Size = new System.Drawing.Size(92, 95);
            this.pcinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcinema.TabIndex = 21;
            this.pcinema.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(657, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 33);
            this.exit.TabIndex = 22;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 593);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pcinema);
            this.Controls.Add(this.movie3Photo);
            this.Controls.Add(this.movie2Photo);
            this.Controls.Add(this.movie1Photo);
            this.Controls.Add(this.movieGroup);
            this.Controls.Add(this.topmovieLable);
            this.Controls.Add(this.result);
            this.Controls.Add(this.set);
            this.Controls.Add(this.time);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Cinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.time.ResumeLayout(false);
            this.time.PerformLayout();
            this.set.ResumeLayout(false);
            this.set.PerformLayout();
            this.movieGroup.ResumeLayout(false);
            this.movieGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie1Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie2Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie3Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcinema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton tm3;
        private System.Windows.Forms.RadioButton tm2;
        private System.Windows.Forms.RadioButton tm4;
        private System.Windows.Forms.RadioButton tm1;
        private System.Windows.Forms.GroupBox time;
        private System.Windows.Forms.GroupBox set;
        private System.Windows.Forms.CheckBox vip;
        private System.Windows.Forms.CheckBox normal;
        private System.Windows.Forms.Label ticketLable;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label topmovieLable;
        private System.Windows.Forms.Label normalPriceLable;
        private System.Windows.Forms.Label vipPriceLable;
        private System.Windows.Forms.ComboBox normalTicketsBox;
        private System.Windows.Forms.ComboBox vipTicketsBox;
        private System.Windows.Forms.RadioButton movie1Button;
        private System.Windows.Forms.GroupBox movieGroup;
        private System.Windows.Forms.RadioButton movie3Button;
        private System.Windows.Forms.RadioButton movie2Button;
        private System.Windows.Forms.PictureBox movie1Photo;
        private System.Windows.Forms.PictureBox movie2Photo;
        private System.Windows.Forms.PictureBox movie3Photo;
        private System.Windows.Forms.PictureBox pcinema;
        private System.Windows.Forms.Button exit;
    }
}

