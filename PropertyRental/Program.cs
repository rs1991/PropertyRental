
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;
//using static PropertyRental.LogFile;



using Serilog;

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

            //List<RentalHomePointsScore> Scores = ScoreListForEachHome(TenantList, RentalHomes, api);

            //displayScoreOnly(Scores);

            GetDataFromWeb();



            //WriteToLog();
            
            
            /*
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Error Message");
            }
            */


        }

    }
}