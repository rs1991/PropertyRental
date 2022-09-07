﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class SearchCriteriaFilter
    {
        [Flags]
        public enum CriteriaFilter
        {
            Smoker,
            Children,
            Pets, 
            Parking,
            WheelChairAccessible,
            PropertyType
        };
    }
}
