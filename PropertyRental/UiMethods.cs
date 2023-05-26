using HtmlAgilityPack;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Net.Mail;
using System.Numerics;
using static PropertyRental.LogicMethods;

namespace PropertyRental
{
    public class UiMethods
    {        
        
        /// <summary>
        /// Displays a compatability score based on the tenant's requirements 
        /// </summary>
        /// <param name="ScoresList"></param>
        public static void displayScoreOnly(List<RentalHomePointsScore> ScoresList)
        {
            foreach(var score in ScoresList)
            {
                Console.WriteLine($"Score: {score.Score} Address: {score.Rental.Address.PostCode} {score.Tenant.FirstName}");
            }
        }

        /// <summary>
        /// Method created to log errors and other useful information
        /// </summary>
        public static void WriteToLog()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(@"C:\tmp\log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        public static void LoopThroughListOfRightMoveHomes(List<RightmoveRentalHomeData> ScrapedHomes)
        {
            foreach (var home in ScrapedHomes) {

                Console.WriteLine($"{home.RentalHomeAddress}");
            }
        }

        public static void ProcessTenantAndRentalHomes(List<Tenant> TenantList, List<RentalHome> RentalHomes, string api)
        {
            
            foreach (Tenant tenant in TenantList)
            {

                foreach (RentalHome home in RentalHomes)
                {
                    double points = PointsScoredForEachHome(tenant, home, api);
                    Console.WriteLine(points);
                }
            }

        }
       

        public static void SendRentalApplication(Tenant tenant)
            {
            // Step 1: Validate the data in the application
            // Step 2: Once data is validated, send the application  
            if (string.IsNullOrEmpty(tenant.FirstName))
            {
                throw new ArgumentException("Enter your first name");
            }
            if (string.IsNullOrEmpty(tenant.LastName))
            {
                throw new ArgumentException("Enter your last name");
            }
            if(tenant.BirthDate == default(DateTime))
            {
                throw new ArgumentException("Please put in a valid date of birth");
            }
            if(tenant.AvailableToMoveOn == default(DateTime))
            {
                throw new ArgumentException("Put in the date that you want to move");
            }
            if(tenant.MustMoveInOnThisDate == default(DateTime))
            {
                throw new ArgumentException("The date that you need to move by");
            }
            if (string.IsNullOrEmpty(tenant.JobTitle))
            {
                throw new ArgumentException("Put in your job title");
            }
            if (string.IsNullOrEmpty(tenant.Nationality))
            { 
                throw new ArgumentException("Put in your nationality");
            }
            if(tenant.Salary <= 0)
            {
                throw new ArgumentException("Please provide your salary");
            }
            if (!tenant.Pets)
            {
                throw new ArgumentException("Please indicate if you have pets");
            }
            if (!tenant.Smoker)
            {
                throw new ArgumentException("Please indicate if you smoke");
            }
            if (tenant.Gender != Gender.Male && tenant.Gender != Gender.Female)
            {
                throw new ArgumentException("Enter a gender");
            }
            if(tenant.RentalTerm <= 0)
            {
                throw new ArgumentException("Please indicate your preferred rental term");
            }
            if(tenant.Budget <= 0)
            {
                throw new ArgumentException("Please put in your budget");
            }
            if (!tenant.ParkingRequired)
            {
                throw new ArgumentException("Please indicate if you will need parking");
            }
            if (!tenant.FurnitureRequired)
            {
                throw new ArgumentException("Please indicate if you a furnished or unfurnished home");
            }
            if (!tenant.GardenRequired)
            {
                throw new ArgumentException("Please indicate if you would like a garden");
            }
            if (tenant.BedRoomsRequired <= 0)
            {
                throw new ArgumentException("Please put in the number of bedrooms you would like");
            }
            if(tenant.Address == null)
            {
                throw new ArgumentException("Your current address is required");
            }
            if(tenant.PreferredAdress == null)
            {
                throw new ArgumentException("Enter the address where you would like you home to be near");
            }
            if(tenant.RoomMates == null)
            {
                throw new ArgumentException("Roomates list cannot be null");
            }
            if (tenant.FloorSizeRequired <=0)
            {
                throw new ArgumentException("Floor size required");
            }
           
        }


        public static void AddRightMoveHomeToRentalHome(List<RentalHome> rentalHomesList, List<RightmoveRentalHomeData> rightMoveHomesList, string googleAPIKey)
        {
            List<RightmoveRentalHomeData> rightMoveData = GetDataFromRightMove(2);

            foreach (var rightMoveHome in rightMoveData)
            {
                RentalHome newRentalHome = new RentalHome(rightMoveHome, googleAPIKey);
                rentalHomesList.Add(newRentalHome);
                
            }
        }




    }
}
