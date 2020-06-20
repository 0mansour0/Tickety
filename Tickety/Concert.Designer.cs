namespace Tickety
{
    partial class Concert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concert));
            this.party3Photo = new System.Windows.Forms.PictureBox();
            this.party1Photo = new System.Windows.Forms.PictureBox();
            this.party2Photo = new System.Windows.Forms.PictureBox();
            this.concetLable = new System.Windows.Forms.Label();
            this.topweekLable = new System.Windows.Forms.Label();
            this.novButton = new System.Windows.Forms.RadioButton();
            this.decButton = new System.Windows.Forms.RadioButton();
            this.AlexButton = new System.Windows.Forms.RadioButton();
            this.cairoButton = new System.Windows.Forms.RadioButton();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.placeGroupBox = new System.Windows.Forms.GroupBox();
            this.concertBox = new System.Windows.Forms.ComboBox();
            this.finish = new System.Windows.Forms.Button();
            this.vipButton = new System.Windows.Forms.CheckBox();
            this.normalButton = new System.Windows.Forms.CheckBox();
            this.vipticketBox = new System.Windows.Forms.ComboBox();
            this.normalticketBox = new System.Windows.Forms.ComboBox();
            this.setgroupBox = new System.Windows.Forms.GroupBox();
            this.normalpriceLable = new System.Windows.Forms.Label();
            this.vippriceLable = new System.Windows.Forms.Label();
            this.chooseLable = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.pparty = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.party3Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.party1Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.party2Photo)).BeginInit();
            this.timeGroupBox.SuspendLayout();
            this.placeGroupBox.SuspendLayout();
            this.setgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pparty)).BeginInit();
            this.SuspendLayout();
            // 
            // party3Photo
            // 
            this.party3Photo.Image = ((System.Drawing.Image)(resources.GetObject("party3Photo.Image")));
            this.party3Photo.Location = new System.Drawing.Point(439, 131);
            this.party3Photo.Margin = new System.Windows.Forms.Padding(4);
            this.party3Photo.Name = "party3Photo";
            this.party3Photo.Size = new System.Drawing.Size(192, 129);
            this.party3Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.party3Photo.TabIndex = 2;
            this.party3Photo.TabStop = false;
            this.party3Photo.Click += new System.EventHandler(this.picbox3_Click);
            // 
            // party1Photo
            // 
            this.party1Photo.Image = ((System.Drawing.Image)(resources.GetObject("party1Photo.Image")));
            this.party1Photo.Location = new System.Drawing.Point(53, 131);
            this.party1Photo.Margin = new System.Windows.Forms.Padding(4);
            this.party1Photo.Name = "party1Photo";
            this.party1Photo.Size = new System.Drawing.Size(183, 129);
            this.party1Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.party1Photo.TabIndex = 1;
            this.party1Photo.TabStop = false;
            this.party1Photo.Click += new System.EventHandler(this.picbox2_Click);
            // 
            // party2Photo
            // 
            this.party2Photo.Image = ((System.Drawing.Image)(resources.GetObject("party2Photo.Image")));
            this.party2Photo.Location = new System.Drawing.Point(277, 131);
            this.party2Photo.Margin = new System.Windows.Forms.Padding(4);
            this.party2Photo.Name = "party2Photo";
            this.party2Photo.Size = new System.Drawing.Size(122, 129);
            this.party2Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.party2Photo.TabIndex = 0;
            this.party2Photo.TabStop = false;
            this.party2Photo.Click += new System.EventHandler(this.picbox1_Click);
            // 
            // concetLable
            // 
            this.concetLable.AutoSize = true;
            this.concetLable.BackColor = System.Drawing.Color.Transparent;
            this.concetLable.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.concetLable.ForeColor = System.Drawing.Color.IndianRed;
            this.concetLable.Location = new System.Drawing.Point(262, 11);
            this.concetLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.concetLable.Name = "concetLable";
            this.concetLable.Size = new System.Drawing.Size(177, 58);
            this.concetLable.TabIndex = 3;
            this.concetLable.Text = "Concert";
            // 
            // topweekLable
            // 
            this.topweekLable.AutoSize = true;
            this.topweekLable.BackColor = System.Drawing.Color.Transparent;
            this.topweekLable.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topweekLable.ForeColor = System.Drawing.Color.IndianRed;
            this.topweekLable.Location = new System.Drawing.Point(270, 85);
            this.topweekLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topweekLable.Name = "topweekLable";
            this.topweekLable.Size = new System.Drawing.Size(136, 42);
            this.topweekLable.TabIndex = 4;
            this.topweekLable.Text = "Top Week";
            // 
            // novButton
            // 
            this.novButton.AutoSize = true;
            this.novButton.Checked = true;
            this.novButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novButton.ForeColor = System.Drawing.Color.White;
            this.novButton.Location = new System.Drawing.Point(8, 25);
            this.novButton.Margin = new System.Windows.Forms.Padding(4);
            this.novButton.Name = "novButton";
            this.novButton.Size = new System.Drawing.Size(131, 29);
            this.novButton.TabIndex = 6;
            this.novButton.TabStop = true;
            this.novButton.Text = "November";
            this.novButton.UseVisualStyleBackColor = true;
            // 
            // decButton
            // 
            this.decButton.AutoSize = true;
            this.decButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decButton.ForeColor = System.Drawing.Color.White;
            this.decButton.Location = new System.Drawing.Point(150, 25);
            this.decButton.Margin = new System.Windows.Forms.Padding(4);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(131, 29);
            this.decButton.TabIndex = 7;
            this.decButton.Text = "December";
            this.decButton.UseVisualStyleBackColor = true;
            // 
            // AlexButton
            // 
            this.AlexButton.AutoSize = true;
            this.AlexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlexButton.ForeColor = System.Drawing.Color.White;
            this.AlexButton.Location = new System.Drawing.Point(143, 20);
            this.AlexButton.Margin = new System.Windows.Forms.Padding(4);
            this.AlexButton.Name = "AlexButton";
            this.AlexButton.Size = new System.Drawing.Size(76, 29);
            this.AlexButton.TabIndex = 8;
            this.AlexButton.Text = "Alex";
            this.AlexButton.UseVisualStyleBackColor = true;
            // 
            // cairoButton
            // 
            this.cairoButton.AutoSize = true;
            this.cairoButton.Checked = true;
            this.cairoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cairoButton.ForeColor = System.Drawing.Color.White;
            this.cairoButton.Location = new System.Drawing.Point(8, 20);
            this.cairoButton.Margin = new System.Windows.Forms.Padding(4);
            this.cairoButton.Name = "cairoButton";
            this.cairoButton.Size = new System.Drawing.Size(85, 29);
            this.cairoButton.TabIndex = 9;
            this.cairoButton.TabStop = true;
            this.cairoButton.Text = "Cairo";
            this.cairoButton.UseVisualStyleBackColor = true;
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.timeGroupBox.Controls.Add(this.decButton);
            this.timeGroupBox.Controls.Add(this.novButton);
            this.timeGroupBox.ForeColor = System.Drawing.Color.IndianRed;
            this.timeGroupBox.Location = new System.Drawing.Point(344, 320);
            this.timeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.timeGroupBox.Size = new System.Drawing.Size(289, 70);
            this.timeGroupBox.TabIndex = 16;
            this.timeGroupBox.TabStop = false;
            this.timeGroupBox.Text = "Month";
            // 
            // placeGroupBox
            // 
            this.placeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.placeGroupBox.Controls.Add(this.cairoButton);
            this.placeGroupBox.Controls.Add(this.AlexButton);
            this.placeGroupBox.ForeColor = System.Drawing.Color.IndianRed;
            this.placeGroupBox.Location = new System.Drawing.Point(395, 421);
            this.placeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.placeGroupBox.Name = "placeGroupBox";
            this.placeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.placeGroupBox.Size = new System.Drawing.Size(238, 57);
            this.placeGroupBox.TabIndex = 17;
            this.placeGroupBox.TabStop = false;
            this.placeGroupBox.Text = "Place";
            // 
            // concertBox
            // 
            this.concertBox.BackColor = System.Drawing.Color.GhostWhite;
            this.concertBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concertBox.FormattingEnabled = true;
            this.concertBox.Items.AddRange(new object[] {
            "Tamer Hosny",
            "Jadal",
            "Tamer Ashour",
            "El Joker",
            "Amr Diab",
            "Cairokee"});
            this.concertBox.Location = new System.Drawing.Point(31, 320);
            this.concertBox.Margin = new System.Windows.Forms.Padding(4);
            this.concertBox.Name = "concertBox";
            this.concertBox.Size = new System.Drawing.Size(185, 33);
            this.concertBox.TabIndex = 18;
            this.concertBox.Text = "Tamer Hosny";
            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.Color.Indigo;
            this.finish.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish.ForeColor = System.Drawing.Color.IndianRed;
            this.finish.Location = new System.Drawing.Point(421, 498);
            this.finish.Margin = new System.Windows.Forms.Padding(4);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(211, 53);
            this.finish.TabIndex = 19;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = false;
            this.finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // vipButton
            // 
            this.vipButton.AutoSize = true;
            this.vipButton.BackColor = System.Drawing.Color.Transparent;
            this.vipButton.Checked = true;
            this.vipButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vipButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vipButton.ForeColor = System.Drawing.Color.White;
            this.vipButton.Location = new System.Drawing.Point(22, 34);
            this.vipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vipButton.Name = "vipButton";
            this.vipButton.Size = new System.Drawing.Size(58, 23);
            this.vipButton.TabIndex = 20;
            this.vipButton.Text = "VIP";
            this.vipButton.UseVisualStyleBackColor = false;
            // 
            // normalButton
            // 
            this.normalButton.AutoSize = true;
            this.normalButton.BackColor = System.Drawing.Color.Transparent;
            this.normalButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalButton.ForeColor = System.Drawing.Color.White;
            this.normalButton.Location = new System.Drawing.Point(22, 87);
            this.normalButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(91, 23);
            this.normalButton.TabIndex = 21;
            this.normalButton.Text = "Normal";
            this.normalButton.UseVisualStyleBackColor = false;
            // 
            // vipticketBox
            // 
            this.vipticketBox.FormattingEnabled = true;
            this.vipticketBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.vipticketBox.Location = new System.Drawing.Point(202, 36);
            this.vipticketBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vipticketBox.Name = "vipticketBox";
            this.vipticketBox.Size = new System.Drawing.Size(43, 24);
            this.vipticketBox.TabIndex = 22;
            this.vipticketBox.Text = "1";
            // 
            // normalticketBox
            // 
            this.normalticketBox.FormattingEnabled = true;
            this.normalticketBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.normalticketBox.Location = new System.Drawing.Point(202, 86);
            this.normalticketBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.normalticketBox.Name = "normalticketBox";
            this.normalticketBox.Size = new System.Drawing.Size(43, 24);
            this.normalticketBox.TabIndex = 23;
            this.normalticketBox.Text = "0";
            // 
            // setgroupBox
            // 
            this.setgroupBox.BackColor = System.Drawing.Color.Transparent;
            this.setgroupBox.Controls.Add(this.normalpriceLable);
            this.setgroupBox.Controls.Add(this.vippriceLable);
            this.setgroupBox.Controls.Add(this.vipButton);
            this.setgroupBox.Controls.Add(this.normalticketBox);
            this.setgroupBox.Controls.Add(this.normalButton);
            this.setgroupBox.Controls.Add(this.vipticketBox);
            this.setgroupBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setgroupBox.ForeColor = System.Drawing.Color.IndianRed;
            this.setgroupBox.Location = new System.Drawing.Point(31, 421);
            this.setgroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setgroupBox.Name = "setgroupBox";
            this.setgroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setgroupBox.Size = new System.Drawing.Size(266, 132);
            this.setgroupBox.TabIndex = 24;
            this.setgroupBox.TabStop = false;
            this.setgroupBox.Text = "Choose Your Sets";
            // 
            // normalpriceLable
            // 
            this.normalpriceLable.AutoSize = true;
            this.normalpriceLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalpriceLable.ForeColor = System.Drawing.Color.Brown;
            this.normalpriceLable.Location = new System.Drawing.Point(108, 85);
            this.normalpriceLable.Name = "normalpriceLable";
            this.normalpriceLable.Size = new System.Drawing.Size(82, 22);
            this.normalpriceLable.TabIndex = 25;
            this.normalpriceLable.Text = "100 L.E";
            // 
            // vippriceLable
            // 
            this.vippriceLable.AutoSize = true;
            this.vippriceLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vippriceLable.ForeColor = System.Drawing.Color.Brown;
            this.vippriceLable.Location = new System.Drawing.Point(108, 32);
            this.vippriceLable.Name = "vippriceLable";
            this.vippriceLable.Size = new System.Drawing.Size(82, 22);
            this.vippriceLable.TabIndex = 24;
            this.vippriceLable.Text = "200 L.E";
            // 
            // chooseLable
            // 
            this.chooseLable.AutoSize = true;
            this.chooseLable.BackColor = System.Drawing.Color.Transparent;
            this.chooseLable.CausesValidation = false;
            this.chooseLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLable.ForeColor = System.Drawing.Color.IndianRed;
            this.chooseLable.Location = new System.Drawing.Point(31, 295);
            this.chooseLable.Name = "chooseLable";
            this.chooseLable.Size = new System.Drawing.Size(158, 19);
            this.chooseLable.TabIndex = 25;
            this.chooseLable.Text = "Choose Concert :";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(618, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 28);
            this.exit.TabIndex = 26;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pparty
            // 
            this.pparty.Image = ((System.Drawing.Image)(resources.GetObject("pparty.Image")));
            this.pparty.Location = new System.Drawing.Point(13, 9);
            this.pparty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pparty.Name = "pparty";
            this.pparty.Size = new System.Drawing.Size(99, 103);
            this.pparty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pparty.TabIndex = 27;
            this.pparty.TabStop = false;
            // 
            // Concert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(662, 564);
            this.Controls.Add(this.pparty);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.chooseLable);
            this.Controls.Add(this.setgroupBox);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.concetLable);
            this.Controls.Add(this.concertBox);
            this.Controls.Add(this.placeGroupBox);
            this.Controls.Add(this.timeGroupBox);
            this.Controls.Add(this.topweekLable);
            this.Controls.Add(this.party3Photo);
            this.Controls.Add(this.party1Photo);
            this.Controls.Add(this.party2Photo);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Concert";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.party3Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.party1Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.party2Photo)).EndInit();
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            this.placeGroupBox.ResumeLayout(false);
            this.placeGroupBox.PerformLayout();
            this.setgroupBox.ResumeLayout(false);
            this.setgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pparty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox party2Photo;
        private System.Windows.Forms.PictureBox party1Photo;
        private System.Windows.Forms.PictureBox party3Photo;
        private System.Windows.Forms.Label concetLable;
        private System.Windows.Forms.Label topweekLable;
        private System.Windows.Forms.RadioButton novButton;
        private System.Windows.Forms.RadioButton decButton;
        private System.Windows.Forms.RadioButton AlexButton;
        private System.Windows.Forms.RadioButton cairoButton;
        private System.Windows.Forms.GroupBox timeGroupBox;
        private System.Windows.Forms.GroupBox placeGroupBox;
        private System.Windows.Forms.ComboBox concertBox;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.CheckBox vipButton;
        private System.Windows.Forms.CheckBox normalButton;
        private System.Windows.Forms.ComboBox vipticketBox;
        private System.Windows.Forms.ComboBox normalticketBox;
        private System.Windows.Forms.GroupBox setgroupBox;
        private System.Windows.Forms.Label chooseLable;
        private System.Windows.Forms.Label normalpriceLable;
        private System.Windows.Forms.Label vippriceLable;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pparty;
    }
}

