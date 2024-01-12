using Logic.Classes.Accounts.Customer;
using Logic.Classes.Address;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
    public interface ICustomerAddressManager
    {
        //void AddAddress(Customer customer);
        List<Country> GetAllCountries();
        void AddAddressToCustomer(Address address, int customerId);
    }
}
