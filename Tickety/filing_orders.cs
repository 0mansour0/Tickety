using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tickety
{
    class filing_orders 
    {
        //creat file for this id to store orders in it
        public void creat (int id)
        {
            string orderpath = "id"+id + ".txt";
            if(!File.Exists(orderpath))
            {
                File.Create(orderpath).Close();
            }
        }
        //store the data for user in his file
        public void save_orders(int id,int sn,string ca,int p)
        {
            string orderpath = "id" + id + ".txt";
            int c = countlines(orderpath);
            StreamWriter save = new StreamWriter(orderpath, true);
            if (c==0)
                {
                    //make the counter of orders starts from 1
                    c++;
                }
            save.Write(c + ":");
            save.Write(sn + ":");
            if (ca=="Cinema")
                {
                    save.Write(ca + ":");
                }
               else if (ca == "Hotel")
                {
                    save.Write(ca + ":");
                }
               else if (ca == "Concert")
                {
                    save.Write(ca + ":");
                }
                else
                {
                        save.Write(ca + ":");
                }
                save.WriteLine(p);
                save.Close();
            
        }
        //store the order that being in waiting list
        public void watinglist(int id, int sn, string ca, int p)
        {
            string orderpath = "waitinglist.txt";
            int c = countlines(orderpath);
            StreamWriter save = new StreamWriter(orderpath, true);
            if (c == 0)
            {
                //make the counter of orders starts from 1
                c++;
            }
            save.Write(c + ":");
            save.Write(sn + ":");
            save.Write(id + ":");
            if (ca == "Cinema")
                {
                    save.Write(ca + ":");
                }
                else if (ca == "Hotel")
                {
                    save.Write(ca + ":");
                }
                else if (ca == "Concert")
                {
                    save.Write(ca + ":");
                }
                else
                {
                    save.Write(ca + ":");
                }
                save.WriteLine(p);
                save.Close();
            
        }
        //store all orders that ordered using this application
        public void allorders(int id, int sn, string ca, int p)
        {
            string orderpath = "allorders.txt";
            int c = countlines(orderpath);
            StreamWriter save = new StreamWriter(orderpath, true);
            if (c == 0)
            {
                //make the counter of orders starts from 1
                c++;
            }
            save.Write(c + ":");
            save.Write(sn + ":");
            save.Write(id + ":");
            if (ca == "Cinema")
            {
                save.Write(ca + ":");
            }
            else if (ca == "Hotel")
            {
                save.Write(ca + ":");
            }
            else if (ca == "Concert")
            {
                save.Write(ca + ":");
            }
            else
            {
                save.Write(ca + ":");
            }
            save.WriteLine(p);
            save.Close();

        }
        //count lines to number the orders
        public int countlines(string path)
        {
            int c = 0;
            StreamReader r = new StreamReader(path);
            string line;
                while ((line = r.ReadLine()) != null)
                {
                    c++;
                }
                r.Close();
            
            return c;
        }
    }
}
