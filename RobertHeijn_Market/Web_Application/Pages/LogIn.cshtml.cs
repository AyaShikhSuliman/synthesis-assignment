using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Data;
using Logic.Classes.Accounts.Customer;
using Logic.Interfaces.Logic.Customers;
using Logic.Classes.Accounts;

namespace Web_Application.Pages
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        private ICustomerManager CustomerManager = new CustomerManager(new DBCustomerManager());

		public void OnPost()
        {
            if (CustomerManager.LogiIn(Customer.EmailAddress, Customer.Password))
            {
                CustomerID = CustomerManager.GetCustomerId(Customer.EmailAddress);

                HttpContext.Session.SetInt32("CustomerID", CustomerID);

                Response.Redirect("/Index");
            }
        }
	}
}
