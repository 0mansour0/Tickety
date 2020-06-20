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
    public partial class Hotels : Form
    {
        
        public Hotels()
        {
            InitializeComponent();
        }
        private void done_Click(object sender, EventArgs e)
        {
            //calculate the price
            int price = 0;
             int day = 0;
             string item = "";
             string food = "";
             day = int.Parse(daysBox.Text);
            if (bsingle.Checked==true)
            {
                item = "Single";
                price += (day * 200);
            }
            if (bdouble.Checked == true)
            {
                item = "Double";
                price += (day * 400);
            }
            if (bmulti.Checked == true)
            {
                item = "Multiple";
                price += (day * 600);
            }
            if (bfamily.Checked == true)
            {
                item = "Family";
                price += (day * 800);
            }
            if (fullra.Checked)
            {
                price = price + 500;
                food = fullra.Text;
            }
            else if (halfra.Checked)
            {
                price = price + 250;
                food = halfra.Text;
            }
            else
            {
                price = price + 100;
                food = snacksra.Text;
            }
            //generate random number for serial number
            Random rnd = new Random();
            int ser = rnd.Next(200000000, 300000000);
            General g = new General();
            filing_orders f = new filing_orders();
            //get available rooms 
            login l = new login();
            int t = int.Parse(File.ReadAllText("lh.txt"));
            //if there are available tickets store the data
            if (t > 0)
            {
                f.save_orders(l.activeid, ser, "Hotel", price);
                f.allorders(l.activeid, ser, "Hotel", price);
                //reduce avaiable tickets
                File.WriteAllText("lh.txt", Convert.ToString(t-1));
                //show the bill
                MessageBox.Show("Num of Days : " + day + "\nSelected room : " + item + "\nSelected Meals : " + food + "\nPrice : " + price + "\nYour Ticket Serial Number Is : " + ser);
                this.Hide();
            }
            //if the tickets sold out then the order added to waiting list
            else
            {
                f.watinglist(l.activeid, ser, "Hotel", price);
                MessageBox.Show("All Rooms Booked But you are in watting list now");
                this.Hide();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

