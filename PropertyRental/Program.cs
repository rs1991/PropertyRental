using System;
using static PropertyRental.UiMethods;
using static PropertyRental.LogicMethods;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PropertyRental
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\tmp\MockDataStorage.xml";
            string api = System.IO.File.ReadAllText(@"C:\Users\Nick\source\repos\PropertyRental\PropertyRental\apiKey.txt");


            List<Tenant> TenantList = LogicMethods.GenerateMockListOfTenants();
            List<RentalHome> RentalHomes = LogicMethods.GenerateMockRentalPropertyList();
            List<Address> AddressList = LogicMethods.GenerateMockAddressList();
          //List<Address> TenantPreferredAddressList = LogicMethods.GenerateMockTenantPreferredAddressList();

            var dStorage = new DataStorage();

            dStorage.ListOfTenants = TenantList;
            dStorage.ListOfRentalHomes = RentalHomes;
            dStorage.ListOfAddresses = AddressList;

            WriteDataStorage(dStorage, path);

            DisplayHomeScoreList(RentalHomes, TenantList, api);


            //TODO: build a loop to test all your data
            //TODO: save those results for a (each) tenatn to a list of RatingSystem


        }

    }
}