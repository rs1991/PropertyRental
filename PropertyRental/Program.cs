using System;
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;

namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
            var path = @"C:\tmp\ListOfRentalProperties.xml";


            //List<Tenant> TenantList = LoadTenantList(path1);

            //WriteTenantList(TenantList, path1);
            //List<RentalProperty> ListOfRentalProperties = LoadRentalPropertyList(path1);
            //WriteRentalPropertyList(ListOfRentalProperties, path1);
            GenerateRentalProperty();

            Tenant tenant = new Tenant();
            List<RentalProperty> Rental = LoadRentalPropertyList(path);


            MatchTenantWithProperty(tenant, Rental);



            //TODO: create matching method (input one tenant, list properties) / return list of matches

            //TODO: Build a rating system in the form of a class  

            //TODO: Create a new blazor project 

            

           

        }


    }
}