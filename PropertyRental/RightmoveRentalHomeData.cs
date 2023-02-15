using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class RightmoveRentalHomeData
    {
        public double MonthlyRentalPrice{ get; set; }
        public string EstateAgentPhoneNumber{ get; set; }
        public string RentalHomeAddress { get; set; }
        public string RentalHomeDetails { get; set; }
        public string RentalHomeDescription { get; set; }
        public DateTime DateRentalHomeWasAdded { get; set; }
        public string URL { get; set; }
    }
}
