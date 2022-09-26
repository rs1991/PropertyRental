using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PropertyRental.UiMethods;

namespace PropertyRental
{
    public class LogicMethods
    {

        public static void MatchTenantWithProperty(Tenant tenant, List<RentalProperty> rentalProperties)
        {

            //example var averageSmkersPrice = rentalProperties.Where(p => p.SmokingAllowed == true).Average(x => x.Price);

            List<RentalProperty> matches = new();

            foreach(var property in rentalProperties)
            {
                if(tenant.Smoker == property.SmokingAllowed || tenant.Smoker == false)
                {
                    //its a match only concering smoking things
                    matches.Add(property);
                }
            }


            throw new NotImplementedException();

            if (tenant.Smoker == true)
            {
                foreach (var property in rentalProperties)
                {
                    if (property.SmokingAllowed == true)
                    {
                        Console.WriteLine(property);
                    }
                }
            }

        }
    }
}
