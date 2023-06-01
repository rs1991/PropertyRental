using HtmlAgilityPack;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using SendGrid;
using Serilog;
using System;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Numerics;
using SendGrid.Helpers.Mail;
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
                .WriteTo.File(@"C:\tmp\logs\log.txt", rollingInterval: RollingInterval.Day)
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


        public static void SendRentalApplication(Tenant tenant, Landlord landlord, string smtp, int port, string password)
        {
            WriteToLog();
            try
            {
                if (string.IsNullOrEmpty(tenant.FirstName))
                {
                    throw new ArgumentException("Enter your first name");
                }
                if (string.IsNullOrEmpty(tenant.LastName))
                {
                    throw new ArgumentException("Enter your last name");
                }
                if (tenant.BirthDate == default(DateTime))
                {
                    throw new ArgumentException("Please put in a valid date of birth");
                }
                if (tenant.AvailableToMoveOn == default(DateTime))
                {
                    throw new ArgumentException("Put in the date that you want to move");
                }
                if (tenant.MustMoveInOnThisDate == default(DateTime))
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
                if (tenant.Salary <= 0)
                {
                    throw new ArgumentException("Please provide your salary");
                }
                if (tenant.Pets != true && tenant.Pets != false)
                {
                    throw new ArgumentException("Please indicate if you have pets");
                }
                if (tenant.Smoker != true && tenant.Smoker != false)
                {
                    throw new ArgumentException("Please indicate if you smoke");
                }
                if (tenant.Gender != Gender.Male && tenant.Gender != Gender.Female)
                {
                    throw new ArgumentException("Enter a gender");
                }
                if (tenant.RentalTerm <= 0)
                {
                    throw new ArgumentException("Please indicate your preferred rental term");
                }
                if (tenant.Budget <= 0)
                {
                    throw new ArgumentException("Please put in your budget");
                }
                if (tenant.ParkingRequired != true && tenant.ParkingRequired != false)
                {
                    throw new ArgumentException("Please indicate if you will need parking");
                }
                if (tenant.FurnitureRequired != true && tenant.FurnitureRequired != false)
                {
                    throw new ArgumentException("Please indicate if you a furnished or unfurnished home");
                }
                if (tenant.GardenRequired != true && tenant.GardenRequired != false)
                {
                    throw new ArgumentException("Please indicate if you would like a garden");
                }
                if (tenant.BedRoomsRequired <= 0)
                {
                    throw new ArgumentException("Please put in the number of bedrooms you would like");
                }
                if (tenant.Address == null)
                {
                    throw new ArgumentException("Your current address is required");
                }
                if (tenant.PreferredAdress == null)
                {
                    throw new ArgumentException("Enter the address where you would like you home to be near");
                }
                if (tenant.FloorSizeRequired <= 0)
                {
                    throw new ArgumentException("Floor size required");
                }
            MailMessage message = new MailMessage();
            message.From = tenant.ContactInformation.Email;
            message.To.Add(landlord.ContactInformation.Email);
            message.Subject = "My rental application";
            message.Body = "Dear " + landlord.FirstName + ",\n\n" +
            "I am interested in renting your property and have attached my rental application for your review.\n\n" +
            "Please let me know if you require any additional information or documentation.\n\n" +
            "Thank you,\n" +
            tenant.FirstName + " " + tenant.LastName;
            string senderEmail = tenant.ContactInformation.Email.Address;
            SmtpClient smtpClient = new SmtpClient(smtp, port);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(senderEmail, password);
            smtpClient.Send(message);
            }
            catch (ArgumentException argumentException)
            {
                Log.Error(argumentException, "An argument exception has occured");
            }
            catch (SmtpException smptpException)
            {
                Log.Error(smptpException, "An error occurred while sending the email");
            }
            catch (Exception generalException)
            {
                Log.Error(generalException, "An exception has occured");
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
