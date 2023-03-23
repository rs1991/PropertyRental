
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



            RightmoveRentalHomeData rmHome = new RightmoveRentalHomeData(2345, "0781273819", "Newman Street, London", "Great location", "2 bedrooms, 1 bathroom", new DateTime(2023, 01, 20));

            Console.WriteLine($"{rmHome.RentalHomeAddress} {rmHome.MonthlyRentalPrice}");

            string testAddress = "23 Newman street london ";


            RentalHome rentalhome1 = new RentalHome(rmHome, testAddress, api);
            Console.WriteLine(rentalhome1.Address);


        }

    }
}