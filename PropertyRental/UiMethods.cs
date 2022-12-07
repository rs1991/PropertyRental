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
        public static List<RentalHomeScoreTracker> GenerateRentalHomeScores(List<RentalHome> RentalHomes, Tenant tenant, string api)
        {
            throw new NotImplementedException();
            List<RentalHomeScoreTracker> RentailHomeAndScores = new();

            foreach (var home in RentalHomes)
            {
                double score = PointsScored(tenant, home, api);

                Console.WriteLine($"Home: {home.Address.DoorNumber}, {home.Address.Street}, {home.Address.City}, {home.Address.PostCode} Score: {score} Tenant: {tenant.FirstName}");
            }
        }
      
        public static void DisplayHomeScoreList(List<RentalHome> homes, List<Tenant> tenants, string api)
        //   public static void DisplayHomeScoreList(List<RentailhomeAndScore> RentalHomesAndScore)
        {
            foreach (var t in tenants) { 
            foreach (var h in homes)
            {
                    double score = PointsScored(t, h, api);
                    //HomeScoreListDisplay(ScoresList);
                    //Console.WriteLine($"{h.Address.PostCode} {t.FirstName} {t.LastName} Score: {sc}");
                        Console.WriteLine($"{t.FirstName} {h.Address.PostCode} Score: {score}");
                }
            }
            }
        }



        }
    