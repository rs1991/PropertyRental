using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class RentalProperty
    {
        
        private Address _address;
        private DateOnly _availableOn;
        private int _bedRooms;
        private TypeOfHome _homeType;
        private string _description;
        private EnergyType _heating;
        private CouncilTaxBand _councilTaxBand;
        private string _agency;
        private bool _furnished;
        private int _price;
        private int _rentalDuration;
        private bool _smokingAllowed;

        /// <summary>
        ///Does the property allow smoking
        /// </summary>
        public bool SmokingAllowed
        {
            get { return _smokingAllowed; }
            set { _smokingAllowed = value; }
        }


        /// <summary>
        /// A tenant can rent a property either furnished or unfurnished
        /// </summary>
        public bool Furnished
        {
            get { return _furnished; }
            set { _furnished = value; }
        }

        /// <summary>
        /// Duration the Rental property will be available for
        /// </summary>
        public int RentalDuration
        {
            get { return _rentalDuration; }
            set { _rentalDuration = value; }
        }

        /// <summary>
        /// Property can either have gas or electric heating
        /// </summary>
        public EnergyType Heating
        {
            get { return _heating; }
            set { _heating = value; }
        }
        
        /// <summary>
        /// Property tax based on four different categories. Council tax band A, B, C & D 
        /// </summary>
        public CouncilTaxBand CouncilTaxBand
        {
            get { return _councilTaxBand; }
            set { _councilTaxBand = value; }
        }
        
        /// <summary>
        /// Agency details 
        /// </summary>
        public string Agency
        {
            get { return _agency; }
            set { _agency = value; }
        }

        /// <summary>
        /// Property description 
        /// </summary>
            
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        /// Property type such as flat, house or bungalow
        /// </summary>
        public TypeOfHome HomeType 
        { 
            get { return _homeType; }
            set { _homeType = value; }
        }

        
        /// <summary>
        /// Property address 
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Date property will be available
        /// </summary>
        public DateOnly AvailableOn
        {
            get { return _availableOn; }
            set { _availableOn = value; }
        }

        /// <summary>
        /// Number of bedrooms
        /// </summary>
        public int BedRooms
        {
            get { return _bedRooms; }
            set { _bedRooms = value; }
        }

        /// <summary>
        /// Monthly rental price
        /// </summary>
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
