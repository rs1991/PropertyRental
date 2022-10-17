using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class RatingSystem
    {
        
        private int _score;
        private int _rating; 

        public int Score 
        { 
            get { return _score; } 
            set { _score = value; } 
        }

        public int Rating 
        {
            get { return _rating; } 
            set { _rating = value; } 
        }

    }

    
}
