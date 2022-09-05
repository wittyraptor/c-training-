using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace DoctorMangementSytem
{
    
    public class RegException : Exception
    {
        public RegException(String msg) : base(msg)
        {

        }
        

    }


    public class NameException : Exception
    {
        public NameException(string msg) : base(msg)
        {

        }
    }
    public class AoSException : Exception
    {
        public AoSException(string msg) : base(msg)
        {

        }
    }

    public class ContactException : Exception
    {
        public ContactException(string msg) : base(msg)
        {

        }
    }
    public class timeException : Exception
    {
        public timeException(string msg) : base(msg)
        {

        }
    }


    public class validateDoctor
    {
        public static bool validateReg(string reg)
        {
            Regex r = new Regex(@"[0-9]{7}");
            if (r.IsMatch(reg))
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        public static bool validateName(string name)
        {
            Regex r = new Regex(@"[a-zA-z]");
            if (r.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validateAoS(string name)
        {
            Regex r = new Regex(@"[a-zA-z]");
            if (r.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validateContact(string ph)
        {
            Regex r = new Regex(@"[0-9]{10}");
            if (r.IsMatch(ph))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validateTime(string time)
        {
            Regex r = new Regex(@"[a-zA-z0-9!@#$%^&*()_=+]");
            if (r.IsMatch(time))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

