using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Xml;
using System.Text.RegularExpressions;

namespace PropertyRental
{
    public class UiMethods
    {

        public static void DisplayMatch(List<RentalHome> Matches)
        {
            foreach (var Match in Matches)
            {
                Console.WriteLine($"Address {Match.Address.City} - {Match.Address.Street}");
            }
        }

        

        

 

    }
}
