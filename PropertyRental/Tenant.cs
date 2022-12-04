using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class Tenant
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private DateTime _availableToMoveOn;
        private string _jobTitle;
        private string _nationality;
        private double _salary;
        private bool _children;
        private bool _pets;
        private bool _smoker;
        private Gender _gender;
        private int _rentalTerm;
        private int _budget;
        private bool _parkingRequired;
        private bool _furnitureRequired;
        private bool _gardenRequired;
        private int _bedroomsRequired;
        private Address _address;
        private Address _preferredAdress;
        private List<Tenant> _roomMates;
        private double _floorSizeRequired;

        public Address PreferredAdress { get { return _preferredAdress; } set { _preferredAdress = value; } }

        public double FloorSizeRequired
        {
            get { return _floorSizeRequired; }
            set { _floorSizeRequired = value; }
        }

        public int BedRoomsRequired
        {
            get { return _bedroomsRequired; }
            set { _bedroomsRequired = value; }
        }

        public bool GardenRequired
        {
            get { return _gardenRequired; }
            set { _gardenRequired = value; }
        }
        public bool FurnitureRequired
        {
            get { return _furnitureRequired; }
            set { _furnitureRequired = value; }
        }

        /// <summary>
        /// Does the tenant require parking?
        /// </summary>
        public bool ParkingRequired
        {
            get { return _parkingRequired; }
            set { _parkingRequired = value; }
        }


        /// <summary>
        /// Monthly rental budget
        /// </summary>
        public int Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }

        /// <summary>
        /// Extra tenants/room mates can be added to the rental application
        /// </summary>
        public List<Tenant> RoomMates
        {
            get { return _roomMates; }
            set { _roomMates = value; }
        }

        /// <summary>
        /// Rental duration in months 
        /// </summary>
        public int RentalTerm
        {
            get { return _rentalTerm; }
            set { _rentalTerm = value; }
        }

        /// <summary>
        /// The tenant's current address 
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        /// <summary>
        /// Date that the tenant is available to move on
        /// </summary>
        public DateTime AvailableToMoveOn
        {
            get { return _availableToMoveOn; }
            set { _availableToMoveOn = value; }
        }
      
        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public bool Children
        {
            get { return _children; }
            set { _children = value; }
        }

        public bool Pets
        {
            get { return _pets; }
            set { _pets = value; }
        }

        public bool Smoker
        {
            get { return _smoker; }
            set { _smoker = value; }
        }

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public override string ToString()
        {
            return $"Floorsize required: {FloorSizeRequired} Available to move on: {AvailableToMoveOn} " +
                $"Budget: {Budget} Bedrooms required: {BedRoomsRequired} ";
        }

    }

}
