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

        public static Tenant AddNewTenant()
        {

            throw new NotImplementedException();

        }

        public static Landlord AddNewLandlord()
        {
            throw new NotImplementedException();

        }

        public static RentalProperty AddNewRentalProperty()
        {
            throw new NotImplementedException();

        }

        public static RentalProperty AddNewAgency()
        {
            throw new NotImplementedException();

        }



        public static List<Tenant> GenerateTenantList()
        {

            var t1 = new Tenant();

            t1.FirstName = "John";
            t1.LastName = "Smith";
            t1.BirthDate = new DateTime(1996, 11, 12);
            t1.JobTitle = "Project Manager";
            t1.Nationality = "British";
            t1.Salary = 65000;
            t1.Children = 0;
            t1.Pets = false;
            t1.Smoker = false;
            t1.RentalTerm = 12;

            var a1 = new Address();

            a1.DoorNumber = 64;
            a1.Street = "Lenton Boulevard";
            a1.City = "Nottingham";
            a1.PostCode = "NG1 1QZ";
            t1.Address = a1;

            var t2 = new Tenant();

            t2.FirstName = "Lewis";
            t2.LastName = "Miller";
            t2.BirthDate = new DateTime(1987, 06, 16);
            t2.JobTitle = "Accountant";
            t2.Nationality = "British";
            t2.Salary = 50000;
            t2.Children = 0;
            t2.Pets = true;
            t2.Smoker = false;
            t2.RentalTerm = 18;

            var a2 = new Address();

            a2.DoorNumber = 13;
            a2.Street = "North Parade road";
            a2.City = "Bath";
            a2.PostCode = "BA2 4AL";

            var t3 = new Tenant();

            t3.FirstName = "Rachel";
            t3.LastName = "Johnson";
            t3.BirthDate = new DateTime(1970, 04, 27);
            t3.JobTitle = "Business development manager";
            t3.Nationality = "British";
            t3.Salary = 150555;
            t3.Children = 2;
            t3.Pets = true;
            t3.Smoker = true;
            t3.RentalTerm = 12;

            var a3 = new Address();

            a3.DoorNumber = 64;
            a3.Street = "West Street";
            a3.City = "London";
            a3.PostCode = "WC2H 9NQ";

            var t4 = new Tenant();

            t4.FirstName = "Natasha";
            t4.LastName = "Devon";
            t4.BirthDate = new DateTime(1980, 02, 04);
            t4.JobTitle = "Librarian";
            t4.Nationality = "British";
            t4.Salary = 150555;
            t4.Children = 2;
            t4.Pets = true;
            t4.Smoker = false;
            t4.RentalTerm = 12;

            var a4 = new Address();

            a4.DoorNumber = 16;
            a4.Street = "High Street";
            a4.City = "London";
            a4.PostCode = "W5 5DB";

            var t5 = new Tenant();

            t5.FirstName = "Laurent";
            t5.LastName = "Sevran";
            t5.BirthDate = new DateTime(1964, 07, 26);
            t5.JobTitle = "Teacher";
            t5.Nationality = "French";
            t5.Salary = 52357;
            t5.Children = 1;
            t5.Pets = false;
            t5.Smoker = true;
            t5.RentalTerm = 12;

            var a5 = new Address();

            a5.DoorNumber = 16;
            a5.Street = "South Kensington";
            a5.City = "London";
            a5.PostCode = "SW7 4RB";

            var t6 = new Tenant();

            t6.FirstName = "Ali";
            t6.LastName = "Nachef";
            t6.BirthDate = new DateTime(1961, 03, 13);
            t6.JobTitle = "Civil Engineer";
            t6.Nationality = "Lebanese";
            t6.Salary = 76317;
            t6.Children = 4;
            t6.Pets = false;
            t6.Smoker = false;
            t6.RentalTerm = 12;

            var a6 = new Address();

            a6.DoorNumber = 16;
            a6.Street = "Edgware road";
            a6.City = "London";
            a6.PostCode = "W2 2JE";

            var t7 = new Tenant();

            t7.FirstName = "George";
            t7.LastName = "Carlin";
            t7.BirthDate = new DateTime(1956, 03, 21);
            t7.JobTitle = "Comedian";
            t7.Nationality = "American";
            t7.Salary = 250123;
            t7.Children = 1;
            t7.Pets = false;
            t7.Smoker = false;
            t7.RentalTerm = 12;

            var a7 = new Address();

            a7.DoorNumber = 119;
            a7.Street = "Holland Park Avenue";
            a7.City = "London";
            a7.PostCode = "W11 4UE";

            var t8 = new Tenant();

            t8.FirstName = "Michael";
            t8.LastName = "Evans";
            t8.BirthDate = new DateTime(1989, 03, 12);
            t8.JobTitle = "Marketing executive";
            t8.Nationality = "British";
            t8.Salary = 45000;
            t8.Children = 0;
            t8.Pets = true;
            t8.Smoker = false;
            t8.RentalTerm = 24;

            var a8 = new Address();

            a8.DoorNumber = 128;
            a8.Street = "Down road";
            a8.City = "London";
            a8.PostCode = "W2 4DE";

            var t9 = new Tenant();

            t9.FirstName = "William";
            t9.LastName = "White";
            t9.BirthDate = new DateTime(1976, 07, 26);
            t9.JobTitle = "HR director";
            t9.Nationality = "British";
            t9.Salary = 122357;
            t9.Children = 3;
            t9.Pets = false;
            t9.Smoker = true;
            t9.RentalTerm = 12;

            var a9 = new Address();

            a9.DoorNumber = 19;
            a9.Street = "Driver street";
            a9.City = "London";
            a9.PostCode = "W6 2EZ";

            var t10 = new Tenant();

            t10.FirstName = "Benjamin";
            t10.LastName = "Sterling";
            t10.BirthDate = new DateTime(1998, 03, 04);
            t10.JobTitle = "Garden designer";
            t10.Nationality = "British";
            t10.Salary = 66310;
            t10.Children = 0;
            t10.Pets = false;
            t10.Smoker = false;
            t10.RentalTerm = 6;

            var a10 = new Address();

            a10.DoorNumber = 190;
            a10.Street = "Middleton road";
            a10.City = "London";
            a10.PostCode = "W9 4XV";

            var TenantList = new List<Tenant>();

            TenantList.Add(t1);
            TenantList.Add(t2);
            TenantList.Add(t3);
            TenantList.Add(t4);
            TenantList.Add(t5);
            TenantList.Add(t6);
            TenantList.Add(t7);
            TenantList.Add(t8);
            TenantList.Add(t9);
            TenantList.Add(t10);


            throw new NotImplementedException();
        }

        public static List<Address> GenerateAddressList()
        {

            var a1 = new Address();
            a1.DoorNumber = 5;
            a1.Street = "Derby Road";
            a1.City = "Nottingham";
            a1.PostCode = "NG5 3LW";

            var a2 = new Address();
            a2.DoorNumber = 33;
            a2.Street = "Brook Street";
            a2.City = "Nottingham";
            a2.PostCode = "NG1 1EA";

            var a3 = new Address();
            a3.DoorNumber = 47;
            a3.Street = "Brook Street";
            a3.City = "Nottingham";
            a3.PostCode = "NG1 1EA";

            var a4 = new Address();
            a4.DoorNumber = 5;
            a4.Street = "Daleham Mews";
            a4.City = "London";
            a4.PostCode = "NW3 5DB";

            var a5 = new Address();
            a5.DoorNumber = 5;
            a5.Street = "Blake hall road";
            a5.City = "London";
            a5.PostCode = "E11 2QQ";

            var a6 = new Address();
            a6.DoorNumber = 5;
            a6.Street = "Boydell Court";
            a6.City = "London";
            a6.PostCode = "NW8 6Nh";

            var a7 = new Address();
            a7.DoorNumber = 44;
            a7.Street = "Lowndes Square";
            a7.City = "London";
            a7.PostCode = "SW1 9xt";

            var a8 = new Address();
            a8.DoorNumber = 41;
            a8.Street = "Sydenham hill";
            a8.City = "London";
            a8.PostCode = "SE26 6TH";

            var a9 = new Address();
            a9.DoorNumber = 19;
            a9.Street = "Swan Drive";
            a9.City = "London";
            a9.PostCode = "NW9 5DE";

            var a10 = new Address();
            a10.DoorNumber = 221;
            a10.Street = "Ardgowan Road";
            a10.City = "London";
            a10.PostCode = "SE6 1AJ";


            var AddressList = new List<Address>();
            AddressList.Add(a1);
            AddressList.Add(a2);
            AddressList.Add(a3);
            AddressList.Add(a4);
            AddressList.Add(a5);
            AddressList.Add(a6);
            AddressList.Add(a7);
            AddressList.Add(a8);
            AddressList.Add(a9);
            AddressList.Add(a10);

            throw new NotImplementedException();


        }

        public static List<RentalProperty> GenerateRentalPropertyList()
        {
            throw new NotImplementedException();
        }




    }
}
