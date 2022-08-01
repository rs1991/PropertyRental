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
        private string _address;
        private DateOnly _availableOn;
        
        public double RentalPrice
        {
            get { return _rentalPrice; }
            set { _rentalPrice = value; }
        }

        public string Address
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
