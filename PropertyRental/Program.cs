using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;



namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string path = @"C:\tmp\MockDataStorage.xml";
            string api = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\apiKey.txt");

            const string rightMoveRentalHomespath = @"C:\tmp\RightMoveRentalHomesList.xml";


            List<Tenant> TenantList = LogicMethods.GenerateMockListOfTenants();
            List<RentalHome> RentalHomes = LogicMethods.GenerateMockRentalPropertyList();
            List<Address> AddressList = LogicMethods.GenerateMockAddressList();

            //List<OpenRentData> OpenRentListOfHomes = GetDataFromOpenRent();
            List<RightmoveRentalHomeData> RightMoveHomesList = GetDataFromRightMove(2);

            var dStorage = new DataStorage();

            dStorage.ListOfTenants = TenantList;
            dStorage.ListOfRentalHomes = RentalHomes;
            dStorage.ListOfAddresses = AddressList;
            dStorage.ListOfRightMoveHomes = RightMoveHomesList;
            
            WriteDataStorage(dStorage, rightMoveRentalHomespath);


            /*
            List<RightmoveRentalHomeData> ScrapedHomes =  GetDataFromWeb(5);
            LoopThroughListOfRightMoveHomes(ScrapedHomes);
            */




            //RentalHomes.AddRange(RightMoveHomesList.Select(rightMoveRentalHome => new RentalHome { Price = rightMoveRentalHome.MonthlyRentalPrice, Address = rightMoveRentalHome.RentalHomeAddress.ToString() }));

            /*
            RentalHomes.AddRange(RightMoveHomesList.Select(data => data.ToRentalHome()));

            foreach(var rh in RentalHomes)
            {
                Console.WriteLine(rh.Address);
            }

            */

            ProcessTenantAndRentalHomes(TenantList, RentalHomes, api);





        }

    }
}