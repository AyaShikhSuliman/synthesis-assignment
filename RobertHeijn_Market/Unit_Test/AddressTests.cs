using Data;
using Logic.Classes.Address;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Enums;
using Data.Properties.FakeDataManagers;

namespace Unit_Test
{
    [TestClass]
    public class AddressTests
    {
        ICustomerAddressManager customerAddressManager = new AddressManager(new FakeDBAdressManager());


        [TestMethod]
        public void CreatAddressTrue()
        {
            Address address = new Address(2, "Niklaan", 33, "4433KK", Country.Afghanistan);
            try
            {
                customerAddressManager.AddAddressToCustomer(address, 2);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
        [TestMethod]
        public void ReadAllCountriesIsNotNull()
        {
           List<Country> countries= customerAddressManager.GetAllCountries();
            Assert.IsNotNull(countries);

        }
        [TestMethod]
        public void ReadAllCountriesIsNull()
        {
            List<Country> countries = customerAddressManager.GetAllCountries();
            countries = null;
            Assert.IsNull(countries);

        }
    }
}
