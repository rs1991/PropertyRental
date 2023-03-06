
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;
using System.Security.Cryptography.X509Certificates;

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

            //RightmoveRentalHomeData rm1 = new RightmoveRentalHomeData(3000, "07162829028", "123 Zoo Lane", "2 bedrooms", "Lovely home", new DateTime(2022,12,01));
            
       
        }

    }
}