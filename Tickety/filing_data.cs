using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tickety
{
    class filing_data 
    {
        //get the path for files
        public string namepath ="name.txt";
        public string passwordpath ="password.txt";
        public string idpath ="id.txt";
        public string nationalidpath ="nationalid.txt";
        public int counlines;
        public filing_data()
        {
            counlines = countlines(idpath)+1;     
        }
        //store the data in the files
        public void save(string name,string pass,string nationalid)
        {

            StreamWriter wname = new StreamWriter(namepath, true);
                wname.WriteLine(name);
                wname.Close();

            StreamWriter wpassword = new StreamWriter(passwordpath, true);
            wpassword.WriteLine(pass);
                wpassword.Close();

            StreamWriter wnationalid = new StreamWriter(nationalidpath, true);
            wnationalid.WriteLine(nationalid);
                wnationalid.Close();

            StreamWriter wid = new StreamWriter(idpath, true);
            wid.WriteLine(counlines);
                wid.Close();
            
        }
        //store visa information
        public void visainformation(string v)
        {
            StreamWriter visa = new StreamWriter("visainformation.txt", true);
            visa.WriteLine(v);
                visa.Close();
            
        }
        //count the lines to generate the new id number
        public int countlines (string idpath)
        {
            int c = 0;
                StreamReader r = new StreamReader(idpath);
            
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
