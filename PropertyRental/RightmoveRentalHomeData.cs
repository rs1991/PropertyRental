using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class RightmoveRentalHomeData
    {
        private double _MonthlyRentalPrice;
        private string _EstateAgentPhoneNumber;
        private string _RentalHomeAddress;
        private string _RentalHomeDetails;
        private string _RentalHomeDescription;
        private DateTime _DateRentalHomeWasAdded;


        public double MonthlyRentalPrice
        {
            get { return _MonthlyRentalPrice; }
            set { _MonthlyRentalPrice = value; }
        } 
        
        public string EstateAgentPhoneNumber
        {
            get { return _EstateAgentPhoneNumber; }
            set { _EstateAgentPhoneNumber = value; }
        }
 
        
        public string RentalHomeAddress 
        { 
            get { return _RentalHomeAddress; }
            set { _RentalHomeAddress = value;}
        }
        
        public string RentalHomeDetails 
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
        
        

        public RightmoveRentalHomeData(double MonthlyRentalPrice, string EstateAgentPhoneNumber,
            string RentalHomeAddress, 
            string RentalHomeDetails, string RentalHomeDescription, DateTime DateRentalHomeWasAdded)
        {
            _MonthlyRentalPrice = MonthlyRentalPrice;
            _EstateAgentPhoneNumber = EstateAgentPhoneNumber;
            _RentalHomeAddress = RentalHomeAddress;
            _RentalHomeDetails = RentalHomeDetails;
            _RentalHomeDescription = RentalHomeDescription;
            _DateRentalHomeWasAdded = DateRentalHomeWasAdded;
        }

        public RightmoveRentalHomeData(RightmoveRentalHomeData rightMoveRentalHome)
        {
            MonthlyRentalPrice = rightMoveRentalHome.MonthlyRentalPrice;
            RentalHomeDescription= rightMoveRentalHome.RentalHomeDescription;
            EstateAgentPhoneNumber= rightMoveRentalHome.EstateAgentPhoneNumber;
            RentalHomeAddress= rightMoveRentalHome.RentalHomeAddress;
            RentalHomeDetails= rightMoveRentalHome.RentalHomeDetails;
            DateRentalHomeWasAdded= rightMoveRentalHome.DateRentalHomeWasAdded;
        }
    }

    
}
