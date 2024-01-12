using Logic.Classes.Orders;
using Logic.Enums;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using Logic.Interfaces.Logic.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.Classes.Accounts.Customer
{
    public class CustomerManager : ICustomerManager, IWebsiteAdministratorCustomerManager, IPasswordValidation
    {
        private IDBCustomerManager dBCustomerManager;

        public CustomerManager(IDBCustomerManager dBCustomerManager)
        {
            this.dBCustomerManager = dBCustomerManager;
        }

        public bool ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Customer> GetCustomers()
        {
            return dBCustomerManager.ReadAllCustomers();
        }

        public bool LogiIn(string emailAddress, string password)
        {
            string hashedPassword = GenerateHash(password + dBCustomerManager.ReadSalt(emailAddress));
            return dBCustomerManager.ReadCustomer(emailAddress, hashedPassword);
        }

        public bool SignUp(Customer customer)
        {
            string generatedSalt = GenerateSalt();
            string generatedPassword = customer.Password + generatedSalt;

            foreach (Customer customer1 in GetCustomers())
            {
                if (customer1.EmailAddress == customer.EmailAddress)
                {
                    return false;
                }

                customer = new Customer(0, customer.Name, customer.LastName, customer.EmailAddress, customer.PhoneNumber, customer.Address, GenerateHash(generatedPassword), generatedSalt, customer.Orders);
                this.dBCustomerManager.CreateCustomer(customer);

                return true;
            }

            return false;
        }

        public void EditCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public string GenerateSalt()
        {
            RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
            var size = new byte[32];
            rNGCryptoServiceProvider.GetBytes(size);
            return Convert.ToBase64String(size);
        }

        public string GenerateHash(string password)
        {
            using (var sha256Managed = new SHA256Managed())
            {
                var hashedBytes = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hashedPassword;
            }
        }

        public int GetCustomerId(string emailAddress)
        {
            return dBCustomerManager.ReadCustomerId(emailAddress);
        }

        public Customer GetCustomer(int id)
        {
            return dBCustomerManager.ReadCustomer(id);
        }
    }
}
