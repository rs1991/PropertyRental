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
        


        public static void DisplayTheScoreForEachTenant(List<Tenant> TenantList, List<RentalHome> RentalHomes, string api)
        {
            foreach (var home in RentalHomes)
            {
                foreach (var tenant in TenantList)
                {
                    double score = PointsScoredForEachHome(tenant, home, api);
                    Console.WriteLine($"{tenant.FirstName} {home.Address.PostCode} Score: {score}");
                }
            }
        }

        public static void DisplayTheScore(List<RentalHome> ListOfRentalHomes, List<Tenant> TenantList, string api)
        {

            foreach(var tenant in TenantList)
            {
                DisplayScoreForEachHome(ListOfRentalHomes, tenant, api);

            }
            

        }



    }
    }
