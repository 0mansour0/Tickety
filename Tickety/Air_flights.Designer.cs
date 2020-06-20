namespace Tickety
{
    partial class Air_flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Air_flights));
            this.returnButton = new System.Windows.Forms.RadioButton();
            this.onewayButton = new System.Windows.Forms.RadioButton();
            this.originBox = new System.Windows.Forms.ComboBox();
            this.originLable = new System.Windows.Forms.Label();
            this.destinationLable = new System.Windows.Forms.Label();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.departureLable = new System.Windows.Forms.Label();
            this.depDayBox = new System.Windows.Forms.ComboBox();
            this.depMonthBox = new System.Windows.Forms.ComboBox();
            this.returnLable = new System.Windows.Forms.Label();
            this.returnDayBox = new System.Windows.Forms.ComboBox();
            this.returnMonthBox = new System.Windows.Forms.ComboBox();
            this.depDayLable = new System.Windows.Forms.Label();
            this.depMonthLable = new System.Windows.Forms.Label();
            this.returnDayLable = new System.Windows.Forms.Label();
            this.returnMonthLable = new System.Windows.Forms.Label();
            this.adultButton = new System.Windows.Forms.RadioButton();
            this.childButton = new System.Windows.Forms.RadioButton();
            this.travellersLable = new System.Windows.Forms.GroupBox();
            this.finish = new System.Windows.Forms.Button();
            this.airflightLable = new System.Windows.Forms.Label();
            this.tickettypeGroup = new System.Windows.Forms.GroupBox();
            this.photoplane = new System.Windows.Forms.PictureBox();
            this.pair = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.travellersLable.SuspendLayout();
            this.tickettypeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoplane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pair)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.AutoSize = true;
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(172, 25);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(85, 23);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.CheckedChanged += new System.EventHandler(this.returnButton_CheckedChanged);
            // 
            // onewayButton
            // 
            this.onewayButton.AutoSize = true;
            this.onewayButton.BackColor = System.Drawing.Color.Transparent;
            this.onewayButton.Checked = true;
            this.onewayButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onewayButton.ForeColor = System.Drawing.Color.White;
            this.onewayButton.Location = new System.Drawing.Point(11, 25);
            this.onewayButton.Margin = new System.Windows.Forms.Padding(4);
            this.onewayButton.Name = "onewayButton";
            this.onewayButton.Size = new System.Drawing.Size(105, 23);
            this.onewayButton.TabIndex = 1;
            this.onewayButton.TabStop = true;
            this.onewayButton.Text = "One Way";
            this.onewayButton.UseVisualStyleBackColor = false;
            this.onewayButton.CheckedChanged += new System.EventHandler(this.onewayButton_CheckedChanged);
            // 
            // originBox
            // 
            this.originBox.BackColor = System.Drawing.Color.White;
            this.originBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.originBox.FormattingEnabled = true;
            this.originBox.Location = new System.Drawing.Point(348, 238);
            this.originBox.Margin = new System.Windows.Forms.Padding(4);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(130, 27);
            this.originBox.TabIndex = 3;
            this.originBox.Text = "Egypt";
            // 
            // originLable
            // 
            this.originLable.AutoSize = true;
            this.originLable.BackColor = System.Drawing.Color.Transparent;
            this.originLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originLable.ForeColor = System.Drawing.Color.White;
            this.originLable.Location = new System.Drawing.Point(345, 218);
            this.originLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originLable.Name = "originLable";
            this.originLable.Size = new System.Drawing.Size(57, 19);
            this.originLable.TabIndex = 4;
            this.originLable.Text = "Origin";
            // 
            // destinationLable
            // 
            this.destinationLable.AutoSize = true;
            this.destinationLable.BackColor = System.Drawing.Color.Transparent;
            this.destinationLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLable.ForeColor = System.Drawing.Color.White;
            this.destinationLable.Location = new System.Drawing.Point(513, 217);
            this.destinationLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destinationLable.Name = "destinationLable";
            this.destinationLable.Size = new System.Drawing.Size(103, 19);
            this.destinationLable.TabIndex = 5;
            this.destinationLable.Text = "Destination";
            // 
            // destinationBox
            // 
            this.destinationBox.BackColor = System.Drawing.Color.White;
            this.destinationBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(517, 237);
            this.destinationBox.Margin = new System.Windows.Forms.Padding(4);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(130, 27);
            this.destinationBox.TabIndex = 6;
            this.destinationBox.Text = "America";
            // 
            // departureLable
            // 
            this.departureLable.AutoSize = true;
            this.departureLable.BackColor = System.Drawing.Color.Transparent;
            this.departureLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLable.ForeColor = System.Drawing.Color.White;
            this.departureLable.Location = new System.Drawing.Point(17, 280);
            this.departureLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departureLable.Name = "departureLable";
            this.departureLable.Size = new System.Drawing.Size(157, 19);
            this.departureLable.TabIndex = 7;
            this.departureLable.Text = "Departure Date : ";
            // 
            // depDayBox
            // 
            this.depDayBox.BackColor = System.Drawing.Color.White;
            this.depDayBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.depDayBox.FormattingEnabled = true;
            this.depDayBox.Location = new System.Drawing.Point(71, 305);
            this.depDayBox.Margin = new System.Windows.Forms.Padding(2);
            this.depDayBox.Name = "depDayBox";
            this.depDayBox.Size = new System.Drawing.Size(66, 27);
            this.depDayBox.TabIndex = 8;
            this.depDayBox.Text = "1";
            // 
            // depMonthBox
            // 
            this.depMonthBox.BackColor = System.Drawing.Color.White;
            this.depMonthBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.depMonthBox.FormattingEnabled = true;
            this.depMonthBox.Location = new System.Drawing.Point(234, 305);
            this.depMonthBox.Margin = new System.Windows.Forms.Padding(2);
            this.depMonthBox.Name = "depMonthBox";
            this.depMonthBox.Size = new System.Drawing.Size(66, 27);
            this.depMonthBox.TabIndex = 9;
            this.depMonthBox.Text = "1";
            // 
            // returnLable
            // 
            this.returnLable.AutoSize = true;
            this.returnLable.BackColor = System.Drawing.Color.Transparent;
            this.returnLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLable.ForeColor = System.Drawing.Color.White;
            this.returnLable.Location = new System.Drawing.Point(345, 280);
            this.returnLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returnLable.Name = "returnLable";
            this.returnLable.Size = new System.Drawing.Size(123, 19);
            this.returnLable.TabIndex = 10;
            this.returnLable.Text = "Return Date :";
            this.returnLable.Visible = false;
            // 
            // returnDayBox
            // 
            this.returnDayBox.BackColor = System.Drawing.Color.White;
            this.returnDayBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.returnDayBox.FormattingEnabled = true;
            this.returnDayBox.Location = new System.Drawing.Point(403, 305);
            this.returnDayBox.Margin = new System.Windows.Forms.Padding(2);
            this.returnDayBox.Name = "returnDayBox";
            this.returnDayBox.Size = new System.Drawing.Size(66, 27);
            this.returnDayBox.TabIndex = 11;
            this.returnDayBox.Text = "1";
            this.returnDayBox.Visible = false;
            // 
            // returnMonthBox
            // 
            this.returnMonthBox.BackColor = System.Drawing.Color.White;
            this.returnMonthBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.returnMonthBox.FormattingEnabled = true;
            this.returnMonthBox.Location = new System.Drawing.Point(581, 305);
            this.returnMonthBox.Margin = new System.Windows.Forms.Padding(2);
            this.returnMonthBox.Name = "returnMonthBox";
            this.returnMonthBox.Size = new System.Drawing.Size(66, 27);
            this.returnMonthBox.TabIndex = 12;
            this.returnMonthBox.Text = "1";
            this.returnMonthBox.Visible = false;
            // 
            // depDayLable
            // 
            this.depDayLable.AutoSize = true;
            this.depDayLable.BackColor = System.Drawing.Color.Transparent;
            this.depDayLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDayLable.ForeColor = System.Drawing.Color.White;
            this.depDayLable.Location = new System.Drawing.Point(17, 305);
            this.depDayLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depDayLable.Name = "depDayLable";
            this.depDayLable.Size = new System.Drawing.Size(41, 19);
            this.depDayLable.TabIndex = 13;
            this.depDayLable.Text = "Day";
            // 
            // depMonthLable
            // 
            this.depMonthLable.AutoSize = true;
            this.depMonthLable.BackColor = System.Drawing.Color.Transparent;
            this.depMonthLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depMonthLable.ForeColor = System.Drawing.Color.White;
            this.depMonthLable.Location = new System.Drawing.Point(162, 305);
            this.depMonthLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depMonthLable.Name = "depMonthLable";
            this.depMonthLable.Size = new System.Drawing.Size(61, 19);
            this.depMonthLable.TabIndex = 14;
            this.depMonthLable.Text = "Month";
            // 
            // returnDayLable
            // 
            this.returnDayLable.AutoSize = true;
            this.returnDayLable.BackColor = System.Drawing.Color.Transparent;
            this.returnDayLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDayLable.ForeColor = System.Drawing.Color.White;
            this.returnDayLable.Location = new System.Drawing.Point(348, 305);
            this.returnDayLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returnDayLable.Name = "returnDayLable";
            this.returnDayLable.Size = new System.Drawing.Size(41, 19);
            this.returnDayLable.TabIndex = 15;
            this.returnDayLable.Text = "Day";
            this.returnDayLable.Visible = false;
            // 
            // returnMonthLable
            // 
            this.returnMonthLable.AutoSize = true;
            this.returnMonthLable.BackColor = System.Drawing.Color.Transparent;
            this.returnMonthLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMonthLable.ForeColor = System.Drawing.Color.White;
            this.returnMonthLable.Location = new System.Drawing.Point(501, 305);
            this.returnMonthLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returnMonthLable.Name = "returnMonthLable";
            this.returnMonthLable.Size = new System.Drawing.Size(61, 19);
            this.returnMonthLable.TabIndex = 16;
            this.returnMonthLable.Text = "Month";
            this.returnMonthLable.Visible = false;
            // 
            // adultButton
            // 
            this.adultButton.AutoSize = true;
            this.adultButton.Checked = true;
            this.adultButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultButton.ForeColor = System.Drawing.Color.White;
            this.adultButton.Location = new System.Drawing.Point(4, 21);
            this.adultButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.adultButton.Name = "adultButton";
            this.adultButton.Size = new System.Drawing.Size(187, 23);
            this.adultButton.TabIndex = 21;
            this.adultButton.TabStop = true;
            this.adultButton.Text = "Adult ( 16+ years)";
            this.adultButton.UseVisualStyleBackColor = true;
            // 
            // childButton
            // 
            this.childButton.AutoSize = true;
            this.childButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childButton.ForeColor = System.Drawing.Color.White;
            this.childButton.Location = new System.Drawing.Point(195, 21);
            this.childButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.childButton.Name = "childButton";
            this.childButton.Size = new System.Drawing.Size(222, 23);
            this.childButton.TabIndex = 22;
            this.childButton.TabStop = true;
            this.childButton.Text = "Childreen (0-15 years)";
            this.childButton.UseVisualStyleBackColor = true;
            // 
            // travellersLable
            // 
            this.travellersLable.BackColor = System.Drawing.Color.Transparent;
            this.travellersLable.Controls.Add(this.adultButton);
            this.travellersLable.Controls.Add(this.childButton);
            this.travellersLable.ForeColor = System.Drawing.Color.White;
            this.travellersLable.Location = new System.Drawing.Point(27, 361);
            this.travellersLable.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.travellersLable.Name = "travellersLable";
            this.travellersLable.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.travellersLable.Size = new System.Drawing.Size(427, 52);
            this.travellersLable.TabIndex = 24;
            this.travellersLable.TabStop = false;
            this.travellersLable.Text = "Travellers";
            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.Color.MidnightBlue;
            this.finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish.ForeColor = System.Drawing.Color.White;
            this.finish.Location = new System.Drawing.Point(544, 373);
            this.finish.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(103, 40);
            this.finish.TabIndex = 26;
            this.finish.Text = "finish";
            this.finish.UseVisualStyleBackColor = false;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // airflightLable
            // 
            this.airflightLable.AutoSize = true;
            this.airflightLable.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.airflightLable.ForeColor = System.Drawing.Color.White;
            this.airflightLable.Location = new System.Drawing.Point(224, 9);
            this.airflightLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.airflightLable.Name = "airflightLable";
            this.airflightLable.Size = new System.Drawing.Size(202, 58);
            this.airflightLable.TabIndex = 27;
            this.airflightLable.Text = "Air Flight";
            // 
            // tickettypeGroup
            // 
            this.tickettypeGroup.BackColor = System.Drawing.Color.Transparent;
            this.tickettypeGroup.Controls.Add(this.returnButton);
            this.tickettypeGroup.Controls.Add(this.onewayButton);
            this.tickettypeGroup.ForeColor = System.Drawing.Color.White;
            this.tickettypeGroup.Location = new System.Drawing.Point(16, 209);
            this.tickettypeGroup.Name = "tickettypeGroup";
            this.tickettypeGroup.Size = new System.Drawing.Size(284, 55);
            this.tickettypeGroup.TabIndex = 28;
            this.tickettypeGroup.TabStop = false;
            this.tickettypeGroup.Text = "Choose Your Type :";
            // 
            // photoplane
            // 
            this.photoplane.Image = global::Tickety.Properties.Resources.images__7_;
            this.photoplane.Location = new System.Drawing.Point(185, 70);
            this.photoplane.Name = "photoplane";
            this.photoplane.Size = new System.Drawing.Size(293, 107);
            this.photoplane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoplane.TabIndex = 30;
            this.photoplane.TabStop = false;
            // 
            // pair
            // 
            this.pair.Image = ((System.Drawing.Image)(resources.GetObject("pair.Image")));
            this.pair.Location = new System.Drawing.Point(16, 9);
            this.pair.Margin = new System.Windows.Forms.Padding(2);
            this.pair.Name = "pair";
            this.pair.Size = new System.Drawing.Size(69, 65);
            this.pair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pair.TabIndex = 8;
            this.pair.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.AliceBlue;
            this.exit.Location = new System.Drawing.Point(627, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 23);
            this.exit.TabIndex = 31;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Air_flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(667, 437);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.photoplane);
            this.Controls.Add(this.pair);
            this.Controls.Add(this.tickettypeGroup);
            this.Controls.Add(this.airflightLable);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.travellersLable);
            this.Controls.Add(this.returnMonthLable);
            this.Controls.Add(this.returnDayLable);
            this.Controls.Add(this.depMonthLable);
            this.Controls.Add(this.depDayLable);
            this.Controls.Add(this.returnMonthBox);
            this.Controls.Add(this.returnDayBox);
            this.Controls.Add(this.returnLable);
            this.Controls.Add(this.depMonthBox);
            this.Controls.Add(this.depDayBox);
            this.Controls.Add(this.departureLable);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.destinationLable);
            this.Controls.Add(this.originLable);
            this.Controls.Add(this.originBox);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Air_flights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.travellersLable.ResumeLayout(false);
            this.travellersLable.PerformLayout();
            this.tickettypeGroup.ResumeLayout(false);
            this.tickettypeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoplane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton returnButton;
        private System.Windows.Forms.RadioButton onewayButton;
        private System.Windows.Forms.ComboBox originBox;
        private System.Windows.Forms.Label originLable;
        private System.Windows.Forms.Label destinationLable;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.Label departureLable;
        private System.Windows.Forms.ComboBox depDayBox;
        private System.Windows.Forms.ComboBox depMonthBox;
        private System.Windows.Forms.Label returnLable;
        private System.Windows.Forms.ComboBox returnDayBox;
        private System.Windows.Forms.ComboBox returnMonthBox;
        private System.Windows.Forms.Label depDayLable;
        private System.Windows.Forms.Label depMonthLable;
        private System.Windows.Forms.Label returnDayLable;
        private System.Windows.Forms.Label returnMonthLable;
        private System.Windows.Forms.RadioButton adultButton;
        private System.Windows.Forms.RadioButton childButton;
        private System.Windows.Forms.GroupBox travellersLable;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Label airflightLable;
        private System.Windows.Forms.GroupBox tickettypeGroup;
        private System.Windows.Forms.PictureBox pair;
        private System.Windows.Forms.PictureBox photoplane;
        private System.Windows.Forms.Button exit;
    }
}

