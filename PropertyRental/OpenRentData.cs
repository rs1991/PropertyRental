using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class OpenRentData
    {

        private double _MonthlyRentalPrice;
        private string _EstateAgentPhoneNumber;
        private string _EstateAgentName;
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

        public string EstateAgentName
        {
            get { return _EstateAgentName; }
            set { _EstateAgentName = value; }
        }

        public string RentalHomeAddress
        {
            get { return _RentalHomeAddress; }
            set { _RentalHomeAddress = value; }
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
            set { _DateRentalHomeWasAdded = value; }
        }



        public OpenRentData(double MonthlyRentalPrice)
        {
            _MonthlyRentalPrice = MonthlyRentalPrice;
        }

        public OpenRentData() { }

    }
}
