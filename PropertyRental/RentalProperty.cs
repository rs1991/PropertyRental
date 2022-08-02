using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class RentalProperty
    {
        private double _rentalPrice;
        private Address _address;
        private DateOnly _availableOn;
        //Number of rooms
        //Type House or flat
        //Description
        //Gas or electric heating
        //Council tax band 
        //Agency 
        
        public double RentalPrice
        {
            get { return _rentalPrice; }
            set { _rentalPrice = value; }
        }

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public DateOnly AvailableOn
        {
            get { return _availableOn; }
            set { _availableOn = value; }
        }

    }
}
