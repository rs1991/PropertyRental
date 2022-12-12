using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    
        [Flags]
        public enum SearchCriteriaFilter
        {
            Smoker = 0,
            Children = 1,
            Pets = 2,  
            Parking = 3,
            WheelChairAccessible = 4,
            HomeType = 5,
            Elevator = 6
        };
    
}
