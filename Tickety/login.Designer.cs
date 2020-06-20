namespace Tickety
{
    partial class login
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
            this.id = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.teid = new System.Windows.Forms.TextBox();
            this.tepass = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.LinkLabel();
            this.finish_login = new System.Windows.Forms.Button();
            this.checkinformation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomLabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.id.Location = new System.Drawing.Point(46, 123);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(37, 19);
            this.id.TabIndex = 0;
            this.id.Text = "ID :";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.password.Location = new System.Drawing.Point(46, 174);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(93, 19);
            this.password.TabIndex = 1;
            this.password.Text = "Password :";
            // 
            // teid
            // 
            this.teid.Location = new System.Drawing.Point(157, 123);
            this.teid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teid.Name = "teid";
            this.teid.Size = new System.Drawing.Size(88, 24);
            this.teid.TabIndex = 2;
            // 
            // tepass
            // 
            this.tepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tepass.Location = new System.Drawing.Point(157, 174);
            this.tepass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tepass.Name = "tepass";
            this.tepass.PasswordChar = '*';
            this.tepass.Size = new System.Drawing.Size(154, 22);
            this.tepass.TabIndex = 3;
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.register.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.register.Location = new System.Drawing.Point(184, 249);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(69, 19);
            this.register.TabIndex = 4;
            this.register.TabStop = true;
            this.register.Text = "Register";
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // finish_login
            // 
            this.finish_login.BackColor = System.Drawing.Color.SteelBlue;
            this.finish_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish_login.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.finish_login.ForeColor = System.Drawing.Color.Snow;
            this.finish_login.Location = new System.Drawing.Point(330, 220);
            this.finish_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finish_login.Name = "finish_login";
            this.finish_login.Size = new System.Drawing.Size(66, 38);
            this.finish_login.TabIndex = 5;
            this.finish_login.Text = "Login";
            this.finish_login.UseVisualStyleBackColor = false;
            this.finish_login.Click += new System.EventHandler(this.Finish_login_Click);
            // 
            // checkinformation
            // 
            this.checkinformation.AutoSize = true;
            this.checkinformation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.checkinformation.ForeColor = System.Drawing.Color.Crimson;
            this.checkinformation.Location = new System.Drawing.Point(119, 210);
            this.checkinformation.Name = "checkinformation";
            this.checkinformation.Size = new System.Drawing.Size(196, 19);
            this.checkinformation.TabIndex = 6;
            this.checkinformation.Text = "*Check Your Information";
            this.checkinformation.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tickety.Properties.Resources.d;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.welcomLabel.Location = new System.Drawing.Point(137, 41);
            this.welcomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(231, 33);
            this.welcomLabel.TabIndex = 9;
            this.welcomLabel.Text = "Welcome to Tickety";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(383, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 28);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(428, 290);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.welcomLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkinformation);
            this.Controls.Add(this.finish_login);
            this.Controls.Add(this.register);
            this.Controls.Add(this.tepass);
            this.Controls.Add(this.teid);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox teid;
        private System.Windows.Forms.TextBox tepass;
        private System.Windows.Forms.LinkLabel register;
        private System.Windows.Forms.Button finish_login;
        private System.Windows.Forms.Label checkinformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.Button exit;
    }
}