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
    public partial class Air_flights : Form
    {
        
        public Air_flights()
        {
            InitializeComponent();
            //adding data to boxs
            originBox.Items.Add("America");
            originBox.Items.Add("London");
            originBox.Items.Add("Egypt");
            originBox.Items.Add("Paris");
            originBox.Items.Add("Chicago");
            destinationBox.Items.Add("America");
            destinationBox.Items.Add("London");
            destinationBox.Items.Add("Egypt");
            destinationBox.Items.Add("Paris");
            destinationBox.Items.Add("Chicago");

            for (int i = 1; i <= 31; i++)
            {
                depDayBox.Items.Add(i);
                returnDayBox.Items.Add(i);

            }
            for (int i = 1; i <= 12; i++)
            {
                depMonthBox.Items.Add(i);
                returnMonthBox.Items.Add(i);

            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            //calculate the price
            int price = 0;
            if (onewayButton.Checked == true)
            {
                price += 4000;

            }
            else if (returnButton.Checked == true)
            {
                price += 6000;
            }
            if (adultButton.Checked == true)
            {
                price += 3000;

            }
            else if (childButton.Checked == true)
            {
                price += 1000;

            }
            //generate random number for serial number
            Random rnd = new Random();
            int ser = rnd.Next(200000000, 300000000);
            General g = new General();
            filing_orders f = new filing_orders();
            //get available tickets 
            login l = new login();
            int t = int.Parse(File.ReadAllText("la.txt"));
            //if there are available tickets store the data
            if (t > 0)
            {
                f.save_orders(l.activeid, ser, "Air Flight", price);
                f.allorders(l.activeid, ser, "Air Flight", price);
                //reduce avaiable tickets
                File.WriteAllText("la.txt", Convert.ToString(t - 1));
                //show the bill
                MessageBox.Show("Your Flight \nFrom : "+originBox.Text+" To : "+destinationBox.Text+"\nYour Ticket Cost : " + price+"\nYour Ticket Serial Number Is : "+ser);
                    this.Hide();
            }
            //if the tickets sold out then the order added to waiting list
            else
            {
                f.watinglist(l.activeid, ser, "Air Flight", price);
                MessageBox.Show("All Tickets Sold out But you are in watting list now");
                this.Hide();
            }
        }

        private void returnButton_CheckedChanged(object sender, EventArgs e)
        {
            returnDayLable.Visible = true;
            returnLable.Visible = true;
            returnMonthLable.Visible = true;
            returnDayBox.Visible = true;
            returnMonthBox.Visible = true;
        }

        private void onewayButton_CheckedChanged(object sender, EventArgs e)
        {
            returnDayLable.Visible = false;
            returnLable.Visible = false;
            returnMonthLable.Visible = false;
            returnDayBox.Visible = false;
            returnMonthBox.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
