namespace Tickety
{
    partial class Admin
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
            this.manger = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.showdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).BeginInit();
            this.SuspendLayout();
            // 
            // manger
            // 
            this.manger.AutoSize = true;
            this.manger.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.manger.Location = new System.Drawing.Point(46, 9);
            this.manger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manger.Name = "manger";
            this.manger.Size = new System.Drawing.Size(227, 33);
            this.manger.TabIndex = 32;
            this.manger.Text = "Welcome Manager";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(652, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 28);
            this.exit.TabIndex = 33;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // showdata
            // 
            this.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdata.Location = new System.Drawing.Point(52, 59);
            this.showdata.Name = "showdata";
            this.showdata.ReadOnly = true;
            this.showdata.RowHeadersWidth = 51;
            this.showdata.RowTemplate.Height = 26;
            this.showdata.Size = new System.Drawing.Size(602, 348);
            this.showdata.TabIndex = 34;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.manger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label manger;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView showdata;
    }
}