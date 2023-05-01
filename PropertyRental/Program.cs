using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;


namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\tmp\MockDataStorage.xml";
            //string api = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\apiKey.txt");


            //List<Tenant> TenantList = LogicMethods.GenerateMockListOfTenants();
            //List<RentalHome> RentalHomes = LogicMethods.GenerateMockRentalPropertyList();
            //List<Address> AddressList = LogicMethods.GenerateMockAddressList();
            List<RightmoveRentalHomeData> RightMoveHomesList = GetDataFromRightMove(2);

            var dStorage = new DataStorage();

            //dStorage.ListOfTenants = TenantList;
            //dStorage.ListOfRentalHomes = RentalHomes;
            //dStorage.ListOfAddresses = AddressList;
            dStorage.ListOfRightMoveHomes = RightMoveHomesList;
            WriteDataStorage(dStorage, path);


            /*
            List<RightmoveRentalHomeData> ScrapedHomes =  GetDataFromWeb(5);
            LoopThroughListOfRightMoveHomes(ScrapedHomes);
            */


            
            List<ZooplaHomeRentalData> ZooplaHomes = GetDataFromZoopla();

            foreach(var zoopla in ZooplaHomes)
            {
                Console.WriteLine(zoopla);
            }
            




        }

    }
}