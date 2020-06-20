using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickety
{
   public class General 
    {
        //check the national id validation 
        public bool national_Id(string id)
        {
            if (id.Length != 14)
            {
                return false;
            }
            //make sure that all of the characters are digits
            for (int i=0;i<id.Length;i++)
            {
                if(!Char.IsDigit(id[i]))
                {
                    return false;
                }
            }   
            return true;
        }
        //check the ticket limit
        public bool limit_Ticket(int num)
        {
            if(num>=8)
            {
                return false;
            }
            return true;
        }
        //check the visa information validation 
        public bool visainformation(string name, string cardn)
        {
            if (cardn.Length != 16)
            {
                return false;

            }
            //make sure that all of them are characters
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i]))
                {
                    return false;

                }
            }
            //make sure that all of the characters are digits
            for (int i = 0; i < cardn.Length; i++)
            {
                if (!Char.IsDigit(cardn[i]))
                {
                    return false;

                }
            }
            return true;
        }

    }
}
