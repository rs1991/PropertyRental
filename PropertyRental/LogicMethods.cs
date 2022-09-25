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

        public static void MatchTenantWithProperty(Tenant tenant, List<RentalProperty> GenerateRentalProperty)
        {
          if(tenant.Smoker == true)
            {
               foreach(var property in GenerateRentalProperty)
                {
                    if(property.Furnished == false)
                    {
                        Console.WriteLine(property);
                    }
                }
            }

        }
    }
}
