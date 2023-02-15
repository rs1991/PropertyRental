using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class RentalHomePointsScore 
    {
        
        private double _score;
        private RentalHome _rentalHome;
        private Tenant _tenant;

        public double Score 
        { 
            get { return _score; } 
            set { _score = value; } 
        }

        public RentalHome Rental 
        {
            get { return _rentalHome; } 
            set { _rentalHome = value; } 
        }

        public Tenant Tenant
        {
            get { return _tenant; }
            set { _tenant = value; }
        }


    }

}
