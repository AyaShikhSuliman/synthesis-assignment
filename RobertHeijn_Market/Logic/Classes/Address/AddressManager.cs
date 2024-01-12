using Logic.Classes.Accounts.Customer;
using Logic.Enums;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Address
{
    public class AddressManager : ICustomerAddressManager
    {
        private IDBAddressManager dBAddressManager;

        public AddressManager(IDBAddressManager dBAddressManager)
        {
            this.dBAddressManager = dBAddressManager;
        }

        public void AddAddressToCustomer(Address address, int customerId)
        {
            dBAddressManager.CreateAddress(address, customerId);
        }

        //public void AddAddress(Customer.Customer customer)
        //{
        //    String response = dBAddressManager.CreateAddress(customer);
        //    if(response == 'success')
        //    {
        //        showMessage()
        //    } 
        //    else
        //    {
               
        //    }
        //}

        public List<Country> GetAllCountries()
        {
            return dBAddressManager.ReadAllCountries();
        }
    }
}
