
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;
using System.Runtime.Intrinsics.Arm;
using Newtonsoft.Json;

namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var path = @"C:\tmp\MockDataStorage.xml";
            string api = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\apiKey.txt");


            //List<Tenant> TenantList = LogicMethods.GenerateMockListOfTenants();
            //List<RentalHome> RentalHomes = LogicMethods.GenerateMockRentalPropertyList();
            //List<Address> AddressList = LogicMethods.GenerateMockAddressList();

            //var dStorage = new DataStorage();

            //dStorage.ListOfTenants = TenantList;
            //dStorage.ListOfRentalHomes = RentalHomes;
            //dStorage.ListOfAddresses = AddressList;
            //WriteDataStorage(dStorage, path);


            List<RightmoveRentalHomeData> RightMoveHomesList = GetDataFromWeb();

            RightmoveRentalHomeData rmHome = new RightmoveRentalHomeData(2345, "0781273819", "18 Zulla road Nottingham", "Great location", "2 bedrooms, 1 bathroom", new DateTime(2023, 01, 20));
            
            string testAddress = "18 Zulla road Nottingham";


            RentalHome rentalhome1 = new RentalHome(rmHome, testAddress, api);

            Console.WriteLine($"Test Rental home: {rentalhome1.Address.DoorNumber} {rentalhome1.Address.Street} {rentalhome1.Address.City} {rentalhome1.Address.PostCode}");






        }

    }
}