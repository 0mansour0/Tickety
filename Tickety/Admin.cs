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
    public partial class Admin : Form
    {
        DataTable table = new DataTable();
        public Admin()
        {
            InitializeComponent();
            //add the columns head
            table.Columns.Add("No", typeof(string));
            table.Columns.Add("Serial Number", typeof(string));
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(string));
            showdata.DataSource = table;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //get orders from file 
            string[] lines = File.ReadAllLines("allorders.txt");
            string[] split;
            //split them and store them into array
            for (int i = 0; i < lines.Length; i++)
            {
                split = lines[i].ToString().Split(':');
                string[] row = new string[split.Length];
                for(int j=0;j<split.Length;j++)
                {
                    row[j] = split[j].Trim();
                }
                //insirt rows
                table.Rows.Add(row);
            }
            
        }
    }
}
