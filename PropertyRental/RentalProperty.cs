using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class RentalProperty
    {
        private double _rentalPrice;
        private Address _address;
        private DateOnly _availableOn;
        private int _bedRooms;
        private List<RentalProperty> _propertyType;
        private string _description;
        private List<RentalProperty> _heating;
        private List<RentalProperty> _councilTaxBand;
        private string _agency;





        /// <summary>
        /// Property can either have gas or electric heating
        /// </summary>
        public List<RentalProperty> Heating
        {
            get { return _heating; }
            set { _heating = value; }
        }
        
        /// <summary>
        /// Property tax based on four different categories. Council tax band A, B, C & D 
        /// </summary>
        public List<RentalProperty> CouncilTaxBand
        {
            get { return _councilTaxBand; }
            set { _councilTaxBand = value; }
        }
                
        public string Agency
        {
            get { return _agency; }
            set { _agency = value; }
        }

            
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public List<RentalProperty> PropertyType 
        { 
            get { return _propertyType; }
            set { _propertyType = value; }
        }

        public double RentalPrice
        {
            get { return _rentalPrice; }
            set { _rentalPrice = value; }
        }

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public DateOnly AvailableOn
        {
            get { return _availableOn; }
            set { _availableOn = value; }
        }

        public int BedRooms
        {
            get { return _bedRooms; }
            set { _bedRooms = value; }
        }

    }
}
