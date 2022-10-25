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
            List<RentalHome> RentalHomes = LogicMethods.GenerateMockRentalPropertyList();

            var dStorage = new DataStorage();

            dStorage.ListOfTenants = TenantList;
            dStorage.ListOfRentalHomes = RentalHomes;
  

            WriteDataStorage(dStorage, path);

            Tenant Tenant = new Tenant();
            Tenant.Smoker = true;
            Tenant.Pets = false;
            Tenant.Children = false;
            Tenant.Budget = 2000;
            Tenant.FurnitureRequired = false;
            Tenant.ParkingRequired = false;
            Tenant.GardenRequired = false;
            Tenant.BedRoomsRequired = 3;
            Tenant.Salary = 122000;
            


            List<RentalHome> Matches = MatchTenantWithHome(Tenant, RentalHomes);
            
            DisplayMatch(Matches);

            RentalHome rentalHome = new RentalHome();
            rentalHome.Price = 5000;
            rentalHome.FloorSize = 110;
            rentalHome.BedRooms = 3;
            rentalHome.Garden = true;
            rentalHome.Parking = false;
            rentalHome.PetsAllowed = true;
            rentalHome.ChildrenAllowed = false;
            rentalHome.SmokingAllowed = true;



            AffordabilityCheck(Tenant, rentalHome);

            int TotalScore = RatingScore(Tenant, rentalHome);

            Console.WriteLine(TotalScore);




            //RatingScore(Tenant, RentalHomes);

            //TODO: Build a rating system in the form of a class 

        }

    }
}