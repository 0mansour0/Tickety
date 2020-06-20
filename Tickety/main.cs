using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tickety

{
    public partial class main : Form
    {
        public bool visa_information=false;
        public main()
        {
            InitializeComponent();
            //initialize layout for objects
            logo.BackColor = Color.FromArgb(46, 41, 78);
            all_service.BackColor = Color.FromArgb(46, 41, 78);
            payment_method.BackColor= Color.FromArgb(46, 41, 78); 
            waitinglist.BackColor = Color.FromArgb(46, 41, 78);
            myorders.BackColor = Color.FromArgb(46, 41, 78);
            year.Text = "2020";
            month.Text = "1";
            
            for (int i=2020;i<2026;i++)
            {
                year.Items.Add(i);
            }

            for(int i=1;i<13;i++)
            {
                month.Items.Add(i);
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void All_service_Click(object sender, EventArgs e)
        {
            try
            {
                //check that user entered his visa information
                login l = new login();
                string line = File.ReadLines("visainformation.txt").Skip(l.activeid - 1).Take(1).First();

                    visa_information = true;
            }
            catch
            {

            }
            timer2.Start();
            //make everything except service invisible 
            pictureBox8.Visible = false;
            showorders.Visible = false;
            visa_photo.Visible = false;
            card_num.Visible = false;
            showwaitinglist.Visible = false;
            name_holder.Visible = false;
            year.Visible = false;
            month.Visible = false;
            nameofcardholder.Visible = false;
            cardnumber.Visible = false;
            yearofcard.Visible = false;
            monthofcard.Visible = false;
            submit_visa.Visible = false;
        }
        //motion for form showing 
        private void Timer1_Tick(object sender, EventArgs e)
        {
            double x = 0.5;
            if(this.Opacity<=0.95)
            {
                this.Opacity += x;
            }
            else if(this.Opacity+x>0.95)
            {
                timer1.Stop();
            }
        }
        //motion for icons showing 
        private void Timer2_Tick(object sender, EventArgs e)
        {
            pfootball.Visible = true;
            label1.Visible = true;
            timer2.Stop();
            timer3.Start();
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            pparty.Visible = true;
            label2.Visible = true;
            timer3.Stop();
            timer4.Start();
        }
        private void Timer4_Tick(object sender, EventArgs e)
        {
            pcinema.Visible = true;
            label4.Visible = true;
            timer4.Stop();
            timer5.Start();
        }
        private void Timer5_Tick(object sender, EventArgs e)
        {
            photel.Visible = true;
            label5.Visible = true;
            timer5.Stop();
            timer6.Start();
        }
        private void Timer6_Tick(object sender, EventArgs e)
        {
            pair.Visible = true;
            label3.Visible = true;
            timer6.Stop();
        }
        private void Payment_method_Click(object sender, EventArgs e)
        {
            //make everything except payment method invisible 
            showorders.Visible = false;
            pictureBox8.Visible = false;
            pfootball.Visible = false;
            label1.Visible = false;
            pair.Visible = false;
            label2.Visible = false;
            pparty.Visible = false;
            label3.Visible = false;
            pcinema.Visible = false;
            label4.Visible = false;
            photel.Visible = false;
            label5.Visible = false;
            showwaitinglist.Visible = false;
            timer7.Start();   
        }
        //motion for payment method objects
        private void Timer7_Tick(object sender, EventArgs e)
        {
            visa_photo.Visible = true;
            timer7.Stop();
            timer8.Start();
        }
        private void Timer8_Tick(object sender, EventArgs e)
        {
            name_holder.Visible = true;
            card_num.Visible = true;
            year.Visible = true;
            month.Visible = true;
            nameofcardholder.Visible = true;
            cardnumber.Visible = true;
            yearofcard.Visible = true;
            monthofcard.Visible = true;
            submit_visa.Visible = true;
            timer8.Stop();
        }

        private void Submit_visa_Click(object sender, EventArgs e)
        {
            General g = new General();
            filing_data f = new filing_data();
            //check that the visa information is valid
            if (g.visainformation(name_holder.Text,card_num.Text))
            {
                MessageBox.Show("Thank You ,Now You Can Book Your Tickets");
                f.visainformation(card_num.Text);
            }
           else
            {
                MessageBox.Show("Sorry, There is Wrong in Your Information Please Try Again");
            }
        }
        //if the user entered his visa information open selected service
        private void pfootball_Click(object sender, EventArgs e)
        {
            if(visa_information==false)
            {
                MessageBox.Show("Enter Your Payment Method First");
            }
            else
            {
                Football f = new Football();
                f.Show();
            }
        }

        private void pair_Click(object sender, EventArgs e)
        {
            if (visa_information == false)
            {
                MessageBox.Show("Enter Your Payment Method First");
            }
            else
            {
                Air_flights f = new Air_flights();
                f.Show();
            }
        }

        private void photel_Click(object sender, EventArgs e)
        {
             if (visa_information == false)
             {
                 MessageBox.Show("Enter Your Payment Method First");
             }
             else
            {
                Hotels h = new Hotels();
                h.Show();
            }

        }

        private void pcinema_Click(object sender, EventArgs e)
        {
            if (visa_information == false)
            {
                MessageBox.Show("Enter Your Payment Method First");
            }
            else
            {
                Cinema c = new Cinema();
                c.Show();
            }
        }

        private void pparty_Click(object sender, EventArgs e)
        {
            if (visa_information == false)
            {
                MessageBox.Show("Enter Your Payment Method First");
            }
            else
            {
                Concert c = new Concert();
                c.Show();
            }
        }

        private void Myorders_Click(object sender, EventArgs e)
        {
            //make everything except user order invisible 
            showorders.Visible = true;
            pfootball.Visible = false;
            label1.Visible = false;
            pair.Visible = false;
            label2.Visible = false;
            pparty.Visible = false;
            label3.Visible = false;
            pcinema.Visible = false;
            label4.Visible = false;
            photel.Visible = false;
            label5.Visible = false;
            pictureBox8.Visible = false;
            visa_photo.Visible = false;
            card_num.Visible = false;
            name_holder.Visible = false;
            year.Visible = false;
            month.Visible = false;
            nameofcardholder.Visible = false;
            cardnumber.Visible = false;
            yearofcard.Visible = false;
            monthofcard.Visible = false;
            submit_visa.Visible = false;
            showwaitinglist.Visible = false;
            login l = new login();
            //get the path of this user file
            string pathor = "id" +l.activeid + ".txt";
            DataTable table = new DataTable();
            //add the columns head
            table.Columns.Add("No", typeof(string));
            table.Columns.Add("Serial Number", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(string));
            showorders.DataSource = table;
            //get orders from file 
            string[] lines = File.ReadAllLines(pathor);
            string[] split;
            //split them and store them into array
            for (int i = 0; i < lines.Length; i++)
            {
                split = lines[i].ToString().Split(':');
                string[] row = new string[split.Length];
                for (int j = 0; j < split.Length; j++)
                {
                    row[j] = split[j].Trim();
                }
                //insirt rows
                table.Rows.Add(row);
            }
        }

        private void Waitinglist_Click(object sender, EventArgs e)
        {
            //make everything except waiting list invisible 
            showorders.Visible = false;
            pfootball.Visible = false;
            label1.Visible = false;
            pair.Visible = false;
            label2.Visible = false;
            pparty.Visible = false;
            label3.Visible = false;
            pcinema.Visible = false;
            label4.Visible = false;
            photel.Visible = false;
            label5.Visible = false;
            pictureBox8.Visible = false;
            visa_photo.Visible = false;
            card_num.Visible = false;
            name_holder.Visible = false;
            year.Visible = false;
            month.Visible = false;
            nameofcardholder.Visible = false;
            cardnumber.Visible = false;
            yearofcard.Visible = false;
            monthofcard.Visible = false;
            submit_visa.Visible = false;
            showwaitinglist.Visible = true;
            DataTable table = new DataTable();
            //add the columns head
            table.Columns.Add("No", typeof(string));
            table.Columns.Add("Serial Number", typeof(string));
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(string));
            showwaitinglist.DataSource = table;
            //get orders from file 
            string[] lines = File.ReadAllLines("waitinglist.txt");
            string[] split;
            //split them and store them into array
            for (int i = 0; i < lines.Length; i++)
            {
                split = lines[i].ToString().Split(':');
                string[] row = new string[split.Length];
                for (int j = 0; j < split.Length; j++)
                {
                    row[j] = split[j].Trim();
                }
                //insirt rows
                table.Rows.Add(row);
            }
        }
    }
}
