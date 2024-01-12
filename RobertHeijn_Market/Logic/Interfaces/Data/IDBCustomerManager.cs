using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Classes;
using Logic.Classes.Accounts.Customer;

namespace Logic.Interfaces.Data
{
    public interface IDBCustomerManager
    {
        List<Customer> ReadAllCustomers();
        bool ReadCustomer(string emailAddress, string password);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        string ReadSalt(string email);
        int ReadCustomerId(string emailAddress);
        Customer ReadCustomer(int id);
    }
}
