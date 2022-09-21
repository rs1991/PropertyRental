using System;
using static PropertyRental.UiMethods;

namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            var path = @"C:\tmp\TenantList.xml";


            List<Tenant> TenantList = LoadTenantList(path);

            WriteTenantList(TenantList, path);




            //TODO: create mock rental property data

            //TODO: create matching method (input one tenant, list properties) / return list of matches

            //TODO: Build a rating system in the form of a class  

            //TODO: Create a new blazor project 

        }


    }
}