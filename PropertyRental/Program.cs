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



        }

       
    }
}