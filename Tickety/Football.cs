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
    public partial class Football : Form
    {
        public Football()
        {
            InitializeComponent();

        }


        private void finish_Click(object sender, EventArgs e)
        {
            //calculate the price
            int price = 0;
            int ticket = 0;
            string match = "";
            if (firstmatch.Checked)
            {
                match = firstmatch.Text;
            }
            else if (secondmatch.Checked)
            {
                match = secondmatch.Text;
            }
            else if (thirdmatch.Checked)
            {
                match = thirdmatch.Text;
            }
            if (vvipbutton.Checked == true)
            {
                price += (300 * int.Parse(ticket1Box.Text));
                ticket += int.Parse(ticket1Box.Text);
            }
            if (vipbutton.Checked == true)
            {
                price += (200 * int.Parse(ticket2Box.Text));
                ticket += int.Parse(ticket2Box.Text);
            }
            if (cat1rbutton.Checked == true)
            {
                price += (100 * int.Parse(ticket3Box.Text));
                ticket += int.Parse(ticket3Box.Text);
            }
            if (cat1lbutton.Checked == true)
            {
                price += (100 * int.Parse(ticket4Box.Text));
                ticket += int.Parse(ticket4Box.Text);
            }
            if (cat2button.Checked == true)
            {
                price += (75 * int.Parse(ticket5Box.Text));
                ticket += int.Parse(ticket5Box.Text);
            }
            if (cat3button.Checked == true)
            {
                price += (50 * int.Parse(ticket6Box.Text));
                ticket += int.Parse(ticket6Box.Text);
            }
            if (cat3lbutton.Checked == true)
            {
                price += (50 * int.Parse(ticket7Box.Text));
                ticket += int.Parse(ticket7Box.Text);
            }
            //generate random number for serial number
            Random rnd = new Random();
            int ser = rnd.Next(200000000, 300000000);
            General g = new General();
            filing_orders f = new filing_orders();
            //get available tickets
            login l = new login();
            int t = int.Parse(File.ReadAllText("lf.txt"));
            //check the limit of tickets
            if (g.limit_Ticket(ticket))
            {
                //check if the available tickets coverd the requried tickets
                if (ticket<=t)
                {
                    //show the bill
                    MessageBox.Show("Selected Match : " + match + "\n Num of Tickets : " + ticket + "  \n price : " + price + "\nYour Ticket Serial Number Is : " + ser);
                    //store the order
                    f.save_orders(l.activeid, ser, "Foot Ball", price);
                    f.allorders(l.activeid, ser, "Foot Ball", price);
                    //reduce avaiable tickets
                    File.WriteAllText("lf.txt", Convert.ToString(t - ticket));
                    this.Hide();
                }
                //if the tickets sold out then the order added to waiting list
                else
                {
                    f.watinglist(l.activeid, ser, "Foot Ball", price);
                    MessageBox.Show("All Tickets Sold out But you are in watting list now");
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("You can Book Only 7 Tickets");
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
