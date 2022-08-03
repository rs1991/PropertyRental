using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class ContactInformation
    {
       private string _number;
       
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }

    public class MailAddress
    {
        private string _address;

        public string Address 
        { 
            get { return _address; } 
            set { _address = value; } 
        }
    }
}

