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
    public partial class register : Form
    {
        
       
        public register()
        {
            InitializeComponent();
        }

        private void Finish_register_Click(object sender, EventArgs e)
        {
            cregister re = new cregister();
            //make sure that all data is vaild 
            if(!re.name(bname.Text))
            {
                checkname.Visible = true;
            }
            else
            {
                checkname.Visible = false;
            }
            if (!re.age(int.Parse(bage.Text)))
            {
                checkage.Visible = true;
            }
            else
            {
                checkage.Visible = false;
            }
            if (!re.mobile_num(bmobnum.Text))
            {
                checkmob.Visible = true;
            }
            else
            {
                checkmob.Visible = false;
            }
            if (!re.national_Id(bnationalid.Text))
            {
                checknationalid.Visible = true;
            }
            else
            {
                checknationalid.Visible = false;
            }
            if (!re.password(bpassword.Text))
            {
                checkpassword.Visible = true;
            }
            else
            {
                checkpassword.Visible = false;
            }
            //if all data is valid then starts to store them
            if(re.name(bname.Text)&& re.password(bpassword.Text)&& re.national_Id(bnationalid.Text)&& re.mobile_num(bmobnum.Text)&& re.age(int.Parse(bage.Text)))
            {
                checkname.Visible = false;
                checkage.Visible = false;
                checkmob.Visible = false;
                checknationalid.Visible = false;
                checkpassword.Visible = false;
                filing_data savedata = new filing_data();
                filing_orders s = new filing_orders();
                savedata.save(bname.Text, bpassword.Text, bnationalid.Text);
                //generate id for the new user
                s.creat(savedata.countlines("id.txt"));
                //show the login information
                 MessageBox.Show("Your ID to login is : "+ savedata.countlines("id.txt") + "\n"+"Your Password Is : "+ bpassword.Text);
                
                this.Hide();
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
