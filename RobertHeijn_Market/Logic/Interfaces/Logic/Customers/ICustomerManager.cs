using Logic.Classes.Accounts.Customer;
using Logic.Classes.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic.Customers
{
    public interface ICustomerManager
    {
        bool LogiIn(string emailAddress, string password);
        bool SignUp(Customer customer);
        List<Customer> GetCustomers();
        Customer GetCustomer(int id);
        int GetCustomerId(string emailAddress);
    }
}
