using System;
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;
using System.Net.Http;
using Newtonsoft.Json;

namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var path = @"C:\tmp\MockDataStorage.xml";
            string api = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\apiKey.txt");


            List<Tenant> TenantList = LogicMethods.GenerateMockListOfTenants();
            List<RentalHome> RentalHomes = LogicMethods.GenerateMockRentalPropertyList();
            List<Address> AddressList = LogicMethods.GenerateMockAddressList();

            var dStorage = new DataStorage();

            dStorage.ListOfTenants = TenantList;
            dStorage.ListOfRentalHomes = RentalHomes;
            dStorage.ListOfAddresses = AddressList;

            WriteDataStorage(dStorage, path);

            Tenant Tenant = new Tenant();
            Tenant.Smoker = false;
            Tenant.Pets = false;
            Tenant.Children = false;
            Tenant.Budget = 8000;
            Tenant.FurnitureRequired = false;
            Tenant.ParkingRequired = false;
            Tenant.GardenRequired = false;
            Tenant.BedRoomsRequired = 3;
            Tenant.Salary = 122000;
            


            List<RentalHome> Matches = MatchTenantWithHome(Tenant, RentalHomes);
            
            DisplayMatch(Matches);

            RentalHome rentalHome = new RentalHome();
            rentalHome.Price = 4000;
            rentalHome.FloorSize = 110;
            rentalHome.BedRooms = 3;
            rentalHome.Garden = true;
            rentalHome.Parking = false;
            rentalHome.PetsAllowed = true;
            rentalHome.ChildrenAllowed = false;
            rentalHome.SmokingAllowed = true;
            //rentalHome.Address.PostCode = "SE1 1TQ";


            //RatingScore(TenantList[0], RentalHomes[0]);

            Address a1 = new Address();
            a1.DoorNumber = 121;
            a1.Street = "Holborn";
            a1.City = "London";
            a1.PostCode = "EC1N2TD";

            Address a2 = new Address();
            a2.DoorNumber = 33;
            a2.Street = "Foley st";
            a2.City = "London";
            a2.PostCode = "W1W7TL";

            string origin = JsonConvert.SerializeObject(a1);
            string destination = JsonConvert.SerializeObject(a2);


            OriginToDestinationDistance(destination, origin, api);
            
            
            //TODO: Add the distance calculation to the Rating method  

        }

    }
}