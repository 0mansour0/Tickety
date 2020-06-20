using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickety
{
    class cregister : General
    {
        //check that the name is all characters
        public bool name(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i]))
                {
                    return false;

                }
            }
            return true;
        }
        //check that the age above 18
        public bool age(int age)
        {
            if(age<18)
            {
                return false;
            }
            return true;
        }
        //check that the mobile number is all digits and consists of 11 number
        public bool mobile_num(string mob)
        {
            if(mob.Length!=11)
            {
                return false;
            }
            for(int i=0;i<mob.Length;i++)
            {
                if (!Char.IsDigit(mob[i]))
                {
                    return false;

                }
            }
            return true;
        }
        //check that the password more than 6 characters
        public bool password(string pass)
        {
            if(pass.Length<6)
            {
                return false;
            }
            return true;
        }
    }
}
