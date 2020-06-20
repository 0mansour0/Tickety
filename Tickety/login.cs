using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tickety
{
    public partial class login : Form
    {
        public int activeid;
        public login()
        {
            InitializeComponent();
            //store the active user id
            activeid = int.Parse(File.ReadAllText("activeuser.txt"));
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register r = new register();
            r.Show();
        }
        private void Finish_login_Click(object sender, EventArgs e)
        {
            //check if that the manger or normal user
            try {
                if (teid.Text == "Admin" && tepass.Text == "Admin")
                {
                    //open the manger form
                    this.Hide();
                    Admin a = new Admin();
                    a.Show();
                }
                //get the password of this id
                string line = File.ReadLines("password.txt").Skip(int.Parse(teid.Text) - 1).Take(1).First();
               //comper the password that user enterd with the correct password
                if (line == tepass.Text)
                {
                    //open user form and store the active user ID
                    this.Hide();
                    main m = new main();
                    m.Show();
                    using (var user = new StreamWriter("activeuser.txt"))
                    {
                        user.WriteLine(teid.Text);
                        activeid =int.Parse( File.ReadAllText("activeuser.txt"));
                        user.Close();
                    }
                    
                    
                }
                else
                {
                    checkinformation.Visible = true;
                }
            }
            catch
            {
                checkinformation.Visible = true;
            }
            
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
