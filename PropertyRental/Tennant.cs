using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class Tennant
    {
        private string firstName;
        private string lastName;
        private DateOnly birthDate;
        private string jobTitle;
        private string nationality;
        private double salary;
        private int children;
        private bool pets;
        private bool smoker;

        public string _firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string _lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateOnly _birthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public string _jobTitle
        {
          get { return _jobTitle; }
          set { _jobTitle = value; }
        }

        public string _nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }

        public double _salary
        {
        get { return _salary; }
        set { _salary = value; }
        }

        public int _children
        {
            get { return _children;}
            set { _children = value; }
        }

        public bool _pets
        {
            get { return _pets; }
            set { _pets = value; }
        }

        public bool _smoker
        {
            get { return _smoker; }
            set { _smoker = value; }
        }


    }
   
}
