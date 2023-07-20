using Serilog;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using static PropertyRental.LogicMethods;

namespace PropertyRental
{
    public class UiMethods
    {

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

        /// <summary>
        /// This method validates that the tenant puts in the correct information
        /// </summary>
        /// <param name="tenant"></param>
        /// <returns></returns>
        public static ValidationResult ValidateTenant(Tenant tenant)
        {
            var result = new ValidationResult();
            result.Valid = false;


            if (string.IsNullOrEmpty(tenant.FirstName))
            {
                result.ErrorMessage = "Enter your first name";
            }
            if (string.IsNullOrEmpty(tenant.LastName))
            {
                result.ErrorMessage = "Enter your last name";
            }
            if (tenant.BirthDate == default(DateTime))
            {
                result.ErrorMessage = "Please put in a valid date of birth";
            }
            if (tenant.AvailableToMoveOn == default(DateTime))
            {
                result.ErrorMessage = "Put in the date that you want to move";
            }
            if (tenant.MustMoveInOnThisDate == default(DateTime))
            {
                result.ErrorMessage = "The date that you need to move by";
            }
            if (string.IsNullOrEmpty(tenant.JobTitle))
            {
                result.ErrorMessage = "Put in your job title";
            }
            if (string.IsNullOrEmpty(tenant.Nationality))
            {
                result.ErrorMessage = "Put in your nationality";
            }
            if (tenant.Salary <= 0)
            {
                result.ErrorMessage = "Please provide your salary";
            }
            if (tenant.Pets != true && tenant.Pets != false)
            {
                result.ErrorMessage = "Please indicate if you have pets";
            }
            if (tenant.Smoker != true && tenant.Smoker != false)
            {
                result.ErrorMessage = "Please indicate if you smoke";
            }
            if (tenant.Gender != Gender.Male && tenant.Gender != Gender.Female)
            {
                result.ErrorMessage = "Enter a gender";
            }
            if (tenant.RentalTerm <= 0)
            {
                result.ErrorMessage = "Please indicate your preferred rental term";
            }
            if (tenant.Budget <= 0)
            {
                result.ErrorMessage = "Please put in your budget";
            }
            if (tenant.ParkingRequired != true && tenant.ParkingRequired != false)
            {
                result.ErrorMessage = "Please indicate if you will need parking";
            }
            if (tenant.FurnitureRequired != true && tenant.FurnitureRequired != false)
            {
                result.ErrorMessage = "Please indicate if you a furnished or unfurnished home";
            }
            if (tenant.GardenRequired != true && tenant.GardenRequired != false)
            {
                result.ErrorMessage = "Please indicate if you would like a garden";
            }
            if (tenant.BedRoomsRequired <= 0)
            {
                result.ErrorMessage = "Please put in the number of bedrooms you would like";
            }
            if (tenant.Address == null)
            {
                result.ErrorMessage = "Your current address is required";
            }
            if (tenant.PreferredAdress == null)
            {
                result.ErrorMessage = "Enter the address where you would like you home to be near";
            }
            if (tenant.FloorSizeRequired <= 0)
            {
                result.ErrorMessage = "Floor size required";
            }


            return result;

        }

        public static void SendRentalApplication(Tenant tenant, Landlord landlord, string smtpServer, int port, string username, string password, string emailSubject,
                                                  string emailBody, string pdfPath)
        {
            WriteToLog();

            ValidationResult valResult = ValidateTenant(tenant);

            if (!valResult.Valid)
            {
                Console.WriteLine(valResult.ErrorMessage);
            }

            //Create the pdf file
            CreatedPdfDoc(tenant, pdfPath);


            try
            {
                string email = "john@doe.com";
                using (var message = new MailMessage(new MailAddress(email), landlord.ContactInformation.Email))
                {
                    message.Subject = emailSubject;
                    message.Body = emailBody;

                    //Attachy the pdfFile
                    System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(pdfPath);
                    message.Attachments.Add(attachment);



                    using (var client = new SmtpClient(smtpServer, port))
                    {
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(username, password);
                        client.Send(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine("An error occurred while sending the email: " + ex.Message);
            }
        }


        public static List<RentalHome> AddRightMoveHomeToRentalHome(List<RightmoveRentalHomeData> rightMoveHomeList, List<RentalHome> rentalHomesList, string googleAPIKey)
        {
            WriteToLog();
         
            try
            {
                //List<RentalHome> rentalHomesList = new List<RentalHome>();
                foreach (var rmHome in rightMoveHomeList)
                {
                    RentalHome newRentalHome = new RentalHome(rmHome, googleAPIKey);
                    rentalHomesList.Add(newRentalHome);
                }
                return rentalHomesList;
            }
            catch (Exception ex)
            {
                Log.Error($"ERROR: {ex.Message}");
                return null;
            }
        }

        




    }
}

