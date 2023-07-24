using System.Net;
using System.Net.Mail;
using static PropertyRental.UiMethods;
using System.Xml.Serialization;
using Newtonsoft.Json;
using HtmlAgilityPack;
using Serilog;
using File = System.IO.File;
using iText.Layout;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System.Text;
using System.Xml;

namespace PropertyRental
{
    public class LogicMethods
    {

        /// <summary>
        /// This method generates a list of mock rental homes
        /// </summary>
        /// <returns></returns>
        public static List<RentalHome> GenerateMockRentalHomesList()
        {
            string api = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\apiKey.txt");

            //RentalHome1 
            RightmoveRentalHomeData rdHome = new RightmoveRentalHomeData(2345, "0781273819", "18 Zulla road, Nottingham", "Great location", "2 bedrooms, 1 bathroom", new DateTime(2023, 01, 20));

            RentalHome rp1 = new RentalHome(rdHome, api);
            rp1.Furnished = false;
            rp1.Price = 1350;
            rp1.RentalDuration = 12;
            rp1.AvailableOn = new DateTime(2023, 10, 28);
            rp1.DateHomeWasAdvertised = new DateTime(2023, 07, 23);
            rp1.Description = "This light and spacious ground floor one bedroom flat.";
            rp1.Agency = "Sargeants";
            rp1.Heating = EnergyType.Gas;
            rp1.CouncilTaxBand = CouncilTaxBand.Band_C;
            rp1.HomeType = TypeOfHome.Flat;
            rp1.SmokingAllowed = true;
            rp1.PetsAllowed = false;
            rp1.ChildrenAllowed = false;
            rp1.Parking = false;
            rp1.FloorSize = 40;
            rp1.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;
            rp1.ElevatorAvailable = SearchCriteriaFilter.Elevator;
            rp1.Garden = false;


            Landlord landlord1 = new Landlord();
            landlord1.FirstName = "Jomana";
            landlord1.LastName = "Madieh";
            rp1.Landlord = landlord1;

            ContactInformation contact1 = new ContactInformation();
            contact1.PhoneNumber = "07182738292";
            contact1.Email = new MailAddress("rida.serroukh@gmail.com");
            landlord1.ContactInformation = contact1;

            HomeDetails homeDetails1 = new HomeDetails();
            homeDetails1.TotalBedrooms = 1;
            rp1.HomeDetails = homeDetails1;

            Address a1 = new Address();
            a1.DoorNumber = 134;
            a1.Street = "Darwin Road";
            a1.City = "London";
            a1.PostCode = "W5 3RE";
            rp1.Address = a1;

            RentalHome rp2 = new RentalHome(rdHome, api);
            rp2.Furnished = false;
            rp2.Price = 2200;
            rp2.RentalDuration = 12;
            rp2.AvailableOn = new DateTime(2022, 11, 30);
            rp2.Description = "We are delighted to offer for rent this 4 bedroom terrace house within walking distance to local amenities";
            rp2.Agency = "Open Rent";
            rp2.Heating = EnergyType.Gas;
            rp2.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp2.HomeType = TypeOfHome.House;
            rp2.SmokingAllowed = true;
            rp2.PetsAllowed = false;
            rp2.ChildrenAllowed = true;
            rp2.Parking = false;
            rp2.FloorSize = 50;
            rp2.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;

            Landlord landlord2 = new Landlord();
            landlord2.FirstName = "Jo";
            landlord2.LastName = "Mack";
            rp2.Landlord = landlord2;

            HomeDetails homeDetails2 = new HomeDetails();
            homeDetails2.TotalBedrooms = 4;
            rp2.HomeDetails = homeDetails2;

            Address a2 = new Address();
            a2.DoorNumber = 90;
            a2.Street = "Victoria Road";
            a2.City = "London";
            a2.PostCode = "N9 4XV";
            rp2.Address = a2;

            RentalHome rp3 = new RentalHome(rdHome, api);
            rp3.Furnished = false;
            rp3.Price = 11700;
            rp3.RentalDuration = 12;
            rp3.AvailableOn = new DateTime(2023, 01, 02);
            rp3.Description = "An outstanding three bedroom Georgian family home";
            rp3.Agency = "Dexters";
            rp3.Heating = EnergyType.Electric;
            rp3.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp3.HomeType = TypeOfHome.House;
            rp3.SmokingAllowed = true;
            rp3.PetsAllowed = false;
            rp3.ChildrenAllowed = false;
            rp3.Parking = false;
            rp3.FloorSize = 60;
            rp3.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;

            Landlord landlord3 = new Landlord();
            landlord3.FirstName = "Jim";
            landlord3.LastName = "Smith";
            rp3.Landlord = landlord3;

            HomeDetails homeDetails3 = new HomeDetails();
            homeDetails3.TotalBedrooms = 3;
            rp3.HomeDetails = homeDetails3;
            
            Address a3 = new Address();
            a3.DoorNumber = 4;
            a3.Street = "Lincoln Street";
            a3.City = "London";
            a3.PostCode = "SW3 4QX";
            rp3.Address = a3;

            RentalHome rp4 = new RentalHome(rdHome, api);
            rp4.Furnished = false;
            rp4.Price = 1000;
            rp4.RentalDuration = 12;
            rp4.AvailableOn = new DateTime(2022, 11, 29);
            rp4.Description = "Situated just moments from Crystal Palace Station and Park";
            rp4.Agency = "Streets ahead";
            rp4.Heating = EnergyType.Electric;
            rp4.CouncilTaxBand = CouncilTaxBand.Band_A;
            rp4.HomeType = TypeOfHome.Flat;
            rp4.SmokingAllowed = true;
            rp4.PetsAllowed = false;
            rp4.ChildrenAllowed = false;
            rp4.Parking = false;
            rp4.FloorSize = 90;
            rp4.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;
            rp4.ElevatorAvailable = SearchCriteriaFilter.Elevator;

            Landlord landlord4 = new Landlord();
            landlord4.FirstName = "Martin";
            landlord4.LastName = "Gabor";
            rp4.Landlord = landlord4;

            HomeDetails homeDetails4 = new HomeDetails();
            homeDetails3.TotalBedrooms = 4;
            rp4.HomeDetails = homeDetails4;

            Address a4 = new Address();
            a4.DoorNumber = 31;
            a4.Street = "Hamlet road";
            a4.City = "London";
            a4.PostCode = "SE20 1NF";
            rp4.Address = a4;

            RentalHome rp5 = new RentalHome(rdHome, api);
            rp5.Furnished = false;
            rp5.Price = 1700;
            rp5.RentalDuration = 12;
            rp5.AvailableOn = new DateTime(2022, 12, 29);
            rp5.Description = "A spacious 2 bedroom bungalow built circa 1930 ";
            rp5.Agency = "Amanda Roberts agency";
            rp5.Heating = EnergyType.Solar;
            rp5.CouncilTaxBand = CouncilTaxBand.Band_B;
            rp5.HomeType = TypeOfHome.Bungalow;
            rp5.SmokingAllowed = true;
            rp5.PetsAllowed = false;
            rp5.ChildrenAllowed = false;
            rp5.Parking = false;
            rp5.FloorSize = 45;
            rp5.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;

            Landlord landlord5 = new Landlord();
            landlord5.FirstName = "Peter";
            landlord5.LastName = "Noden";
            rp5.Landlord = landlord5;

            HomeDetails homeDetails5 = new HomeDetails();
            homeDetails5.TotalBedrooms = 2;
            rp5.HomeDetails = homeDetails5;

            Address a5 = new Address();
            a5.DoorNumber = 2;
            a5.Street = "Sunset Avenue";
            a5.City = "London";
            a5.PostCode = "E4 8OM";
            rp5.Address = a5;

            RentalHome rp6 = new RentalHome(rdHome, api);
            rp6.Furnished = false;
            rp6.Price = 2400;
            rp6.RentalDuration = 12;
            rp6.AvailableOn = new DateTime(2023, 01, 14);
            rp6.Description = "Rare to market, very unique and modern";
            rp6.Agency = "Open rent";
            rp6.Heating = EnergyType.Solar;
            rp6.CouncilTaxBand = CouncilTaxBand.Band_A;
            rp6.HomeType = TypeOfHome.Bungalow;
            rp6.SmokingAllowed = false;
            rp6.PetsAllowed = false;
            rp6.ChildrenAllowed = false;
            rp6.Parking = false;
            rp6.FloorSize = 105;
            rp6.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;

            Landlord landlord6 = new Landlord();
            landlord6.FirstName = "David";
            landlord6.LastName = "Lewis";
            rp6.Landlord = landlord6;


            HomeDetails homeDetails6 = new HomeDetails();
            homeDetails6.TotalBedrooms = 3;
            rp6.HomeDetails = homeDetails6;

            Address a6 = new Address();
            a6.DoorNumber = 190;
            a6.Street = "Bury Street";
            a6.City = "London";
            a6.PostCode = "N9 9JZ";
            rp6.Address = a6;

            RentalHome rp7 = new RentalHome(rdHome, api);
            rp7.Furnished = false;
            rp7.Price = 5850;
            rp7.RentalDuration = 6;
            rp7.AvailableOn = new DateTime(2023, 02, 10);
            rp7.Description = "This stunning and truly unique penthouse apartment is full of character ";
            rp7.Agency = "John D Wood and Co";
            rp7.Heating = EnergyType.Gas;
            rp7.CouncilTaxBand = CouncilTaxBand.Band_C;
            rp7.HomeType = TypeOfHome.Flat;
            rp7.SmokingAllowed = false;
            rp7.PetsAllowed = false;
            rp7.ChildrenAllowed = false;
            rp7.Parking = false;
            rp7.FloorSize = 55;
            rp7.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;
            rp7.ElevatorAvailable = SearchCriteriaFilter.Elevator;

            Landlord landlord7 = new Landlord();
            landlord7.FirstName = "Gabriel";
            landlord7.LastName = "Ineu";
            rp7.Landlord = landlord7;

            HomeDetails homeDetails7 = new HomeDetails();
            homeDetails7.TotalBedrooms = 3;
            rp7.HomeDetails = homeDetails7;

            Address a7 = new Address();
            a7.DoorNumber = 190;
            a7.Street = "Water road";
            a7.City = "London";
            a7.PostCode = "W4 7XT";
            rp7.Address = a7;

            RentalHome rp8 = new RentalHome(rdHome, api);
            rp8.Furnished = false;
            rp8.Price = 2500;
            rp8.RentalDuration = 3;
            rp8.AvailableOn = new DateTime(2022, 12, 10);
            rp8.Description = "Proud to present this luxury, bright, and spacious";
            rp8.Agency = "B&C Properties";
            rp8.Heating = EnergyType.Gas;
            rp8.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp8.HomeType = TypeOfHome.Flat;
            rp8.SmokingAllowed = false;
            rp8.PetsAllowed = false;
            rp8.ChildrenAllowed = false;
            rp8.Parking = false;
            rp8.FloorSize = 66;
            rp8.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;

            Landlord landlord8 = new Landlord();
            landlord8.FirstName = "Dean";
            landlord8.LastName = "Amni";
            rp8.Landlord = landlord8;

            HomeDetails homeDetails8 = new HomeDetails();
            homeDetails8.TotalBedrooms = 2;
            rp8.HomeDetails = homeDetails8;

            Address a8 = new Address();
            a8.DoorNumber = 40;
            a8.Street = "Tizzard Grove";
            a8.City = "London";
            a8.PostCode = "SE13 8EQ";
            rp8.Address = a8;

            RentalHome rp9 = new RentalHome(rdHome, api);
            rp9.Furnished = false;
            rp9.Price = 67000;
            rp9.RentalDuration = 12;
            rp9.AvailableOn = new DateTime(2023, 03, 01);
            rp9.Description = "Home near Harrods";
            rp9.Agency = "Stanley Properties";
            rp9.Heating = EnergyType.Gas;
            rp9.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp9.HomeType = TypeOfHome.House;
            rp9.SmokingAllowed = false;
            rp9.PetsAllowed = false;
            rp9.ChildrenAllowed = false;
            rp9.Parking = false;
            rp9.FloorSize = 40;
            rp9.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;

            Landlord landlord9 = new Landlord();
            landlord9.FirstName = "Jessica";
            landlord9.LastName = "Black";
            rp9.Landlord = landlord9;

            HomeDetails homeDetails9 = new HomeDetails();
            homeDetails9.TotalBedrooms = 2;
            rp9.HomeDetails = homeDetails9;

            var a9 = new Address();
            a9.DoorNumber = 12;
            a9.Street = "Herbert Crescent";
            a9.City = "London";
            a9.PostCode = "SW1X 7LA";
            rp9.Address = a9;

            RentalHome rp10 = new RentalHome(rdHome, api);
            rp10.Furnished = false;
            rp10.Price = 4000;
            rp10.RentalDuration = 12;
            rp10.AvailableOn = new DateTime(2022, 12, 13);
            rp10.Description = "A stunning four-bedroom mid-terrace house situated";
            rp10.Agency = "View Properties";
            rp10.Heating = EnergyType.Electric;
            rp10.CouncilTaxBand = CouncilTaxBand.Band_A;
            rp10.HomeType = TypeOfHome.House;
            rp10.SmokingAllowed = false;
            rp10.PetsAllowed = false;
            rp10.ChildrenAllowed = false;
            rp10.Parking = false;
            rp10.FloorSize = 70;
            rp10.WheelChairAccess = SearchCriteriaFilter.WheelChairAccessible;
            rp10.ElevatorAvailable = SearchCriteriaFilter.Elevator;

            Landlord landlord10 = new Landlord();
            landlord10.FirstName = "Tom";
            landlord10.LastName = "Jacobs";
            rp10.Landlord = landlord10;

            HomeDetails homeDetails10 = new HomeDetails();
            homeDetails10.TotalBedrooms = 4;
            rp10.HomeDetails = homeDetails10;

            Address a10 = new Address();
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
        
        /// <summary>
        /// This method generates a list of mock addresses  
        /// </summary>
        /// <returns></returns>
        public static List<Address> GenerateMockAddressList()
        {
            var a1 = new Address();
            a1.DoorNumber = 130;
            a1.Street = "Argyle road";
            a1.City = "London";
            a1.PostCode = "W13 8ER";
            
            var a2 = new Address();
            a2.DoorNumber = 22;
            a2.Street = "Singapore road";
            a2.City = "London";
            a2.PostCode = "W13 0UF";
            
            var a3 = new Address();
            a3.DoorNumber = 20;
            a3.Street = "Rosemount Rd";
            a3.City = "London";
            a3.PostCode = "W13 0HJ";
            
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
        
        /// <summary>
        /// Generates a list of mock tenants 
        /// </summary>
        /// <returns></returns>
        public static List<Tenant> GenerateMockListOfTenants()
        {
            //First tenant
            var t1 = new Tenant();
            t1.FirstName = "Hussein";
            t1.LastName = "Hashem";
            t1.BirthDate = new DateTime(1996, 11, 12);
            t1.AvailableToMoveOn = new DateTime(2023, 08, 01);
            t1.MustMoveInOnThisDate = new DateTime(2023, 08, 10);
            t1.JobTitle = "Project Manager";
            t1.Nationality = "Jordanian";
            t1.Salary = 65000;
            t1.Children = false;
            t1.Pets = false;
            t1.Smoker = false;
            t1.RentalTerm = 12;
            t1.Gender = Gender.Male;
            t1.FloorSizeRequired = 40;
            t1.GardenRequired = true;
            t1.ParkingRequired = true;
            t1.FurnitureRequired = false;
            t1.CouncilTaxBand = CouncilTaxBand.Band_C;
            t1.TenantPreferredHomeType = TypeOfHome.Flat;
            t1.TenantPreferredEnergyType = EnergyType.Gas;
            t1.BedRoomsRequired = 3;
            t1.Budget = 3500;

            var a1 = new Address();
            a1.DoorNumber = 64;
            a1.Street = "Lenton Boulevard";
            a1.City = "Nottingham";
            a1.PostCode = "NG1 1QZ";
            t1.Address = a1;

            var prefAddress1 = new Address();
            prefAddress1.DoorNumber = 22;
            prefAddress1.Street = "Holborn";
            prefAddress1.City = "London";
            prefAddress1.PostCode = "EC1N 2TD";
            t1.PreferredAdress = prefAddress1;

            var contact1 = new ContactInformation();
            contact1.PhoneNumber = "07283472938";
            contact1.Email = new MailAddress("rida.serroukh@gmail.com");
            t1.ContactInformation = contact1;

            //Second tenant
            var t2 = new Tenant();
            t2.FirstName = "Lewis";
            t2.LastName = "Miller";
            t2.BirthDate = new DateTime(1987, 06, 16);
            t2.AvailableToMoveOn = new DateTime(2023, 09, 01);
            t2.MustMoveInOnThisDate = new DateTime(2023, 09, 01);
            t2.JobTitle = "Accountant";
            t2.Nationality = "British";
            t2.Salary = 50000;
            t2.Children = false;
            t2.Pets = true;
            t2.Smoker = false;
            t2.RentalTerm = 18;
            t2.Gender = Gender.Male;
            t2.FloorSizeRequired = 55;
            t2.GardenRequired = true;
            t2.ParkingRequired = true;
            t2.FurnitureRequired = false;
            t2.BedRoomsRequired = 3;
            t2.Budget = 2500;
            t2.WheelChairAccessNeeded = SearchCriteriaFilter.WheelChairAccessible;
            t2.ElevatorAccessRequired = SearchCriteriaFilter.Elevator;
            t2.CouncilTaxBand = CouncilTaxBand.Band_D;
            t2.TenantPreferredHomeType = TypeOfHome.House;
            t2.TenantPreferredEnergyType = EnergyType.Solar;

            var a2 = new Address();
            a2.DoorNumber = 13;
            a2.Street = "North Parade road";
            a2.City = "Bath";
            a2.PostCode = "BA2 4AL";
            t2.Address = a2;

            var prefAddress2 = new Address();
            prefAddress2.DoorNumber = 33;
            prefAddress2.Street = "Foley Street";
            prefAddress2.City = "London";
            prefAddress2.PostCode = "W1W 7TL";
            t2.PreferredAdress = prefAddress2;

            var contact2 = new ContactInformation();
            contact2.PhoneNumber = "07912384721";
            contact2.Email = new MailAddress("lewis.miller@gmail.com");

            //Third tenant
            var t3 = new Tenant();
            t3.FirstName = "Rachel";
            t3.LastName = "Johnson";
            t3.BirthDate = new DateTime(1970, 04, 27);
            t3.AvailableToMoveOn = new DateTime(2023, 08, 21);
            t3.MustMoveInOnThisDate = new DateTime(2023, 08, 23);
            t3.JobTitle = "Business development manager";
            t3.Nationality = "British";
            t3.Salary = 150555;
            t3.Children = true;
            t3.Pets = true;
            t3.Smoker = true;
            t3.RentalTerm = 12;
            t3.Gender = Gender.Female;
            t3.FloorSizeRequired = 30;
            t3.GardenRequired = false;
            t3.ParkingRequired = true;
            t3.FurnitureRequired = false;
            t3.BedRoomsRequired = 3;
            t3.ElevatorAccessRequired = SearchCriteriaFilter.Elevator;
            t3.CouncilTaxBand = CouncilTaxBand.Band_C;
            t3.TenantPreferredHomeType = TypeOfHome.House;
            t3.TenantPreferredEnergyType = EnergyType.Gas;
            t3.Budget = 4500;

            var a3 = new Address();
            a3.DoorNumber = 64;
            a3.Street = "West Street";
            a3.City = "London";
            a3.PostCode = "WC2H 9NQ";
            t3.Address = a3;

            var contact3 = new ContactInformation();
            contact3.PhoneNumber = "07712484721";
            contact3.Email = new MailAddress("rachel.johnson@gmail.com");
            
            var prefAddress3 = new Address();
            prefAddress3.DoorNumber = 22;
            prefAddress3.Street = "Holborn";
            prefAddress3.City = "London";
            prefAddress3.PostCode = "EC1N 2TD";
            t3.PreferredAdress = prefAddress3;
            
            //4th tenant
            var t4 = new Tenant();
            t4.FirstName = "Natasha";
            t4.LastName = "Devon";
            t4.BirthDate = new DateTime(1980, 02, 04);
            t4.AvailableToMoveOn = new DateTime(2023, 08, 01);
            t4.MustMoveInOnThisDate = new DateTime(2023, 08, 10);
            t4.JobTitle = "Librarian";
            t4.Nationality = "British";
            t4.Salary = 150555;
            t4.Children = false;
            t4.Pets = true;
            t4.Smoker = false;
            t4.RentalTerm = 12;
            t4.Gender = Gender.Female;
            t4.FloorSizeRequired = 30;
            t4.GardenRequired = false;
            t4.ParkingRequired = false;
            t4.FurnitureRequired = false;
            t4.BedRoomsRequired = 1;
            t4.AvailableToMoveOn = new DateTime(2023, 01, 01);
            t4.MustMoveInOnThisDate = new DateTime(2023, 01, 13);
            t4.ElevatorAccessRequired = SearchCriteriaFilter.Elevator;
            t4.CouncilTaxBand = CouncilTaxBand.Band_B;
            t4.TenantPreferredHomeType = TypeOfHome.Flat;
            t4.TenantPreferredEnergyType = EnergyType.Electric;
            t4.Budget = 1250;

            var a4 = new Address();
            a4.DoorNumber = 16;
            a4.Street = "High Street";
            a4.City = "London";
            a4.PostCode = "W5 5DB";
            t4.Address = a4;

            var contact4 = new ContactInformation();
            contact4.PhoneNumber = "07712484721";
            contact4.Email = new MailAddress("natasha.devon@gmail.com");
            
            var prefAddress4 = new Address();
            prefAddress4.DoorNumber = 22;
            prefAddress4.Street = "Holborn";
            prefAddress4.City = "London";
            prefAddress4.PostCode = "EC1N 2TD";
            t4.PreferredAdress = prefAddress4;
            
            //5th tenant
            var t5 = new Tenant();
            t5.FirstName = "Laurent";
            t5.LastName = "Sevran";
            t5.BirthDate = new DateTime(1964, 07, 26);
            t5.AvailableToMoveOn = new DateTime(2023, 10, 01);
            t5.MustMoveInOnThisDate = new DateTime(2023, 10, 10);
            t5.JobTitle = "Teacher";
            t5.Nationality = "French";
            t5.Salary = 52357;
            t5.Children = true;
            t5.Pets = false;
            t5.Smoker = true;
            t5.RentalTerm = 12;
            t5.Gender = Gender.Male;
            t5.FloorSizeRequired = 35;
            t5.GardenRequired = false;
            t5.ParkingRequired = false;
            t5.FurnitureRequired = false;
            t5.BedRoomsRequired = 1;
            t5.AvailableToMoveOn = new DateTime(2022, 12, 14);
            t5.MustMoveInOnThisDate = new DateTime(2023, 01, 10);
            t5.ElevatorAccessRequired = SearchCriteriaFilter.Elevator;
            t5.WheelChairAccessNeeded = SearchCriteriaFilter.WheelChairAccessible;
            t5.CouncilTaxBand = CouncilTaxBand.Band_D;
            t5.TenantPreferredHomeType = TypeOfHome.Flat;
            t5.TenantPreferredEnergyType = EnergyType.Electric;
            t5.Budget = 2200;

            var a5 = new Address();
            a5.DoorNumber = 16;
            a5.Street = "South Kensington";
            a5.City = "London";
            a5.PostCode = "SW7 4RB";
            t5.Address = a5;

            var contact5 = new ContactInformation();
            contact5.PhoneNumber = "07712484727";
            contact5.Email = new MailAddress("laurent.sevran@gmail.com");
            
            var prefAddress5 = new Address();
            prefAddress5.DoorNumber = 22;
            prefAddress5.Street = "Holborn";
            prefAddress5.City = "London";
            prefAddress5.PostCode = "EC1N 2TD";
            t5.PreferredAdress = prefAddress5;
            
            //6th tenant
            var t6 = new Tenant();
            t6.FirstName = "Ali";
            t6.LastName = "Nachef";
            t6.BirthDate = new DateTime(1961, 03, 13);
            t6.AvailableToMoveOn = new DateTime(2023, 12, 14);
            t6.MustMoveInOnThisDate = new DateTime(2023, 12, 23);
            t6.JobTitle = "Civil Engineer";
            t6.Nationality = "Lebanese";
            t6.Salary = 76317;
            t6.Children = true;
            t6.Pets = false;
            t6.Smoker = false;
            t6.RentalTerm = 12;
            t6.Gender = Gender.Male;
            t6.FloorSizeRequired = 30;
            t6.GardenRequired = true;
            t6.ParkingRequired = true;
            t6.FurnitureRequired = false;
            t6.BedRoomsRequired = 2;
            t6.CouncilTaxBand = CouncilTaxBand.Band_D;
            t6.TenantPreferredHomeType = TypeOfHome.Bungalow;
            t6.TenantPreferredEnergyType = EnergyType.Gas;
            t6.Budget = 5200;

            var a6 = new Address();
            a6.DoorNumber = 16;
            a6.Street = "Edgware road";
            a6.City = "London";
            a6.PostCode = "W2 2JE";
            t6.Address = a6;

            var contact6 = new ContactInformation();
            contact6.PhoneNumber = "07717487721";
            contact6.Email = new MailAddress("ali.nachef@gmail.com");
            
            var prefAddress6 = new Address();
            prefAddress6.DoorNumber = 22;
            prefAddress6.Street = "Holborn";
            prefAddress6.City = "London";
            prefAddress6.PostCode = "EC1N 2TD";
            t6.PreferredAdress = prefAddress6;
            
            //7th tenant
            var t7 = new Tenant();
            t7.FirstName = "George";
            t7.LastName = "Carlin";
            t7.BirthDate = new DateTime(1956, 03, 21);
            t6.AvailableToMoveOn = new DateTime(2023, 12, 11);
            t6.MustMoveInOnThisDate = new DateTime(2023, 12, 11);
            t7.JobTitle = "Comedian";
            t7.Nationality = "American";
            t7.Salary = 250123;
            t7.Children = true;
            t7.Pets = false;
            t7.Smoker = false;
            t7.RentalTerm = 12;
            t7.Gender = Gender.Male;
            t7.FloorSizeRequired = 30;
            t7.GardenRequired = true;
            t7.ParkingRequired = false;
            t7.FurnitureRequired = true;
            t7.BedRoomsRequired = 3;
            t7.CouncilTaxBand = CouncilTaxBand.Band_B;
            t7.TenantPreferredHomeType = TypeOfHome.House;
            t7.TenantPreferredEnergyType = EnergyType.Gas;
            t7.Budget = 7200;

            var a7 = new Address();
            a7.DoorNumber = 119;
            a7.Street = "Holland Park Avenue";
            a7.City = "London";
            a7.PostCode = "W11 4UE";
            t7.Address = a7;

            var contact7 = new ContactInformation();
            contact7.PhoneNumber = "07832091284";
            contact7.Email = new MailAddress("george.carlin@gmail.com");
            
            var prefAddress7 = new Address();
            prefAddress7.DoorNumber = 44;
            prefAddress7.Street = "Essex Rd";
            prefAddress7.City = "London";
            prefAddress7.PostCode = "N1 8LN";
            t7.PreferredAdress = prefAddress7;
            
            //8th tenant           
            var t8 = new Tenant();
            t8.FirstName = "Michael";
            t8.LastName = "Evans";
            t8.BirthDate = new DateTime(1989, 03, 12);
            t8.AvailableToMoveOn = new DateTime(2023, 09, 23);
            t8.MustMoveInOnThisDate = new DateTime(2023, 09, 30);
            t8.JobTitle = "Marketing executive";
            t8.Nationality = "British";
            t8.Salary = 45000;
            t8.Children = false;
            t8.Pets = true;
            t8.Smoker = false;
            t8.RentalTerm = 24;
            t8.Gender = Gender.Male;
            t8.FloorSizeRequired = 100;
            t8.GardenRequired = true;
            t8.ParkingRequired = true;
            t8.FurnitureRequired = true;
            t8.BedRoomsRequired = 5;
            t8.CouncilTaxBand = CouncilTaxBand.Band_A;
            t8.TenantPreferredHomeType = TypeOfHome.House;
            t8.TenantPreferredEnergyType = EnergyType.Gas;
            t8.Budget = 4200;
            
            var a8 = new Address();
            a8.DoorNumber = 119;
            a8.Street = "Holland Park Avenue";
            a8.City = "London";
            a8.PostCode = "W11 4UE";
            t8.Address = a8;
            
            var contact8 = new ContactInformation();
            contact8.PhoneNumber = "07832091284";
            contact8.Email = new MailAddress("michael.evans@gmail.com");

            var prefAddress8 = new Address();
            prefAddress8.DoorNumber = 37;
            prefAddress8.Street = "Berners St";
            prefAddress8.City = "London";
            prefAddress8.PostCode = "W1T 3LZ";
            t8.PreferredAdress = prefAddress8;

            //9th tenant
            var t9 = new Tenant();
            t9.FirstName = "William";
            t9.LastName = "White";
            t9.BirthDate = new DateTime(1976, 07, 26);
            t9.AvailableToMoveOn = new DateTime(2023, 11, 05);
            t9.JobTitle = "HR director";
            t9.Nationality = "British";
            t9.Salary = 122357;
            t9.Children = true;
            t9.Pets = false;
            t9.Smoker = true;
            t9.RentalTerm = 12;
            t9.Gender = Gender.Male;
            t9.FloorSizeRequired = 100;
            t9.GardenRequired = false;
            t9.ParkingRequired = true;
            t9.FurnitureRequired = true;
            t9.BedRoomsRequired = 5;
            t9.CouncilTaxBand = CouncilTaxBand.Band_C;
            t9.TenantPreferredHomeType = TypeOfHome.House;
            t9.TenantPreferredEnergyType = EnergyType.Gas;
            t9.Budget = 6000;

            var a9 = new Address();
            a9.DoorNumber = 19;
            a9.Street = "Driver street";
            a9.City = "London";
            a9.PostCode = "W6 2EZ";
            t9.Address = a9;

            var contact9 = new ContactInformation();
            contact9.PhoneNumber = "07817321284";
            contact9.Email = new MailAddress("william.white@gmail.com");

            var prefAddress9 = new Address();
            prefAddress9.DoorNumber = 53;
            prefAddress9.Street = "Cleveland St";
            prefAddress9.City = "London";
            prefAddress9.PostCode = "W1T 4JJ";
            t9.PreferredAdress = prefAddress9;

            //10th tenant
            var t10 = new Tenant();
            t10.FirstName = "Benjamin";
            t10.LastName = "Sterling";
            t10.BirthDate = new DateTime(1998, 03, 04);
            t10.AvailableToMoveOn = new DateTime(2023, 08, 27);
            t10.MustMoveInOnThisDate = new DateTime(2023, 08, 29);
            t10.JobTitle = "Garden designer";
            t10.Nationality = "British";
            t10.Salary = 66310;
            t10.Children = false;
            t10.Pets = false;
            t10.Smoker = false;
            t10.RentalTerm = 6;
            t10.Gender = Gender.Male;
            t10.FloorSizeRequired = 60;
            t10.GardenRequired = false;
            t10.ParkingRequired = true;
            t10.FurnitureRequired = false;
            t10.BedRoomsRequired = 3;
            t10.CouncilTaxBand = CouncilTaxBand.Band_A;
            t10.TenantPreferredHomeType = TypeOfHome.Flat;
            t10.TenantPreferredEnergyType = EnergyType.Gas;
            t10.Budget = 5400;

            var a10 = new Address();
            a10.DoorNumber = 190;
            a10.Street = "Middleton road";
            a10.City = "London";
            a10.PostCode = "W9 4XV";
            t10.Address = a10;

            var contact10 = new ContactInformation();
            contact10.PhoneNumber = "07817321284";
            contact10.Email = new MailAddress("benjamin.sterling@gmail.com");
            t10.ContactInformation = contact10;

            var prefAddress10 = new Address();
            prefAddress10.DoorNumber = 66;
            prefAddress10.Street = "Whitfield St";
            prefAddress10.City = "London";
            prefAddress10.PostCode = "W1T 4EY";
            t10.PreferredAdress = prefAddress10;

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

        /// <summary>
        /// Generates a list of mock landlords 
        /// </summary>
        /// <returns></returns>
        public static List<Landlord> GenerateMockListOfLandlords()
        {
            //First landlord
            Landlord landlord1 = new Landlord();
            landlord1.FirstName = "Jomana";
            landlord1.LastName = "Madieh";

            ContactInformation contact1 = new ContactInformation();
            contact1.PhoneNumber = "07182738292";
            contact1.Email = new MailAddress("rida.serroukh@gmail.com");
            landlord1.ContactInformation = contact1;


            var LandlordList = new List<Landlord>();
            LandlordList.Add(landlord1);

            return LandlordList;
        }
        
        /// <summary>
        /// Overall rating is calculated to determine how suitable the home is for a tenant
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="rentalHome"></param>
        /// <returns>Rating</returns>
        public static double PointsScoredForEachHome(Tenant tenant, RentalHome rentalHome, string googleAPIKey)
        {
            try
            {

                double points = 0;

                if (tenant.Smoker == rentalHome.SmokingAllowed || tenant.Smoker == false)
                {
                    points += 10;
                }
                if (tenant.CouncilTaxBand == rentalHome.CouncilTaxBand)
                {
                    points += 10;
                }
                if (tenant.WheelChairAccessNeeded == rentalHome.WheelChairAccess)
                {
                    points += 10;
                }
                if (tenant.Pets != rentalHome.PetsAllowed && tenant.Pets == true)
                {
                    points += 10;
                }
                if (tenant.Children != rentalHome.ChildrenAllowed && tenant.Children == true)
                {
                    points += 5;
                }
                if (tenant.Budget > rentalHome.Price)
                {
                    double score;
                    score = tenant.Budget / rentalHome.Price * 100;
                    points = points + score;
                }
                if (tenant.FurnitureRequired != rentalHome.Furnished && tenant.FurnitureRequired == true)
                {
                    points += 5;
                }
                if (tenant.ParkingRequired != rentalHome.Parking && tenant.ParkingRequired == true)
                {
                    points += 5;
                }
                if (tenant.GardenRequired != rentalHome.Garden && tenant.GardenRequired == true)
                {
                    points += 5;
                }
                if (tenant.ElevatorAccessRequired == rentalHome.ElevatorAvailable)
                {
                    points += 10;
                }
                if (rentalHome.HomeDetails.TotalBedrooms >= tenant.BedRoomsRequired)
                {
                    points += 15;

                }
                if (rentalHome.FloorSize >= tenant.FloorSizeRequired)
                {
                    points += 20;
                }
                if (rentalHome.FloorSize < tenant.FloorSizeRequired)
                {
                    double sizeDifference = rentalHome.FloorSize / tenant.FloorSizeRequired;
                    points += sizeDifference * 20;
                }
                //find the differnece in days between rental home avail. and moving in date
                //if move in date is after or equal to availability then award points
                //else no points
                //this check is only for people that have a real deadline
                TimeSpan timeDiffBetweenTenantAndHomeAvailablity = rentalHome.AvailableOn.Subtract(tenant.MustMoveInOnThisDate);
                double Days = timeDiffBetweenTenantAndHomeAvailablity.Days;
                //DateTime.MinValue here indicates that the tenant has not set a deadline that they need to move in by
                if (Days <= 0 || tenant.MustMoveInOnThisDate.Equals(DateTime.MinValue))
                {
                    points += 200;
                }
                else
                {
                    return 0;
                }
                int walkingDistanceValue = DistanceCalculation(tenant.PreferredAdress, rentalHome.Address, googleAPIKey);
                int maximumAcceptedwalkingDistanceValue = 5000;
                if (walkingDistanceValue <= maximumAcceptedwalkingDistanceValue)
                {
                    points = maximumAcceptedwalkingDistanceValue - walkingDistanceValue;
                    points = points / 100;
                    points += points;
                }
                return points;

            }

            catch (Exception ex)
            {
             Log.Error($"ERROR: {ex.Message}");

            }
            return 0;

        }
        /// <summary>
        /// The monthly rent is multiplied by 12 to give the total for the year.
        /// Once the total for the year is added up, it is then checked that the total is twice the yearly salary of the prospective tenant. 
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="rentalHome"></param>
        /// <returns></returns>
        public static bool AffordabilityCheck(Tenant tenant, RentalHome rentalHome)
        {
            double months = 12;
            double check = months * rentalHome.Price;
            double decision = check * 2;
            if (tenant.Salary >= decision)
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Performs a distance calculation based on the origin address and the destination address
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="destination"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        public static int DistanceCalculation(Address origin, Address destination, string apiKey)
        {
            WriteToLog();

            try
            {

                string start = JsonConvert.SerializeObject(origin);
                string end = JsonConvert.SerializeObject(destination);

                WebClient client = new WebClient();
                var body = client.DownloadString($"https://maps.googleapis.com/maps/api/distancematrix/json?destinations={end}&origins={start}&unitsimperial&mode=walking&key={apiKey}");
                var distance = JsonConvert.DeserializeObject<GMapsJsonObj>(body);
                int distanceInt = distance.rows[0].elements[0].distance.value;

                return distanceInt;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static Address GeoCodeAddress(string inputAddress, string api)
        {

            WriteToLog();

            try
            {


                WebClient client = new WebClient();
                String body = client.DownloadString($"https://maps.googleapis.com/maps/api/geocode/json?address={inputAddress}&key={api}");
                GeoCodeJsonObj geoCodeResponse = JsonConvert.DeserializeObject<GeoCodeJsonObj>(body);
                List<global::AddressComponent> adressComponents = geoCodeResponse.results[0].address_components;
                Address returnAdress = new Address();
                foreach (var component in adressComponents)
                {
                    switch (component.types.First())
                    {
                        case "street_number":
                            returnAdress.DoorNumber = int.Parse(component.long_name);
                            break;
                        case "route":
                            returnAdress.Street = component.long_name;
                            break;
                        case "street_address":
                            returnAdress.Street = component.long_name;
                            break;
                        case "postal_code":
                            returnAdress.PostCode = component.long_name;
                            break;
                        case "postal_town":
                            returnAdress.City = component.long_name;
                            break;
                    }
                }
                return returnAdress;

            }
            catch (Exception ex)
            {
 
                Log.Error($"ERROR: {ex.Message}");
                return null;
            }
        }

       
        /// <summary>
        /// This returns a list of rental homes from the website Rightmove. You can select which page you want to scrape from when the website loads
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static List<RightmoveRentalHomeData> GetDataFromRightMove(int page)
        {
            WriteToLog();

            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load($"https://www.rightmove.co.uk/property-to-rent/find.html?index={page * 24 /*pagination workins in moltiples of 24 only */}searchType=RENT&locationIdentifier=REGION%5E87490&insId=1&radius=0.0&minPrice=&maxPrice=2750&minBedrooms=&maxBedrooms=&displayPropertyType=&maxDaysSinceAdded=&sortByPriceDescending=&_includeLetAgreed=on&primaryDisplayPropertyType=&secondaryDisplayPropertyType=&oldDisplayPropertyType=&oldPrimaryDisplayPropertyType=&letType=&letFurnishType=&houseFlatShare=");

            var cardXpath = "//*[@class='propertyCard-wrapper']";
            var cardNodes = htmlDoc.DocumentNode.SelectNodes(cardXpath);

            List<RightmoveRentalHomeData> ListOfRightMoveHomes = new List<RightmoveRentalHomeData>();

            foreach (var node in cardNodes)
            {
                HtmlNode priceNode = node.SelectSingleNode(".//*[@class='propertyCard-priceValue']");
                HtmlNode contactNode = node.SelectSingleNode(".//*[@class='propertyCard-contactsPhoneNumber']");
                HtmlNode addressNode = node.SelectSingleNode(".//*[@class='propertyCard-address']");
                HtmlNode homeDetailsNode = node.SelectSingleNode(".//div[@class='propertyCard-details']");
                HtmlNode homeDescriptionNode = node.SelectSingleNode(".//div[@class='propertyCard-description']");
                HtmlNode dateRentalHomeWasAddedNode = node.SelectSingleNode(".//span[@class='propertyCard-branchSummary-addedOrReduced']");

                string rentalHomeprice = priceNode.InnerText;
                string rentalHomepriceReplacedChar = rentalHomeprice;
                string result = rentalHomepriceReplacedChar.Replace("£", "").Replace("pcm", "");
                double convertedMonthlyRentalPrice;

                bool parseOK = double.TryParse(result, out convertedMonthlyRentalPrice);

                if (!parseOK)
                {
                    Log.Error("Parse did not go well!");
                }

                string agentPhoneNumber = contactNode.InnerHtml;
                string rentalHomeAddress = addressNode.InnerText.Trim();
                string rentalHomeDetails = homeDetailsNode.InnerText.Trim();
                string rentalHomeDescription = homeDescriptionNode.InnerText.Trim();

                try
                {
                    var dateRentalHomeWasAdded = dateRentalHomeWasAddedNode.InnerHtml;
                    DateTime today = DateTime.Now;
                    DateTime convertedtDate;

                    if (dateRentalHomeWasAdded.Contains("Added today") || dateRentalHomeWasAdded.Contains("Reduced today") || dateRentalHomeWasAdded.Contains("Reduced on")
                         || dateRentalHomeWasAdded.Contains("Added on") || dateRentalHomeWasAdded.Contains(""))
                        convertedtDate = today;
                    else
                        convertedtDate = DateTime.Parse(dateRentalHomeWasAdded.ToString());

                    RightmoveRentalHomeData ScrapedDataStorage = new RightmoveRentalHomeData(convertedMonthlyRentalPrice, agentPhoneNumber, rentalHomeAddress, rentalHomeDetails, rentalHomeDescription, convertedtDate);
                    ListOfRightMoveHomes.Add(ScrapedDataStorage);
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "System.FormatException:");
                }
            }
            return ListOfRightMoveHomes;
        }

        
        public static List<RightmoveRentalHomeData> LoadRightMoveDataList(string path)
        {
            List<RightmoveRentalHomeData> RightMoveRentalHomesList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<RightmoveRentalHomeData>));
            using (FileStream file = File.OpenRead(path))
            {
                RightMoveRentalHomesList = serializer.Deserialize(file) as List<RightmoveRentalHomeData>;
            }
            return RightMoveRentalHomesList;
        }

        /// <summary>
        /// When attempting to run this method, a 403 error may occur.
        /// To resolve this issue, it is recommended to analyze the cookie string 
        /// sent by the client (Web browser) using Fiddler. Once the cookie string 
        /// has been identified, it can be copied into the method's headers collection.
        /// However, it's worth noting that this cookie string has an expiry time, 
        /// which means that it will need to be updated every time the method is run. 
        /// This can be an inconvenience.
        /// Initially, it was thought that the WebProxy class would be necessary to fix the 403 error, but it turns out that only the user-agent and cookie string are required. </summary>
        /// <returns></returns>
        public static List<ZooplaHomeRentalData> GetDataFromZoopla()
        {
            WriteToLog();
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            client.Headers.Add(HttpRequestHeader.Cookie, "Cookie: zooplapsid=203c5e1cd0a54addaab69355590034e8; ajs_anonymous_id=5659da3fea2e4938bb1a1e86c0989052; base_device_id=9947c09a-4385-47c5-9b7b-2651189d9191; cookie_consents={\"schemaVersion\":4,\"content\":{\"brand\":1,\"consents\":[{\"apiVersion\":1,\"stored\":false,\"date\":\"Sat, 29 Apr 2023 15:31:00 GMT\",\"categories\":[{\"id\":1,\"consentGiven\":true},{\"id\":3,\"consentGiven\":true},{\"id\":4,\"consentGiven\":true}]}]}}; zid=0712466a1af34cf5b4d689b675f35cde; zooplasid=0712466a1af34cf5b4d689b675f35cde; forced_features={}; forced_experiments={}; active_session=anon; g_state={\"i_p\":1683040976409,\"i_l\":2}; base_session_start_page=https://www.zoopla.co.uk/to-rent/property/nottingham/?price_frequency=per_month&q=Nottingham&search_source=home; base_referrer=https://www.zoopla.co.uk/to-rent/property/nottingham/?price_frequency=per_month&q=Nottingham&search_source=home&__cf_chl_tk=Dr3Ub_kPNuaRJptjnm7mP_Cx7FJZzn0Nhyo5sPVUP.0-1682954164-0-gaNycGzNDpA; base_request=https://www.zoopla.co.uk/to-rent/property/nottingham/; base_session_id=ca939f9c-eb00-40ff-a2ea-b9a4cbf07025; base_session_count=9; cf_chl_2=0eff248a230df49; cf_clearance=mOkT9Dh8MuXjbwoA2P5aXMT7KwJOMAxltmmSyvB7RSI-1682964820-0-250; __cf_bm=eKSQnYl3zieE_7xqjkvM7GIn0QQzCb8o.FMug7PfAuw-1682964842-0-AfIH1ubPsMNjNxW3EAU1vs0IRes8jZmT7FUftYHPt0B8J75GxM7U5/hCcuWzG532nVwImhFJK0rauZflTfkH6K/0XegXYUnMlAal8ojJk6aQDW2ITxhy3FTducfo2Ji07xUDqBaDjkQ2QxjFAz2052c=");
            String body = client.DownloadString($"https://www.zoopla.co.uk/to-rent/property/nottingham/?price_frequency=per_month&q=Nottingham&search_source=home");
            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(body);
            var cardXpath = "//*[@class='kii3au0 _1ftx2fq5']";
            var cardNodes = html.DocumentNode.SelectNodes(cardXpath);
            List<ZooplaHomeRentalData> zooplaHomeRentalData = new List<ZooplaHomeRentalData>();
            foreach (var node in cardNodes)
            {
                var priceNode = node.SelectSingleNode("//*[@data-testid='listing-price']");
                string price = priceNode.InnerText;
                Console.WriteLine(price);
            }
            return zooplaHomeRentalData;
        }

        /// <summary>
        /// Creates a PDF document intended for tenants to attach to the email sent to landlords.
        /// </summary>
        /// <param name="tenantProfile"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        public static PdfDocument CreatedPdfDoc(Tenant tenantProfile, string outputPath)
        {
            WriteToLog();

            try
            {

                PdfWriter writer = new PdfWriter(outputPath);
                PdfDocument pdfDoc = new PdfDocument(writer);
                Document document = new Document(pdfDoc);

                string text = tenantProfile.ToString();
                document.Add(new Paragraph(text));
                document.Close();

                return pdfDoc;

            }
            catch (Exception ex)
            {

                Log.Error("Conversion to PDF did not go well!");
                Console.WriteLine("An error occurred while converting to PDF: " + ex.Message);
                return null;

            }
        }

        public static void WriteDataStorage(DataStorage lists, string path)
        {
            WriteToLog();

            try
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
            catch (Exception exceptionMessage)
            {
                Log.Error($"ERROR: {exceptionMessage.Message}");
            }
        }

        public static DataStorage LoadDataStorage(string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataStorage));

                using (FileStream file = File.OpenRead(path))
                {
                    var xmlReaderSettings = new XmlReaderSettings()
                    {
                        IgnoreWhitespace = true
                    };

                    using (XmlReader xmlReader = XmlReader.Create(file, xmlReaderSettings))
                    {
                        DataStorage deserializedDataStorage = (DataStorage)xmlSerializer.Deserialize(xmlReader);
                        return deserializedDataStorage;
                    }
                }
            }
            catch(Exception exception)
            {
                Log.Error($"ERROR: {exception.Message}");
                return null;
            }
        }
        



        public static void WriteRightMoveRentalHomesList(List<RightmoveRentalHomeData> ListOfRightMoveHomes, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<RightmoveRentalHomeData>));
            using (FileStream file = File.Create(path))
            {
                serializer.Serialize(file, ListOfRightMoveHomes);
            }
        }



    }
}

