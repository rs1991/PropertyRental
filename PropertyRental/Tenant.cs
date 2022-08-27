using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class Tenant
    {
        private string _firstName;
        private string _lastName;
        private DateOnly _birthDate;
        private string _jobTitle;
        private string _nationality;
        private double _salary;
        private int _children;
        private bool _pets;
        private bool _smoker;
        private int _rentalTerm;
        private Address _address;
        private List<Tenant> _roomMates;

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
            get { return _rentalTerm;}
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
        
        public DateOnly BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
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
        
        public int Children
        {
            get { return _children;}
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


    }
   
}
