using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class UiMethods
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the app!");
        }

        public static Tenant GenerateTenant()
        {
            Tenant tenantInfo = new Tenant();
            
            Console.WriteLine("What is your first name? ");
            string tenantFirstName = Console.ReadLine();
            tenantInfo.FirstName = tenantFirstName;
            
            Console.WriteLine("What is your last name? ");
            string tenantLastName = Console.ReadLine();
            tenantInfo.LastName = tenantLastName;

            Console.WriteLine("What is your DOB? ");
            DateTime DOB = Convert.ToDateTime(Console.ReadLine());
            tenantInfo.BirthDate = DOB;
            
            Console.WriteLine("What is your Job title? ");
            string jobTitle = Console.ReadLine();
            tenantInfo.JobTitle = jobTitle;
            
            Console.WriteLine("What is your nationality? ");
            string nationality = Console.ReadLine();
            tenantInfo.Nationality = nationality;
            
            Console.WriteLine("What is your annual salary? ");
            double salary = Console.Read();
            tenantInfo.Salary = salary;
            
            Console.WriteLine("Number of children?");
            int children = Console.Read();
            tenantInfo.Children = children;
            
            bool pets = false;
            Console.WriteLine("Any pets?");
            string petResponse = Console.ReadLine();
            if (petResponse == "y")
            {
                pets = true;
            }
          //  pets = Convert.ToBoolean(Console.ReadLine());
            tenantInfo.Pets = pets;
            
            bool smoker;
            Console.WriteLine("Are you a smoker?");
            smoker = Convert.ToBoolean(Console.ReadLine());
            tenantInfo.Smoker = smoker;
            
            Console.WriteLine("How long are you looking to rent for?");
            int rentalDuration = Console.Read();
            tenantInfo.RentalTerm = rentalDuration;

            //Address address; 
            //Console.WriteLine("What is your current address? ");
            //address = Console.ReadLine();
            //tenantInfo.Address = address;
            
            //private Address _address;
            //private List<Tenant> _roomMates;
            return tenantInfo;
        }
        

    }
}
