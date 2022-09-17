﻿using System;
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
        private bool _furnished;
        private int _price;
        private int _rentalDuration; 

        /// <summary>
        /// A tenant can rent a property either furnished or unfurnished
        /// </summary>
        public bool Furnished
        {
            get { return _furnished; }
            set { _furnished = value; }
        }
        public int RentalDuration
        {
            get { return _rentalDuration; }
            set { _rentalDuration = value; }
        }


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
        public List<RentalProperty> PropertyType 
        { 
            get { return _propertyType; }
            set { _propertyType = value; }
        }

        /// <summary>
        /// Price of rent per calendar month
        /// </summary>
        public double RentalPrice
        {
            get { return _rentalPrice; }
            set { _rentalPrice = value; }
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
