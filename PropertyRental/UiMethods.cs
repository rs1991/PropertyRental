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

            return tenantInfo;
        }
        

    }
}
