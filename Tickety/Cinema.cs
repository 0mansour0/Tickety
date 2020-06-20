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
    public partial class Cinema : Form
    {

        public Cinema()
        {
            InitializeComponent();
            vipTicketsBox.Text = "0";
            normalTicketsBox.Text = "0";
            tm3.Checked=true;
            vip.Checked = true;
            movie1Button.Checked = true ;
        }


        private void result_Click(object sender, EventArgs e)
        { 
            //calculate the price
            int price = 0;
            int x = 0;
            string tx=tm2.Text;
            if (vip.Checked == true)
            {
                price += (100*int.Parse(vipTicketsBox.Text));
                x += int.Parse(vipTicketsBox.Text);

            }
            if (normal.Checked == true)
            {
                price += (65 * int.Parse(normalTicketsBox.Text));
                x += int.Parse(normalTicketsBox.Text);
            }

            // get the time
            if (tm3.Checked == true)
            {

                tx = tm3.Text;

            }
            else if (tm4.Checked == true)
            {
                tx = tm4.Text;
            }
            else if (tm1.Checked == true)
            {
                tx = tm1.Text;
            }
            else if (tm2.Checked == true)
            {
                tx = tm2.Text;
            }

            //generate random number for serial number
            Random rnd = new Random();
            int ser = rnd.Next(200000000, 300000000);
            General g = new General();
            filing_orders f = new filing_orders();
            //get available tickets 
            login l = new login();
            int t = int.Parse(File.ReadAllText("lci.txt"));
            //check the limit of tickets
            if (g.limit_Ticket(x))
            {
                //check if the available tickets coverd the requried tickets
                if (x <= t)
                {
                    //show the bill
                    MessageBox.Show("Total price is: " + price  + "\n time : " + tx + "\n number of tickets : " + x + "\nYour Ticket Serial Number Is : " + ser);
                    //store the order
                    f.save_orders(l.activeid, ser, "Cinema", price);
                    f.allorders(l.activeid, ser, "Cinema", price);
                    //reduce avaiable tickets
                    File.WriteAllText("lci.txt", Convert.ToString(t - x));
                    this.Hide();
                }
                //if the tickets sold out then the order added to waiting list
                else
                {
                    f.watinglist(l.activeid, ser, "Cinema", price);
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
        //show reviews for the movies
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Review_me m = new Review_me();
            m.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Review_moun m = new Review_moun();
            m.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Review_meg m = new Review_meg();
            m.Show();
        }
    }
}
