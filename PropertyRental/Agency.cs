using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class Agency
    {

        private Address _address;
        private string _agencyName;

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string AgencyName 
        { 
          get { return _agencyName; }
          set { _agencyName = value; } 
        }


    }
}
