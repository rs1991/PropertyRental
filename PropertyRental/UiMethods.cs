using Serilog;

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


    }
}
