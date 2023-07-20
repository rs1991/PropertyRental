using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;


namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*var stroedData = new DataStorage();
            stroedData = LoadDataStorage(@"c:\....");
            */

            string path = @"C:\tmp\MockDataStorage.xml";
            string googleAPIKey = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\apiKey.txt");
            //string rightMoveRentalHomespath = @"C:\tmp\RightMoveRentalHomesList.xml";
            string newlyCreatedPdfPath = @"C:\tmp\attachment.pdf";


            List<Tenant> TenantList = GenerateMockListOfTenants();
            List<RentalHome> RentalHomesList = GenerateMockRentalHomesList();
            List<Address> AddressList = GenerateMockAddressList();
            List<Landlord> landlordList = GenerateMockListOfLandlords();
            List<RightmoveRentalHomeData> RightMoveHomesList = GetDataFromRightMove(1);

            for (int i = 2; i < 5; i++)
            {
                RightMoveHomesList.AddRange(GetDataFromRightMove(i));
            }


            var dStorage = new DataStorage();



            dStorage.ListOfTenants = TenantList;
            dStorage.ListOfRentalHomes = RentalHomesList;
            dStorage.ListOfAddresses = AddressList;
            dStorage.ListOfRightMoveHomes = RightMoveHomesList;
            dStorage.ListOfLandlords = landlordList;

            AddRightMoveHomeToRentalHome(RightMoveHomesList, RentalHomesList, googleAPIKey);

            WriteDataStorage(dStorage, path);

            //Parameters for the SendRentalApplication method
            string emailSubject = "I would love to rent your home";
            string emailBody = $"Dear {landlordList[0].FirstName},\n\n" +
                    $"I am interested in renting your property and have attached my rental application for your review.\n\n" +
                    $"Please let me know if you require any additional information or documentation.\n\n" +
                    $"Thank you,\n{TenantList[0].FirstName} {TenantList[0].LastName}";

            string smtpUserName = "rida.serroukh@gmail.com";
            string smtpPassword = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\Password.txt");
            string smtpServer = "smtp-relay.sendinblue.com";
            int smtpPort = 587;


            


                       

        }
    }
}
