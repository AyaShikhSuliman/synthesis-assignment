using Logic.Classes.Accounts.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic.Customers
{
	public  interface IWebsiteAdministratorCustomerManager
	{
		List<Customer> GetCustomers();
		void EditCustomer(Customer customer);
		bool ValidateEmail(string email);
    }
}
