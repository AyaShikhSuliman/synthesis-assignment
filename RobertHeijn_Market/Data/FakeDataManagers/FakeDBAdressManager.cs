using Logic.Classes.Accounts.Customer;
using Logic.Classes.Accounts.DesktopAdministrator;
using Logic.Classes.Address;
using Logic.Enums;
using Logic.Interfaces.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Properties.FakeDataManagers
{
    public class FakeDBAdressManager : IDBAddressManager
    {
        private List<Address> addresses = new List<Address>();
        public FakeDBAdressManager()
        {
            Address address = new Address(1, "Rachesmolen", 24, "4433KK", Country.Poland);
            addresses.Add(address);
        }
        
        public void CreateAddress(Address address, int customerId)
        {
            addresses.Add(address);
        }

        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();
            foreach (Address address in addresses)
            {
                countries.Add(address.Country);
            }
            return countries;
        }
    }
}
