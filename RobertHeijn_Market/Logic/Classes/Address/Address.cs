using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Enums;

namespace Logic.Classes.Address
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public string Postcode { get; set; }
        public Country Country { get; set; }

        public Address() { }

        public Address(int id, string streetName, int houseNumber, string postcode, Country country)
        {
            Id = id;
            StreetName = streetName;
            HouseNumber = houseNumber;
            Postcode = postcode;
            Country = country;
        }
    }
}
