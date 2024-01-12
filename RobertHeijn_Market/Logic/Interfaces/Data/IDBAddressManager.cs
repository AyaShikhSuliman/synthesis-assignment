using Logic.Classes.Accounts.Customer;
using Logic.Classes.Address;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
    public interface IDBAddressManager
    {
        //void CreateAddress(Customer customer);
        List<Country> ReadAllCountries();
        void CreateAddress(Address address, int customerId);
    }
}
