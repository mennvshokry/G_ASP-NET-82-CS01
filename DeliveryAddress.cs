using System;
namespace SmartDeliveryManagementSystem
{
    public struct DeliveryAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public DeliveryAddress(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {Country}";
        }
    }

}

