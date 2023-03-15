namespace PropertyRental
{
    public class Agency
    {

        private Address _address;
        private string _agencyName;
        private string _agencyPhoneNumber;

        /// <summary>
        /// Agency address
        /// </summary>
        public Address Address 
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Agency name 
        /// </summary>
        public string AgencyName 
        { 
          get { return _agencyName; }
          set { _agencyName = value; } 
        }

        public string AgencyPhoneNumber
        {
            get { return _agencyPhoneNumber}
            set { _agencyPhoneNumber = value; }
        }

    }
}
