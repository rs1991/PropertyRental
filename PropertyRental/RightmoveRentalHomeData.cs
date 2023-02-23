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
        } 
        
        public string EstateAgentPhoneNumber
        {
            get { return _EstateAgentPhoneNumber; }
        }
 
        
        public string RentalHomeAddress 
        { 
            get { return _RentalHomeAddress; }
        }
        
        public string RentalHomeDetails 
        {
            get { return _RentalHomeDetails; } 
        }
        
        
        public string RentalHomeDescription 
        { 
            get { return _RentalHomeDescription; } 
        }
        
        public DateTime DateRentalHomeWasAdded 
        {
            get { return _DateRentalHomeWasAdded; } 
        }
        
        

        public RightmoveRentalHomeData(double MonthlyRentalPrice, string EstateAgentPhoneNumber, string RentalHomeAddress, string RentalHomeDetails, string RentalHomeDescription, DateTime DateRentalHomeWasAdded)
        {
            _MonthlyRentalPrice = MonthlyRentalPrice;
            _EstateAgentPhoneNumber = EstateAgentPhoneNumber;
            _RentalHomeAddress = RentalHomeAddress;
            _RentalHomeDetails = RentalHomeDetails;
            _RentalHomeDescription = RentalHomeDescription;
            _DateRentalHomeWasAdded = DateRentalHomeWasAdded;
        }
    }

    
}
