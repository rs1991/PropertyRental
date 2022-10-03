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
            var path2 = @"C:\tmp\ListOfRentalProperties.xml";


            List<Tenant> TenantList = LogicMethods.GenerateListOfMockTenants();

            var dStorage = new DataStorage();

            dStorage.ListOfTenants = TenantList;
            WriteTenantList(TenantList, path);

            WriteDataStorage(dStorage, path);

            List<RentalProperty> RentalPropertyList = LoadRentalPropertyList(path2);

            WriteRentalPropertyList(RentalPropertyList, path2);


            //Tenant tenant = new Tenant();
            //List<RentalProperty> Rental = LoadRentalPropertyList(path);


            //MatchTenantWithProperty(tenant, Rental);



            //TODO: create matching method (input one tenant, list properties) / return list of matches

            //TODO: Build a rating system in the form of a class  

            //TODO: Create a new blazor project 



        }


    }
}