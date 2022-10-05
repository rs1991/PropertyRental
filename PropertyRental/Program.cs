using System;
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;


namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var path = @"C:\tmp\MockDataStorage.xml";
            


            List<Tenant> TenantList = LogicMethods.GenerateMockListOfTenants();
            List<RentalProperty> RentalProperties = LogicMethods.GenerateMockRentalPropertyList();

            var dStorage = new DataStorage();

            dStorage.ListOfTenants = TenantList;
            dStorage.ListOfRentalProperties = RentalProperties;
  

            WriteDataStorage(dStorage, path);

            Tenant Tenant = new Tenant();

            MatchTenantWithProperty(Tenant, RentalProperties);


            //Tenant tenant = new Tenant();
            //List<RentalProperty> Rental = LoadRentalPropertyList(path);


            //MatchTenantWithProperty(tenant, Rental);



            //TODO: create matching method (input one tenant, list properties) / return list of matches

            //TODO: Build a rating system in the form of a class  

            //TODO: Create a new blazor project 



        }


    }
}