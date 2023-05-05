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
        private string _RentalHomeAddress;
        private string _RentalHomeDetails;
        private string _RentalHomeDescription;
   

        public double MonthlyRentalPrice
        {
            get { return _MonthlyRentalPrice; }
            set { _MonthlyRentalPrice = value; }
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

        public OpenRentData(double MonthlyRentalPrice, string RentalHomeAddress,
           string RentalHomeDetails, string RentalHomeDescription)
        {
            _MonthlyRentalPrice = MonthlyRentalPrice;
            _RentalHomeAddress = RentalHomeAddress;
            _RentalHomeDetails = RentalHomeDetails;
            _RentalHomeDescription = RentalHomeDescription;
           
        }



        public OpenRentData(double MonthlyRentalPrice)
        {
            _MonthlyRentalPrice = MonthlyRentalPrice;
        }

        public OpenRentData() { }

    }
}
