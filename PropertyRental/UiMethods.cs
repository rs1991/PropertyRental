using Serilog;
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
            throw new NotImplementedException();
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
