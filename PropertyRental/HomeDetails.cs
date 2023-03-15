namespace PropertyRental
{

    public class HomeDetails
    {
        private int _totalBathrooms; 
        private int _totalBedrooms;

        public int TotalBathrooms
        {
            get { return _totalBathrooms; }
            set { _totalBathrooms = value; }
        }

        public int TotalBedrooms
        {
            get { return _totalBedrooms; }
            set { _totalBedrooms = value; }
        }
    }
}