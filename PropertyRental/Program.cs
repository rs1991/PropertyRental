using System;
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;


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
            Tenant.Budget = 122000;
            Tenant.FurnitureRequired = false;
            Tenant.ParkingRequired = false;
            Tenant.GardenRequired = false;
            Tenant.BedRoomsRequired = 3;


            List<RentalHome> Matches = MatchTenantWithHome(Tenant, RentalHomes);
            
            DisplayMatch(Matches);

            
            //TODO: Build a rating system in the form of a class 

        }

    }
}