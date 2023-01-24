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

        /// <summary>
        /// Method to get the website and convert it to a document
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static HtmlDocument GetWebDocument(string url)
        {
            HtmlWeb website = new HtmlWeb();
            HtmlDocument doc = new HtmlDocument();
            
            return doc;
        }

        /*
        public static List<string> GetHomesList(string url)
        {
            var List<string> homeLinks = new List<string>();
            HtmlDocument doc = GetWebDocument(url);
            HtmlNodeCollection linkNodes = doc.DocumentNode.SelectNodes(xpath: "");

            

            return homeLinks;

        }
        */
        
    }
}
