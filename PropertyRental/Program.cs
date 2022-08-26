using System;

namespace PropertyRental 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Address();
            a1.DoorNumber = 5;
            a1.Street = "Derby Road";
            a1.City = "Nottingham";
            a1.PostCode = "NG5 3LW";

            var a2 = new Address();
            a2.DoorNumber = 33;
            a2.Street = "Brook Street";
            a2.City = "Nottingham";
            a2.PostCode = "NG1 1EA";

            var a3 = new Address();
            a3.DoorNumber = 47;
            a3.Street = "Brook Street";
            a3.City = "Nottingham";
            a3.PostCode = "NG1 1EA";

            var a4 = new Address();
            a4.DoorNumber = 5;
            a4.Street = "Daleham Mews";
            a4.City = "London";
            a4.PostCode = "NW3 5DB";
                    
            var a5 = new Address();
            a5.DoorNumber = 5;
            a5.Street = "Blake hall road";
            a5.City = "London";
             a5.PostCode = "E11 2QQ";
            
            var a6 = new Address();
            a6.DoorNumber = 5;
            a6.Street = "Boydell Court";
            a6.City = "London";
            a6.PostCode = "NW8 6Nh";

            var a7 = new Address();
            a7.DoorNumber = 44;
            a7.Street = "Lowndes Square";
            a7.City = "London";
            a7.PostCode = "SW1 9xt";

            var a8 = new Address();
            a8.DoorNumber = 41;
            a8.Street = "Sydenham hill";
            a8.City = "London";
            a8.PostCode = "se26 6th";


            var retList = new List<Address>();  
            retList.Add(a1);    
            retList.Add(a2);
            retList.Add(a3);
            retList.Add(a4);
            retList.Add(a5);
            retList.Add(a6);
            retList.Add(a7);
            retList.Add(a8);



        }

        public static Tenant GenTenant()  //todo: make this a list of tenants
        {
            var t1 = new Tenant();

            t1.FirstName = "john";
            var a3 = new Address();
            a3.Street = "sesame street";
            a3.DoorNumber = 5;
            t1.Address = a3;

            return t1;
        }
    }
}