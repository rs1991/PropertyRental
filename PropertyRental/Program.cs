using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;


namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\tmp\MockDataStorage.xml";
            string googleAPIKey = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\apiKey.txt");
            const string rightMoveRentalHomespath = @"C:\tmp\RightMoveRentalHomesList.xml";
            string newlyCreatedPdfPath = @"C:\tmp\attahcment.pdf";


            List<Tenant> TenantList = LogicMethods.GenerateMockListOfTenants();
            List<RentalHome> RentalHomes = LogicMethods.GenerateMockRentalPropertyList();
            List<Address> AddressList = LogicMethods.GenerateMockAddressList();
            List<Landlord> landlordList = LogicMethods.GenerateMockListOfLandlords();

            //List<OpenRentData> OpenRentListOfHomes = GetDataFromOpenRent();
            List<RightmoveRentalHomeData> RightMoveHomesList = GetDataFromRightMove(2);

          
            var dStorage = new DataStorage();

            dStorage.ListOfTenants = TenantList;
            dStorage.ListOfRentalHomes = RentalHomes;
            dStorage.ListOfAddresses = AddressList;
            dStorage.ListOfRightMoveHomes = RightMoveHomesList;
            dStorage.ListOfLandlords = landlordList;
            
            WriteDataStorage(dStorage, rightMoveRentalHomespath);
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


            //AddRightMoveHomeToRentalHome(RentalHomes, RightMoveHomesList, googleAPIKey);


            SendRentalApplication(TenantList[0], landlordList[0], smtpServer, smtpPort, smtpUserName, smtpPassword, emailSubject, emailBody, newlyCreatedPdfPath);

            AddPdfAttachement(TenantList[2], newlyCreatedPdfPath);




        }

    }
}