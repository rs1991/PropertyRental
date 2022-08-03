using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace PropertyRental
{
    public class ContactInformation
    {
       private string _number;
       private MailAddress _email;
       
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public MailAddress Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }

   
}

