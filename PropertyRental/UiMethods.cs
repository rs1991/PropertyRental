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
using ScrapySharp.Network;
using Serilog;

namespace PropertyRental
{
    public class UiMethods
    {        
        
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
        public static void WriteLog()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(@"C:\tmp\log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            //Log.Information("Information");

        }



    }
}
