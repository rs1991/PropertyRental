using System;
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;

namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
                      

            var path = @"C:\tmp\TenantList.xml";

            List<Tenant> TenantList = LoadTenantList(path);

            WriteTenantList(TenantList, path);


            Tenant tenant = new Tenant();
            List<RentalProperty> Rental = LoadRentalPropertyList(path);


            MatchTenantWithProperty(tenant, Rental);



            //TODO: create matching method (input one tenant, list properties) / return list of matches

            //TODO: Build a rating system in the form of a class  

            //TODO: Create a new blazor project 

            //TODO: Free all of my Enums from weird classes (See RentalPropertyType)

            //TODO: Refactoring of the code 

        }


    }
}