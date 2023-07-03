using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public abstract class AbstractRentalHome
    {
        protected double _monthlyRentalPrice;
        protected string _estateAgentPhoneNumber;
        protected string _rentalHomeAddress;
        protected string _rentalHomeDetails;
        protected string _rentalHomeDescription;
        protected DateTime _rentalHomeDate;

        public double MonthlyRentalPrice
        {
            get { return _monthlyRentalPrice; }
            set { _monthlyRentalPrice = value; }
        }

        public string EstateAgentPhoneNumber
        {
            get { return _estateAgentPhoneNumber; }
            set { _estateAgentPhoneNumber = value; }
        }

        public string RentalHomeAddress
        {
            get { return _rentalHomeAddress; }
            set { _rentalHomeAddress = value; }
        }

        public string RentalHomeDetails
        {
            get { return _rentalHomeDetails; }
            set {_rentalHomeDetails = value; }
        }

        public AbstractRentalHome(double MonthlyRentalPrice, string EstateAgentPhoneNumber, string rentalHomeAddress,
            string rentalHomeDetails, string RentalHomeDescription, DateTime RentalHomeDate)
        {
            _monthlyRentalPrice = MonthlyRentalPrice;
            _estateAgentPhoneNumber = EstateAgentPhoneNumber;
            _rentalHomeAddress = rentalHomeAddress;
            _rentalHomeDetails = rentalHomeDetails;
            _rentalHomeDescription = RentalHomeDescription;
            _rentalHomeDate = RentalHomeDate;   
        }

        public AbstractRentalHome(){ }

        public abstract RentalHome ToRentalHome();

       

       
    }
}
