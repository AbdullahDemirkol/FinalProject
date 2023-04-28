using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entity.Concrete.Basket.Order
{
    public class Address
    {

        public Address(string neighbourhood, string street,  string buildingNo, string apartmentNo, string district, string city, string country, string zipCode)
        {
            Neighbourhood = neighbourhood;
            Street = street;
            BuildingNo = buildingNo;
            ApartmentNo = apartmentNo;
            District = district;
            City = city;
            Country = country;
            ZipCode = zipCode;
        }

        public int Id { get; set; }
        public string Neighbourhood { get; set; }
        public string Street { get; set; }
        public string BuildingNo { get; set; }
        public string ApartmentNo { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
