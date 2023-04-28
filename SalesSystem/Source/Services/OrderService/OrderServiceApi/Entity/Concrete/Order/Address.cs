using OrderServiceApi.Entity.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Order
{
    public class Address: BaseEntity
    {
        public Guid BuyerId { get; set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Neighbourhood { get; set; }
        public string BuildingNo { get; set; }
        public string ApartmentNo { get; set; }
        public string District { get; set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

        public Address(string neighbourhood, string street, string buildingNo, string apartmentNo, string district, string city, string country, string zipCode)
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
    }
}
