using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static PropertyRental.UiMethods;
using System.Xml.Serialization;
using System.Xml;
using System.Net.Http.Json;
using System.Text.RegularExpressions;

namespace PropertyRental
{
    public class LogicMethods
    {
        public static List<RentalHome> GenerateMockRentalPropertyList()
        {

            var rp1 = new RentalHome();

            rp1.Furnished = true;
            rp1.Price = 1350;
            rp1.RentalDuration = 12;
            rp1.AvailableOn = new DateOnly(2022, 11, 22);
            rp1.BedRooms = 1;
            rp1.Description = "This light and spacious ground floor one bedroom flat.";
            rp1.Agency = "Sargeants";
            rp1.Heating = EnergyType.Gas;
            rp1.CouncilTaxBand = CouncilTaxBand.Band_C;
            rp1.HomeType = TypeOfHome.Flat;
            rp1.SmokingAllowed = true;
            rp1.PetsAllowed = true;

            var a1 = new Address();

            a1.DoorNumber = 134;
            a1.Street = "Darwin Road";
            a1.City = "London";
            a1.PostCode = "W5 3RE";
            rp1.Address = a1;

            var rp2 = new RentalHome();

            rp2.Furnished = false;
            rp2.Price = 2200;
            rp2.RentalDuration = 12;
            rp2.AvailableOn = new DateOnly(2022, 10, 13);
            rp2.BedRooms = 4;
            rp2.Description = "We are delighted to offer for rent this 4 bedroom terrace house within walking distance to local amenities";
            rp2.Agency = "Open Rent";
            rp2.Heating = EnergyType.Gas;
            rp2.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp2.HomeType = TypeOfHome.House;
            rp2.SmokingAllowed = false;
            rp2.PetsAllowed = true;

            var a2 = new Address();

            a2.DoorNumber = 90;
            a2.Street = "Victoria Road";
            a2.City = "London";
            a2.PostCode = "N9 4XV";
            rp2.Address = a2;

            var rp3 = new RentalHome();

            rp3.Furnished = false;
            rp3.Price = 11700;
            rp3.RentalDuration = 12;
            rp3.AvailableOn = new DateOnly(2023, 01, 02);
            rp3.BedRooms = 3;
            rp3.Description = "An outstanding three bedroom Georgian family home";
            rp3.Agency = "Dexters";
            rp3.Heating = EnergyType.Electric;
            rp3.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp3.HomeType = TypeOfHome.House;
            rp3.SmokingAllowed = true;
            rp3.PetsAllowed = false;

            var a3 = new Address();

            a3.DoorNumber = 4;
            a3.Street = "Lincoln Street";
            a3.City = "London";
            a3.PostCode = "SW3 4QX";
            rp3.Address = a3;

            var rp4 = new RentalHome();

            rp4.Furnished = true;
            rp4.Price = 1000;
            rp4.RentalDuration = 12;
            rp4.AvailableOn = new DateOnly(2022, 11, 30);
            rp4.BedRooms = 1;
            rp4.Description = "Situated just moments from Crystal Palace Station and Park";
            rp4.Agency = "Streets ahead";
            rp4.Heating = EnergyType.Electric;
            rp4.CouncilTaxBand = CouncilTaxBand.Band_A;
            rp4.HomeType = TypeOfHome.Flat;
            rp4.SmokingAllowed = true;
            rp4.PetsAllowed = false;

            var a4 = new Address();

            a4.DoorNumber = 31;
            a4.Street = "Hamlet road";
            a4.City = "London";
            a4.PostCode = "SE20 1NF";
            rp4.Address = a4;

            var rp5 = new RentalHome();

            rp5.Furnished = false;
            rp5.Price = 1700;
            rp5.RentalDuration = 12;
            rp5.AvailableOn = new DateOnly(2022, 09, 29);
            rp5.BedRooms = 2;
            rp5.Description = "A spacious 2 bedroom bungalow built circa 1930 ";
            rp5.Agency = "Amanda Roberts agency";
            rp5.Heating = EnergyType.Solar;
            rp5.CouncilTaxBand = CouncilTaxBand.Band_B;
            rp5.HomeType = TypeOfHome.Bungalow;
            rp5.SmokingAllowed = false;
            rp5.PetsAllowed = false;

            var a5 = new Address();

            a5.DoorNumber = 2;
            a5.Street = "Sunset Avenue";
            a5.City = "London";
            a5.PostCode = "E4 8OM";
            rp5.Address = a5;

            var rp6 = new RentalHome();

            rp6.Furnished = true;
            rp6.Price = 2400;
            rp6.RentalDuration = 12;
            rp6.AvailableOn = new DateOnly(2022, 12, 14);
            rp6.BedRooms = 2;
            rp6.Description = "Rare to market, very unique and modern";
            rp6.Agency = "Open rent";
            rp6.Heating = EnergyType.Solar;
            rp6.CouncilTaxBand = CouncilTaxBand.Band_A;
            rp6.HomeType = TypeOfHome.Bungalow;
            rp6.SmokingAllowed = false;
            rp6.PetsAllowed = false;

            var a6 = new Address();

            a6.DoorNumber = 190;
            a6.Street = "Bury Street";
            a6.City = "London";
            a6.PostCode = "N9 9JZ";
            rp6.Address = a6;

            var rp7 = new RentalHome();

            rp7.Furnished = true;
            rp7.Price = 5850;
            rp7.RentalDuration = 6;
            rp7.AvailableOn = new DateOnly(2023, 02, 10);
            rp7.BedRooms = 2;
            rp7.Description = "This stunning and truly unique penthouse apartment is full of character ";
            rp7.Agency = "John D Wood and Co";
            rp7.Heating = EnergyType.Gas;
            rp7.CouncilTaxBand = CouncilTaxBand.Band_C;
            rp7.HomeType = TypeOfHome.Flat;
            rp7.SmokingAllowed = false;
            rp7.PetsAllowed = false;

            var a7 = new Address();

            a7.DoorNumber = 190;
            a7.Street = "Water road";
            a7.City = "London";
            a7.PostCode = "W4 7XT";
            rp7.Address = a7;

            var rp8 = new RentalHome();

            rp8.Furnished = true;
            rp8.Price = 2500;
            rp8.RentalDuration = 3;
            rp8.AvailableOn = new DateOnly(2022, 12, 10);
            rp8.BedRooms = 2;
            rp8.Description = "Proud to present this luxury, bright, and spacious";
            rp8.Agency = "B&C Properties";
            rp8.Heating = EnergyType.Gas;
            rp8.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp8.HomeType = TypeOfHome.Flat;
            rp8.SmokingAllowed = false;
            rp8.PetsAllowed = true;

            var a8 = new Address();

            a8.DoorNumber = 40;
            a8.Street = "Tizzard Grove";
            a8.City = "London";
            a8.PostCode = "SE13 8EQ";
            rp8.Address = a8;

            var rp9 = new RentalHome();

            rp9.Furnished = true;
            rp9.Price = 67000;
            rp9.RentalDuration = 12;
            rp9.AvailableOn = new DateOnly(2022, 03, 01);
            rp9.BedRooms = 5;
            rp9.Description = "Home near Harrods";
            rp9.Agency = "Stanley Properties";
            rp9.Heating = EnergyType.Gas;
            rp9.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp9.HomeType = TypeOfHome.House;
            rp9.SmokingAllowed = false;
            rp9.PetsAllowed = false;

            var a9 = new Address();

            a9.DoorNumber = 12;
            a9.Street = "Herbert Crescent";
            a9.City = "London";
            a9.PostCode = "SW1X 7LA";
            rp9.Address = a9;

            var rp10 = new RentalHome();

            rp10.Furnished = false;
            rp10.Price = 4000;
            rp10.RentalDuration = 12;
            rp10.AvailableOn = new DateOnly(2022, 10, 03);
            rp10.BedRooms = 4;
            rp10.Description = "A stunning four-bedroom mid-terrace house situated ";
            rp10.Agency = "View Properties";
            rp10.Heating = EnergyType.Electric;
            rp10.CouncilTaxBand = CouncilTaxBand.Band_A;
            rp10.HomeType = TypeOfHome.House;
            rp10.SmokingAllowed = false;
            rp10.PetsAllowed = false;

            var a10 = new Address();

            a10.DoorNumber = 18;
            a10.Street = "Brownlow road";
            a10.City = "London";
            a10.PostCode = "E8 4FE";
            rp10.Address = a10;

            List<RentalHome> ListOfRentalProperties = new List<RentalHome>();
            ListOfRentalProperties.Add(rp1);
            ListOfRentalProperties.Add(rp2);
            ListOfRentalProperties.Add(rp3);
            ListOfRentalProperties.Add(rp4);
            ListOfRentalProperties.Add(rp5);
            ListOfRentalProperties.Add(rp6);
            ListOfRentalProperties.Add(rp7);
            ListOfRentalProperties.Add(rp8);
            ListOfRentalProperties.Add(rp9);
            ListOfRentalProperties.Add(rp10);

            return ListOfRentalProperties;
        }

