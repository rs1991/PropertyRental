using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class RentalProperty
    {
        private double rentalPrice;
        private string address;
        private DateOnly availableOn;
        
        public double _rentalPrice
        {
            get { return _rentalPrice; }
            set { _rentalPrice = value; }
        }

        public string _address
        {
            get { return _address; }
            set { _address = value; }
        }

        public DateOnly _availableOn
        {
            get { return _availableOn; }
            set { _availableOn = value; }
        }

    }
}
