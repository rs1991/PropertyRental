using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;


namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        

            //Paths and keys
            string path = @"C:\tmp\MockDataStorage.xml";
            string googleAPIKey = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\apiKey.txt");
            string newlyCreatedPdfPath = @"C:\tmp\attachment.pdf";

            
            //Generate mock data 

            List<Tenant> TenantList = GenerateMockListOfTenants();
            List<RentalHome> RentalHomesList = GenerateMockRentalHomesList();
            List<Address> AddressList = GenerateMockAddressList();
            List<Landlord> landlordList = GenerateMockListOfLandlords();

            //Insert the pages you wish to extract from the RightMove website
            int startPage = 1;
            int endPage = 4;

            //Fetches RightMove data
            List<RightmoveRentalHomeData> RightMoveHomesList = GetMultiplePagesFromRightMove(startPage, endPage);

            //Add RightMove data to rental homes list
            RentalHomesList = AddRightMoveHomeToRentalHome(RightMoveHomesList, RentalHomesList, googleAPIKey);


            //Prepare data storage 
            var dStorage = new DataStorage();
            dStorage.ListOfTenants = TenantList;
            dStorage.ListOfRentalHomes = RentalHomesList;
            dStorage.ListOfAddresses = AddressList;
            dStorage.ListOfRightMoveHomes = RightMoveHomesList;
            dStorage.ListOfLandlords = landlordList;

            
            //Write DataStorage to to XML
            WriteDataStorage(dStorage, path);

            //Load DataStorage from to XML
            var loadedDataStorage = LoadDataStorage(path);
                        

            List<Tenant> loadedTenantList = loadedDataStorage.ListOfTenants;
            List<RentalHome> loadedRentalHomesList = loadedDataStorage.ListOfRentalHomes;

            ProcessTenantAndRentalHomes(loadedTenantList, loadedRentalHomesList, googleAPIKey);

        }
    }
}


/*Parameters for the SendRentalApplication method
            
            string emailSubject = "I would love to rent your home";
            string emailBody = $"Dear {landlordList[0].FirstName},\n\n" +
                    $"I am interested in renting your property and have attached my rental application for your review.\n\n" +
                    $"Please let me know if you require any additional information or documentation.\n\n" +
                    $"Thank you,\n{TenantList[0].FirstName} {TenantList[0].LastName}";

            string smtpUserName = "rida.serroukh@gmail.com";
            string smtpPassword = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\Password.txt");
            string smtpServer = "smtp-relay.sendinblue.com";
            int smtpPort = 587;
            */

//SendRentalApplication(TenantList[0], landlordList[0], smtpServer, smtpPort, smtpUserName, smtpPassword, emailSubject, emailBody, newlyCreatedPdfPath);

//PointsScoredForEachHome(TenantList, RentalHomesList, googleAPIKey);
