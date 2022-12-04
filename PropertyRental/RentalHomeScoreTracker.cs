using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class RentalHomeScoreTracker 
    {
        
        private int _score;
        private RentalHome _rentalHome; 

        public int Score 
        { 
            get { return _score; } 
            set { _score = value; } 
        }

        public RentalHome Rental 
        {
            get { return _rentalHome; } 
            set { _rentalHome = value; } 
        }

      



    }

    
}
