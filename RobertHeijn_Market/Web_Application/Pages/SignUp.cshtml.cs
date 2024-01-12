using Data;
using Logic.Classes.Accounts.Customer;
using Logic.Interfaces.Logic.Customers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Application.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }
        public string Message { get; set; }
        private ICustomerManager CustomerManager;

        public void OnPost()
        {
            CustomerManager = new CustomerManager(new DBCustomerManager());

            if (CustomerManager.SignUp(Customer))
            {
                Response.Redirect("/LogIn");
            }
            else
            {
                Message = $"There is already an account with this emailaddress:{Customer.EmailAddress} !";

                Customer.Name = "";
                Customer.LastName = "";
                Customer.EmailAddress = "";
                Customer.PhoneNumber = 0;
            }
        }
    }
}
