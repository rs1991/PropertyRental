using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class Landlord
    {
        private Address _address;
        private string _firstName;
        private string _lastName;
        private ContactInformation _contactInformation;


        
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public ContactInformation ContactInformation
        {
            get { return _contactInformation; }
            set { _contactInformation = value; }
        }
    }
}
