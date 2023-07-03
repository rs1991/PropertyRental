
namespace PropertyRental
{
    public class RightmoveRentalHomeData : AbstractRentalHome
    {
        private double _MonthlyRentalPrice;
        private string _EstateContactPhoneNumber;
        private string _RentalHomeAddress;
        private string _RentalHomeDetails;
        private string _RentalHomeDescription;
        private DateTime _DateRentalHomeWasAdded;


        public double RentalPricePerMonth
        {
            get { return _MonthlyRentalPrice; }
            set { _MonthlyRentalPrice = value; }
        } 
        
        public string EstateAgentContactNumber
        {
            get { return _EstateContactPhoneNumber; }
            set { _EstateContactPhoneNumber = value; }
        }
        
        public string AddressForRentalHome 
        { 
            get { return _RentalHomeAddress; }
            set { _RentalHomeAddress = value;}
        }
        
        public string DetailsForRentalHome 
        {
            get { return _RentalHomeDetails; }
            set { _RentalHomeDetails = value; }
        }
        
        public string RentalHomeDescription 
        { 
            get { return _RentalHomeDescription; }
            set { _RentalHomeDescription = value; }
        }
        
        public DateTime DateRentalHomeWasAdded 
        {
            get { return _DateRentalHomeWasAdded; }
            set {_DateRentalHomeWasAdded = value;}
        }
        
                

        public RightmoveRentalHomeData() { }

        public override RentalHome ToRentalHome()
        {
            RentalHome rentalHome = new RentalHome();
            rentalHome.MonthlyRentalPrice = this.MonthlyRentalPrice;
            rentalHome.EstateAgentPhoneNumber = this.EstateAgentPhoneNumber;
            rentalHome.RentalHomeAddress = this.RentalHomeAddress;
            rentalHome.RentalHomeDetails = this.RentalHomeDetails;
            rentalHome.Description = this.RentalHomeDescription;
            rentalHome.DateHomeWasAdvertised = this.DateRentalHomeWasAdded;

            return rentalHome;
        }



    }

}
