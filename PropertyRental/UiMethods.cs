using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Xml;
using System.Text.RegularExpressions;
using static PropertyRental.LogicMethods;

namespace PropertyRental
{
    public class UiMethods
    {

        public static void DisplayMatch(List<RentalHome> Matches)
        {
            foreach (var Match in Matches)
            {
                Console.WriteLine($"Suitable home: {Match.Address.City} - {Match.Address.PostCode} - {Match.Description}");
            }
        }

        public static void TotalRating(int TotalScore)
        {
            
            Console.WriteLine($"This home has a rating of: {TotalScore}");
        }

        public static void HomeScoreList(List<RentalHome> RentalHomes, Tenant tenant, string api)
        {
            List<RentalHome> ListOfHomes = new List<RentalHome>();
            foreach (var home in RentalHomes)
            {
                    double score = RatingScore(tenant, home, api);
                    ListOfHomes.Add(home);
                    MatchTenantWithHome(tenant, RentalHomes);
                    Console.WriteLine($"Home: {home} Score: {score}");
            }
        }
    }
}