        public static List<Address> GenerateMockAddressList()
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

            return AddressList;
        }

        public static List<Tenant> GenerateMockListOfTenants()
        {

            //First tenant
            var t1 = new Tenant();

            t1.FirstName = "John";
            t1.LastName = "Smith";
            t1.BirthDate = new DateTime(1996, 11, 12);
            t1.JobTitle = "Project Manager";
            t1.Nationality = "British";
            t1.Salary = 65000;
            t1.Children = false;
            t1.Pets = false;
            t1.Smoker = false;
            t1.RentalTerm = 12;
            t1.Gender = Gender.Male;

            var a1 = new Address();

            a1.DoorNumber = 64;
            a1.Street = "Lenton Boulevard";
            a1.City = "Nottingham";
            a1.PostCode = "NG1 1QZ";
            t1.Address = a1;

            var contact1 = new ContactInformation();

            contact1.PhoneNumber = "07283472938";
            contact1.Email = new MailAddress("john.smith@gmail.com");

            //Second tenant
            var t2 = new Tenant();

            t2.FirstName = "Lewis";
            t2.LastName = "Miller";
            t2.BirthDate = new DateTime(1987, 06, 16);
            t2.JobTitle = "Accountant";
            t2.Nationality = "British";
            t2.Salary = 50000;
            t2.Children = false;
            t2.Pets = true;
            t2.Smoker = false;
            t2.RentalTerm = 18;
            t2.Gender = Gender.Male;

            var a2 = new Address();

            a2.DoorNumber = 13;
            a2.Street = "North Parade road";
            a2.City = "Bath";
            a2.PostCode = "BA2 4AL";
            t2.Address = a2;

            var contact2 = new ContactInformation();

            contact2.PhoneNumber = "07912384721";
            contact2.Email = new MailAddress("lewis.miller@gmail.com");

            //Third tenant
            var t3 = new Tenant();

            t3.FirstName = "Rachel";
            t3.LastName = "Johnson";
            t3.BirthDate = new DateTime(1970, 04, 27);
            t3.JobTitle = "Business development manager";
            t3.Nationality = "British";
            t3.Salary = 150555;
            t3.Children = true;
            t3.Pets = true;
            t3.Smoker = true;
            t3.RentalTerm = 12;
            t3.Gender = Gender.Female;

            var a3 = new Address();

            a3.DoorNumber = 64;
            a3.Street = "West Street";
            a3.City = "London";
            a3.PostCode = "WC2H 9NQ";
            t3.Address = a3;

            var contact3 = new ContactInformation();

            contact3.PhoneNumber = "07712484721";
            contact3.Email = new MailAddress("rachel.johnson@gmail.com");

            //4th tenant
            var t4 = new Tenant();

            t4.FirstName = "Natasha";
            t4.LastName = "Devon";
            t4.BirthDate = new DateTime(1980, 02, 04);
            t4.JobTitle = "Librarian";
            t4.Nationality = "British";
            t4.Salary = 150555;
            t4.Children = true;
            t4.Pets = true;
            t4.Smoker = false;
            t4.RentalTerm = 12;
            t4.Gender = Gender.Female;

            var a4 = new Address();

            a4.DoorNumber = 16;
            a4.Street = "High Street";
            a4.City = "London";
            a4.PostCode = "W5 5DB";
            t4.Address = a4;

            var contact4 = new ContactInformation();

            contact4.PhoneNumber = "07712484721";
            contact4.Email = new MailAddress("natasha.devon@gmail.com");


            //5th tenant
            var t5 = new Tenant();

            t5.FirstName = "Laurent";
            t5.LastName = "Sevran";
            t5.BirthDate = new DateTime(1964, 07, 26);
            t5.JobTitle = "Teacher";
            t5.Nationality = "French";
            t5.Salary = 52357;
            t5.Children = true;
            t5.Pets = false;
            t5.Smoker = true;
            t5.RentalTerm = 12;
            t5.Gender = Gender.Male;

            var a5 = new Address();

            a5.DoorNumber = 16;
            a5.Street = "South Kensington";
            a5.City = "London";
            a5.PostCode = "SW7 4RB";
            t5.Address = a5;

            var contact5 = new ContactInformation();

            contact5.PhoneNumber = "07712484727";
            contact5.Email = new MailAddress("laurent.sevran@gmail.com");


            //6th tenant
            var t6 = new Tenant();

            t6.FirstName = "Ali";
            t6.LastName = "Nachef";
            t6.BirthDate = new DateTime(1961, 03, 13);
            t6.JobTitle = "Civil Engineer";
            t6.Nationality = "Lebanese";
            t6.Salary = 76317;
            t6.Children = true;
            t6.Pets = false;
            t6.Smoker = false;
            t6.RentalTerm = 12;
            t6.Gender = Gender.Male;

            var a6 = new Address();

            a6.DoorNumber = 16;
            a6.Street = "Edgware road";
            a6.City = "London";
            a6.PostCode = "W2 2JE";
            t6.Address = a6;

            var contact6 = new ContactInformation();

            contact6.PhoneNumber = "07717487721";
            contact6.Email = new MailAddress("ali.nachef@gmail.com");

            //7th tenant

            var t7 = new Tenant();

            t7.FirstName = "George";
            t7.LastName = "Carlin";
            t7.BirthDate = new DateTime(1956, 03, 21);
            t7.JobTitle = "Comedian";
            t7.Nationality = "American";
            t7.Salary = 250123;
            t7.Children = true;
            t7.Pets = false;
            t7.Smoker = false;
            t7.RentalTerm = 12;
            t7.Gender = Gender.Male;

            var a7 = new Address();

            a7.DoorNumber = 119;
            a7.Street = "Holland Park Avenue";
            a7.City = "London";
            a7.PostCode = "W11 4UE";
            t7.Address = a7;

            var contact7 = new ContactInformation();

            contact7.PhoneNumber = "07832091284";
            contact7.Email = new MailAddress("george.carlin@gmail.com");

            //8th tenant           
            var t8 = new Tenant();

            t8.FirstName = "Michael";
            t8.LastName = "Evans";
            t8.BirthDate = new DateTime(1989, 03, 12);
            t8.JobTitle = "Marketing executive";
            t8.Nationality = "British";
            t8.Salary = 45000;
            t8.Children = false;
            t8.Pets = true;
            t8.Smoker = false;
            t8.RentalTerm = 24;
            t8.Gender = Gender.Male;

            var a8 = new Address();

            a8.DoorNumber = 119;
            a8.Street = "Holland Park Avenue";
            a8.City = "London";
            a8.PostCode = "W11 4UE";
            t8.Address = a8;

            var contact8 = new ContactInformation();

            contact8.PhoneNumber = "07832091284";
            contact8.Email = new MailAddress("michael.evans@gmail.com");

            //9th tenant
            var t9 = new Tenant();

            t9.FirstName = "William";
            t9.LastName = "White";
            t9.BirthDate = new DateTime(1976, 07, 26);
            t9.JobTitle = "HR director";
            t9.Nationality = "British";
            t9.Salary = 122357;
            t9.Children = true;
            t9.Pets = false;
            t9.Smoker = true;
            t9.RentalTerm = 12;
            t9.Gender = Gender.Male;

            var a9 = new Address();

            a9.DoorNumber = 19;
            a9.Street = "Driver street";
            a9.City = "London";
            a9.PostCode = "W6 2EZ";
            t9.Address = a9;

            var contact9 = new ContactInformation();

            contact9.PhoneNumber = "07817321284";
            contact9.Email = new MailAddress("william.white@gmail.com");

            //10th tenant
            var t10 = new Tenant();

            t10.FirstName = "Benjamin";
            t10.LastName = "Sterling";
            t10.BirthDate = new DateTime(1998, 03, 04);
            t10.JobTitle = "Garden designer";
            t10.Nationality = "British";
            t10.Salary = 66310;
            t10.Children = false;
            t10.Pets = false;
            t10.Smoker = false;
            t10.RentalTerm = 6;
            t3.Gender = Gender.Male;

            var a10 = new Address();

            a10.DoorNumber = 190;
            a10.Street = "Middleton road";
            a10.City = "London";
            a10.PostCode = "W9 4XV";
            t10.Address = a10;

            var contact10 = new ContactInformation();

            contact10.PhoneNumber = "07817321284";
            contact10.Email = new MailAddress("benjamin.sterling@gmail.com");

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


            return TenantList;
        }
        public static List<RentalHome> MatchTenantWithHome(Tenant tenant, List<RentalHome> rentalHomes)
        {
                       
            
            List<RentalHome> matches = new();

            foreach (var home in rentalHomes)
            {
                bool isMatch = false;

                if(!(tenant.Smoker == home.SmokingAllowed || tenant.Smoker == false))
                {
                    isMatch = false;
                }
                if(!(tenant.Pets == home.PetsAllowed || tenant.Pets == false))
                {
                    isMatch = false;
                }
                if(!(tenant.Children == home.ChildrenAllowed || tenant.Children == false))
                {
                    isMatch = false;
                }
                if(!(tenant.Budget <= home.Price))
                {
                    isMatch = false;
                }
                if(!(tenant.FurnitureRequired == home.Furnished || tenant.FurnitureRequired == false))
                {
                    isMatch = false;
                }
                if(!(tenant.ParkingRequired == home.Parking || tenant.ParkingRequired == false))
                {
                    isMatch = false;
                }
                if(!(tenant.GardenRequired == home.Garden || tenant.GardenRequired == false))
                {
                    isMatch = false;
                }
                if(!(tenant.BedRoomsRequired == home.BedRooms))
                {
                    isMatch = false;
                }
                if (isMatch)
                { 
                    matches.Add(home);
                } 
            }
            
            return matches;
        }


        public static double AffordabilityCheck(Tenant tenant, RentalHome rentalHome)
        {
            double months = 12; 
            double check = months * rentalHome.Price;
            double decision = check * 2;
            if(decision == tenant.Salary)
            {
                Console.WriteLine("Congratulations!, You have passed the affordability check");
            }
            else
            {
                Console.WriteLine("Unfortunately, you have not passed the affordability check");
            }
            throw new NotImplementedException();
        }

        public static void WriteDataStorage(DataStorage lists, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataStorage));

            using (FileStream file = File.Create(path))
            {
                var streamWriter = XmlWriter.Create(file, new()
                {
                    Encoding = Encoding.UTF8,
                    Indent = true
                });

                serializer.Serialize(streamWriter, lists);
            }
        }
    }
}
