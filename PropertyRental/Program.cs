
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;


using static System.Formats.Asn1.AsnWriter;

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

            List<RentalHomePointsScore> Scores = ScoreListForEachHome(TenantList, RentalHomes, api);

            //displayScoreOnly(Scores);

            GetDataFromWeb();

           

        }

    }
}