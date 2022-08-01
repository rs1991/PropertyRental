using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class ContactInformation
    {

        private string _email;
        private string _number;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }


    }
}
