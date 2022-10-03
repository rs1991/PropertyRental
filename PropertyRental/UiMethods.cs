using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Net.Mail;
using System.Xml;

namespace PropertyRental
{
    public class UiMethods
    {






        

        public static void WriteTenantList(List<Tenant> TenantList, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tenant>));

            using (FileStream file = File.Create(path))
            {
                var streamWriter = XmlWriter.Create(file, new()
                {
                    Encoding = Encoding.UTF8,
                    Indent = true
                }); 
      
                serializer.Serialize(streamWriter, TenantList);
            }
        }

        

        

        public static void WriteAddressList(List<Address> AddressList, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tenant>));
            using (FileStream file = File.Create(path))
            {
                serializer.Serialize(file, AddressList);
            }

        }

        public static List<Address> LoadAddressList(string path)
        {
            List<Address> AddressList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Address>));
            using (FileStream file = File.OpenRead(path))
            {
                AddressList = serializer.Deserialize(file) as List<Address>;
            }
            return AddressList;
        }


        public static List<RentalProperty> RentalPropertyList()
        {

            var rp1 = new RentalProperty();

            rp1.Furnished = true;
            rp1.Price = 1350;
            rp1.RentalDuration = 12;
            rp1.AvailableOn = new DateOnly(2022, 11, 22);
            rp1.BedRooms = 1;
            rp1.Description = "This light and spacious ground floor one bedroom flat.";
            rp1.Agency = "Sargeants";
            rp1.Heating = EnergyType.Gas;
            rp1.CouncilTaxBand = CouncilTaxBand.Band_C;
            rp1.PropertyType = TypeOfProperty.Flat;
            rp1.SmokingAllowed = true;


            var a1 = new Address();

            a1.DoorNumber = 134;
            a1.Street = "Darwin Road";
            a1.City = "London";
            a1.PostCode = "W5 3RE";
            rp1.Address = a1;

            var rp2 = new RentalProperty();

            rp2.Furnished = false;
            rp2.Price = 2200;
            rp2.RentalDuration = 12;
            rp2.AvailableOn = new DateOnly(2022, 10, 13);
            rp2.BedRooms = 4;
            rp2.Description = "We are delighted to offer for rent this 4 bedroom terrace house within walking distance to local amenities";
            rp2.Agency = "Open Rent";
            rp2.Heating = EnergyType.Gas;
            rp2.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp2.PropertyType = TypeOfProperty.House;
            rp2.SmokingAllowed = false;


            var a2 = new Address();

            a2.DoorNumber = 90;
            a2.Street = "Victoria Road";
            a2.City = "London";
            a2.PostCode = "N9 4XV";
            rp2.Address = a2;

            var rp3 = new RentalProperty();

            rp3.Furnished = false;
            rp3.Price = 11700;
            rp3.RentalDuration = 12;
            rp3.AvailableOn = new DateOnly(2023, 01, 02);
            rp3.BedRooms = 3;
            rp3.Description = "An outstanding three bedroom Georgian family home";
            rp3.Agency = "Dexters";
            rp3.Heating = EnergyType.Electric;
            rp3.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp3.PropertyType = TypeOfProperty.House;
            rp3.SmokingAllowed = true;


            var a3 = new Address();

            a3.DoorNumber = 4;
            a3.Street = "Lincoln Street";
            a3.City = "London";
            a3.PostCode = "SW3 4QX";
            rp3.Address = a3;

            var rp4 = new RentalProperty();


            rp4.Furnished = true;
            rp4.Price = 1000;
            rp4.RentalDuration = 12;
            rp4.AvailableOn = new DateOnly(2022, 11, 30);
            rp4.BedRooms = 1;
            rp4.Description = "Situated just moments from Crystal Palace Station and Park";
            rp4.Agency = "Streets ahead";
            rp4.Heating = EnergyType.Electric;
            rp4.CouncilTaxBand = CouncilTaxBand.Band_A;
            rp4.PropertyType = TypeOfProperty.Flat;
            rp4.SmokingAllowed = true;

            var a4 = new Address();

            a4.DoorNumber = 31;
            a4.Street = "Hamlet road";
            a4.City = "London";
            a4.PostCode = "SE20 1NF";
            rp4.Address = a4;

            var rp5 = new RentalProperty();

            rp5.Furnished = false;
            rp5.Price = 1700;
            rp5.RentalDuration = 12;
            rp5.AvailableOn = new DateOnly(2022, 09, 29);
            rp5.BedRooms = 2;
            rp5.Description = "A spacious 2 bedroom bungalow built circa 1930 ";
            rp5.Agency = "Amanda Roberts agency";
            rp5.Heating = EnergyType.Solar;
            rp5.CouncilTaxBand = CouncilTaxBand.Band_B;
            rp5.PropertyType = TypeOfProperty.Bungalow;
            rp5.SmokingAllowed = false;


            var a5 = new Address();

            a5.DoorNumber = 2;
            a5.Street = "Sunset Avenue";
            a5.City = "London";
            a5.PostCode = "E4 8OM";
            rp5.Address = a5;

            var rp6 = new RentalProperty();

            rp6.Furnished = true;
            rp6.Price = 2400;
            rp6.RentalDuration = 12;
            rp6.AvailableOn = new DateOnly(2022, 12, 14);
            rp6.BedRooms = 2;
            rp6.Description = "Rare to market, very unique and modern";
            rp6.Agency = "Open rent";
            rp6.Heating = EnergyType.Solar;
            rp6.CouncilTaxBand = CouncilTaxBand.Band_A;
            rp6.PropertyType = TypeOfProperty.Bungalow;
            rp6.SmokingAllowed = false;

            var a6 = new Address();

            a6.DoorNumber = 190;
            a6.Street = "Bury Street";
            a6.City = "London";
            a6.PostCode = "N9 9JZ";
            rp6.Address = a6;

            var rp7 = new RentalProperty();

            rp7.Furnished = true;
            rp7.Price = 5850;
            rp7.RentalDuration = 6;
            rp7.AvailableOn = new DateOnly(2023, 02, 10);
            rp7.BedRooms = 2;
            rp7.Description = "This stunning and truly unique penthouse apartment is full of character ";
            rp7.Agency = "John D Wood and Co";
            rp7.Heating = EnergyType.Gas;
            rp7.CouncilTaxBand = CouncilTaxBand.Band_C;
            rp7.PropertyType = TypeOfProperty.Flat;
            rp7.SmokingAllowed = false;

            var a7 = new Address();

            a7.DoorNumber = 190;
            a7.Street = "Water road";
            a7.City = "London";
            a7.PostCode = "W4 7XT";
            rp7.Address = a7;

            var rp8 = new RentalProperty();

            rp8.Furnished = true;
            rp8.Price = 2500;
            rp8.RentalDuration = 3;
            rp8.AvailableOn = new DateOnly(2022, 12, 10);
            rp8.BedRooms = 2;
            rp8.Description = "Proud to present this luxury, bright, and spacious";
            rp8.Agency = "B&C Properties";
            rp8.Heating = EnergyType.Gas;
            rp8.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp8.PropertyType = TypeOfProperty.Flat;
            rp8.SmokingAllowed = false;

            var a8 = new Address();

            a8.DoorNumber = 40;
            a8.Street = "Tizzard Grove";
            a8.City = "London";
            a8.PostCode = "SE13 8EQ";
            rp8.Address = a8;

            var rp9 = new RentalProperty();

            rp9.Furnished = true;
            rp9.Price = 67000;
            rp9.RentalDuration = 12;
            rp9.AvailableOn = new DateOnly(2022, 03, 01);
            rp9.BedRooms = 5;
            rp9.Description = "Home near Harrods";
            rp9.Agency = "Stanley Properties";
            rp9.Heating = EnergyType.Gas;
            rp9.CouncilTaxBand = CouncilTaxBand.Band_D;
            rp9.PropertyType = TypeOfProperty.House;
            rp9.SmokingAllowed = false;

            var a9 = new Address();

            a9.DoorNumber = 12;
            a9.Street = "Herbert Crescent";
            a9.City = "London";
            a9.PostCode = "SW1X 7LA";
            rp9.Address = a9;

            var rp10 = new RentalProperty();

            rp10.Furnished = false;
            rp10.Price = 4000;
            rp10.RentalDuration = 12;
            rp10.AvailableOn = new DateOnly(2022, 10, 03);
            rp10.BedRooms = 4;
            rp10.Description = "A stunning four-bedroom mid-terrace house situated ";
            rp10.Agency = "View Properties";
            rp10.Heating = EnergyType.Electric;
            rp10.CouncilTaxBand = CouncilTaxBand.Band_A;
            rp10.PropertyType = TypeOfProperty.House;
            rp10.SmokingAllowed = false;

            var a10 = new Address();

            a10.DoorNumber = 18;
            a10.Street = "Brownlow road";
            a10.City = "London";
            a10.PostCode = "E8 4FE";
            rp10.Address = a10;

            List<RentalProperty> ListOfRentalProperties = new List<RentalProperty>();
            ListOfRentalProperties.Add(rp1);
            ListOfRentalProperties.Add(rp2);
            ListOfRentalProperties.Add(rp3);
            ListOfRentalProperties.Add(rp4);
            ListOfRentalProperties.Add(rp5);
            ListOfRentalProperties.Add(rp6);
            ListOfRentalProperties.Add(rp7);
            ListOfRentalProperties.Add(rp8);
            ListOfRentalProperties.Add(rp9);
            ListOfRentalProperties.Add(rp10);

            return ListOfRentalProperties;
        }


        public static void WriteRentalPropertyList(List<RentalProperty> ListOfRentalProperties, string path2)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<RentalProperty>));
            using (FileStream file = File.Create(path2))
            {
                serializer.Serialize(file, ListOfRentalProperties);
            }

        }
        public static List<RentalProperty> LoadRentalPropertyList(string path2)
        {
            List<RentalProperty> ListOfRentalProperties;
            XmlSerializer serializer = new XmlSerializer(typeof(List<RentalProperty>));
            using (FileStream file = File.OpenRead(path2))
            {
                ListOfRentalProperties = serializer.Deserialize(file) as List<RentalProperty>;
            }
            return ListOfRentalProperties;
        }



    }
}
