using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class Address
    {
        private int _doorNumber;
        private string _street;
        private string _city;
        private string _postCode;

        public int DoorNumber
        {
            get { return _doorNumber; }
            set { _doorNumber = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }

    }
}
