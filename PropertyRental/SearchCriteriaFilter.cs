namespace PropertyRental
{
    
        [Flags]
        public enum SearchCriteriaFilter
        {
            
            Unknown = 0,
            Smoker = 1,
            Children = 2,
            Pets = 3,  
            Parking = 4,
            WheelChairAccessible = 5,
            HomeType = 6,
            Elevator = 7,
            SwimmingPool = 8,
            Garden = 9,
        };
    
}
