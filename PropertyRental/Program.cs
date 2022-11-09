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
            

            List<Tenant> TenantList = LogicMethods.GenerateMockListOfTenants();
            List<RentalHome> RentalHomes = LogicMethods.GenerateMockRentalPropertyList();

            var dStorage = new DataStorage();

            dStorage.ListOfTenants = TenantList;
            dStorage.ListOfRentalHomes = RentalHomes;
  

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

            AffordabilityCheck(Tenant, rentalHome);

            Address a1 = new Address();
            a1.PostCode = "NG35DB";
            
            Address a2 = new Address();
            a2.PostCode = "NG71QZ";


            DistanceInfo(a2, a1);



            //TODO: Create method that inputs two addresses and then calculates the distance
            //TODO: Add the distance calculation to the Rating method  

        }

    }
}