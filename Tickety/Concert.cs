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
    public partial class Concert : Form
    {

        public Concert()
        {
            InitializeComponent();
        }
        //details about concerts
        private void picbox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the concert is on sunday at 8");
        }

        private void picbox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the concert is on monday 9");

        }

        private void picbox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the concert is on friday 6");

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            //calculate the price
            int total =0;
            int ticketno = 0;
            if (vipButton.Checked==true)
            {
                total += (200 * int.Parse(vipticketBox.Text));
                ticketno += int.Parse(vipticketBox.Text);
            }
            if (normalButton.Checked == true)
            {
                total += (100 * int.Parse(normalticketBox.Text));
                ticketno += int.Parse(normalticketBox.Text);
            }
            //generate random number for serial number
            Random rnd = new Random();
            int ser = rnd.Next(200000000, 300000000);
            General g = new General();
            filing_orders f = new filing_orders();
            //get available tickets 
            login l = new login();
            int t = int.Parse(File.ReadAllText("lco.txt"));
            //check the limit of tickets
            if (g.limit_Ticket(ticketno))
            {
                //check if the available tickets coverd the requried tickets
                if (ticketno <= t)
                {
                    //store the order
                    f.save_orders(l.activeid, ser, "Concert", total);
                    f.allorders(l.activeid, ser, "Concert", total);
                    //reduce avaiable tickets
                    File.WriteAllText("lco.txt", Convert.ToString(t - ticketno));
                    //show the bill
                    MessageBox.Show("Your Concert is : "+concertBox.Text+"\nNumber of Tickets : "+ticketno+"\n Total Price : "+Convert.ToString(total) + "\nYour Ticket Serial Number Is : " + ser);
                    this.Hide();
                }
                //if the tickets sold out then the order added to waiting list
                else
                {
                    f.watinglist(l.activeid, ser, "Concert", total);
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
