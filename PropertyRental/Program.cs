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
            
            //DisplayMatch(Matches);

            //RatingScore(TenantList[0], RentalHomes[0]);

            RatingScore(TenantList[1], RentalHomes[1]);

            //TODO: Add the distance calculation to the Rating method  

        }

    }
}