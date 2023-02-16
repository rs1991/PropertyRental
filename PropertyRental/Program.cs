
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

            //var hd = new RightmoveRentalHomeData();

            //var nr = new RentalHome(hd);

            
            /*Test data
            string[] values = { "1,907.76", "£1,907 pcm"};
            
            double number;

            foreach (var value in values)
            {
                if (Double.TryParse(value, out number))
                    Console.WriteLine("Able to parse", value, number);
                else
                    Console.WriteLine("Unable to parse '{0}'.", value);
            }
            */

        }

    }
}