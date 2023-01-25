using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Xml;
using System.Text.RegularExpressions;
using static PropertyRental.LogicMethods;
using System.Collections;
using System.Net;
using HtmlAgilityPack;
using ScrapySharp.Network;

namespace PropertyRental
{
    public class UiMethods
    {        
        
        public static void displayScoreOnly(List<RentalHomeScore> ScoresList)
        {
            foreach(var score in ScoresList)
            {
                Console.WriteLine($"Score: {score.Score} Address: {score.Rental.Address.PostCode} {score.Tenant.FirstName}");
            }
        }
                

        public static void GetDataFromWeb()
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load("https://www.gumtree.com/search?featured_filter=false&q=&search_category=property-to-rent&urgent_filter=false&sort=date&search_scope=false&photos_filter=false&search_location=London&tl=&distance=0.0001");
            var nodes = htmlDoc.DocumentNode.SelectNodes("//h2");

            foreach (var node in nodes)
            {
                Console.WriteLine(node.InnerText);
            }
        }
    }
}
