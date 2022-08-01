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
        
        public double _RentalPrice
        {
            get { return rentalPrice; }
            set { rentalPrice = value; }
        }

        public string _Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateOnly _AvailableOn
        {
            get { return _AvailableOn; }
            set { _AvailableOn = value; }
        }

    }
}
